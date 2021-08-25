using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVERTIME_PROJECT_01
{
    public partial class FrmSignature : Form
    {
        #region signature_variables

        private Dictionary<int, List<Point>> signatureObject = new Dictionary<int, List<Point>>();
        private Pen signaturePen = new Pen(Color.Black, 4);
        private List<Point> currentCurvePoints;
        private int currentCurve = -1;

        #endregion signature_variables
        public FrmSignature()
        {
            InitializeComponent();
        }
        private void signPicBox_Paint(object sender, PaintEventArgs e)
        {
            if (currentCurve < 0 || signatureObject[currentCurve].Count == 0)
                return;
            DrawSignature(e.Graphics);
        }

        private void signPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            //LastX = e.X;
            //LastY = e.Y;
            currentCurvePoints = new List<Point>();
            currentCurve += 1;
            signatureObject.Add(currentCurve, currentCurvePoints);
        }

        private void signPicBox_MouseMove(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Left)
            //{
            //    PointX = e.X;
            //    PointY = e.Y;
            //    SignaturePad(pictureBox);
            //}

            if (e.Button != MouseButtons.Left || currentCurve < 0)
            {
                return;
            }
            else
            {
                signatureObject[currentCurve].Add(e.Location);
                signPicBox.Invalidate();
            }
        }
        private void onaylaButton_Click(object sender, EventArgs e)
        {
            SaveSignatureImage();
            currentCurve = -1;
            signatureObject.Clear();
            signPicBox.Invalidate();
            signText.Clear();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region signature_functions

        // saving bitmap file that we have created on signature picturebox
        private void SaveSignatureImage()
        {
            var signatureFileName = signText.Text.Trim();

            if (string.IsNullOrEmpty(signatureFileName))
            {
                MessageBox.Show("Lütfen imza ismi giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(currentCurve<0 || signatureObject[currentCurve].Count == 0)
            {
                MessageBox.Show("Lütfen imza atınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int pictureBox_height = signPicBox.Height;
            int pictureBox_width = signPicBox.Width;


            using (Bitmap imgSignature = new Bitmap(pictureBox_width, pictureBox_height,PixelFormat.Format32bppArgb))
            {
                using(Graphics g = Graphics.FromImage(imgSignature))
                {
                    DrawSignature(g);
                    
                    try
                    {
                        string sql_command = "INSERT INTO [dbo].[dbImza] (ImzaGoruntu,MesaiId) VALUES (@arr,@shift_id)";

                        Utils.ExecuteCommandByParameter(sql_command,ConvertImageToBinary(imgSignature),Utils.mesaiId);

                        imgSignature.Save(string.Format(@"C:\Users\Angel Diesel\Desktop\Imzalar\sended\{0}.png", signatureFileName), ImageFormat.Png); 

                        SaveSqlBinaryDataAsImage();

                        MessageBox.Show("İmza başarılı bir şekilde kaydedildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception e)
                    {
                        throw e;
                        MessageBox.Show("Hata", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // draw function that enable us to draw signature on signature picturebox 
        private void DrawSignature(Graphics g)
        {
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            foreach(var curve in signatureObject)
            {
                if (curve.Value.Count < 2)
                {
                    continue;
                }
                using(GraphicsPath graphicsPath = new GraphicsPath())
                {
                    graphicsPath.AddCurve(curve.Value.ToArray(), 0.5F);
                    g.DrawPath(signaturePen, graphicsPath);
                }
            }
        }

        private byte[] ConvertImageToBinary(Bitmap signature_bitmap)
        {
            byte[] data = null;
            using (MemoryStream ms = new MemoryStream())
            {
                signature_bitmap.Save(ms, ImageFormat.Png);
                data = ms.ToArray();
                return data;
            }            
        }

        private Bitmap ConvertBinaryToImage(byte[] binary_data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(binary_data, 0, binary_data.Length);
                ms.Seek(0, SeekOrigin.Begin);
                Bitmap bitmap = new Bitmap(ms);

                return bitmap;
            }
        }

        private void SaveSqlBinaryDataAsImage()
        {
            string sql_command = string.Format("SELECT ImzaGoruntu FROM [dbo].[dbImza] WHERE MesaiId = {0}", Utils.mesaiId);
            byte[] binary_data_of_image = Utils.ReturnByteArraySingleValue(sql_command);
            Bitmap bitmap1 = ConvertBinaryToImage(binary_data_of_image);
            bitmap1.Save(string.Format(@"C:\Users\Angel Diesel\Desktop\Imzalar\getted\{0}.png", "test" + Convert.ToString(Utils.mesaiId), ImageFormat.Png));


        }


        # endregion signature_functions

        private void GeriDonusum(object binary_data,Image imgSignature)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = saveFileDialog.FileName;
                    imgSignature.Save(path, ImageFormat.Bmp);
                }
            }

            ImageConverter converter = new ImageConverter();

            Image img = (Image)converter.ConvertFrom(binary_data);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.Data;
using FastReport.Code;
using FastReport.Editor;
using FastReport.CrossView;
using FastReport;
using FastReport.Export;
using FastReport.Utils;
using FastReport.Export.Pdf;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace OVERTIME_PROJECT_01
{
    public partial class FrmFastReport : Form
    {
        DataSet1TableAdapters.dbOverShiftAllDatasTableAdapter dataset = new DataSet1TableAdapters.dbOverShiftAllDatasTableAdapter();
        DataTable dataTable = new DataTable();
        

        public FrmFastReport()
        {
            InitializeComponent();
        }

        private void FrmFastReport_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'dataSet1.dbOverShiftAllDatas' table. You can move, or remove it, as needed.
            this.dbOverShiftAllDatasTableAdapter.Fill(this.dataSet1.dbOverShiftAllDatas);
            dataTable = dbOverShiftAllDatasTableAdapter.GetData();
        }

        private void gosterButon_Click(object sender, EventArgs e)
        {
            report1.Prepare();
            report1.Show();
        }

        private void rprKaydetButton_Click(object sender, EventArgs e)
        {
            Config.WebMode = true;
            try
            {
                if (report1.Prepare())
                {
                    PDFExport pDFExport = new PDFExport();
                    pDFExport.ShowProgress = false;
                    pDFExport.Subject = "Subject";
                    pDFExport.Title = "Report";
                    pDFExport.Compressed = true;
                    pDFExport.AllowPrint = true;
                    pDFExport.EmbeddingFonts = true;
                    if (File.Exists(@"C:\Users\Angel Diesel\Desktop\Reports\report.pdf"))
                    {
                        FileStream stream = new FileStream(@"C:\Users\Angel Diesel\Desktop\Reports\report.pdf", FileMode.Append,FileAccess.Write);  
                        report1.Export(pDFExport, stream);
                        stream.Dispose();
                    }
                    else
                    {
                        FileStream stream = new FileStream(@"C:\Users\Angel Diesel\Desktop\Reports\report.pdf", FileMode.CreateNew);
                        report1.Export(pDFExport, stream);
                        stream.Position = 0;
                        stream.Dispose();
                    }
                    pDFExport.Dispose();
                }
                MessageBox.Show("Başarılı bir şekilde kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            var result = MessageBox.Show("Rapor kaydedildi. Mail gönderilsin mi?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                FrmMailGonder frmMailGonder = new FrmMailGonder();
                this.Hide();
                frmMailGonder.ShowDialog();
                FrmFastReport_Load(sender, e);
                this.Show();
            }
        }
        
        private void Notlar()
        {
            // Burada bir item'e dispose verdiğimiz zaman ona ait bütün verileri ram üzerinden temizliyor.
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVERTIME_PROJECT_01
{
    public partial class FrmMesai : Form
    {
        public FrmMesai()
        {
            InitializeComponent();
        }

        private void FrmMesai_Load(object sender, EventArgs e)
        {
            KomboxVeriGetir();
            ShowDatas();
        }

        private void KomboxVeriGetir()
        {
            string sorgu = @"SELECT dbCl.*,dbGr.GorevAdi FROM [dbo].[dbCalisan] as dbCl
                             INNER JOIN  [dbo].[dbGorev] as dbGr on dbCl.PersonelGorevId = dbGr.Id ORDER BY dbCl.PersonelAdiSoyadi ASC";
            DataTable dtTable = new DataTable();
            dtTable = Utils.CreateTable(sorgu);
            personelKomboBox.DisplayMember = "PersonelAdiSoyadi";
            personelKomboBox.ValueMember = "Id";
            personelKomboBox.DataSource = dtTable;
            personelKomboBox.SelectedIndex = Utils.personelTabloIndex;
        }

        private void personelKomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.isSelected = false;

            if (personelKomboBox.SelectedIndex > -1)
            {
                gorevTextBox.Text = ((DataTable)(personelKomboBox.DataSource)).Rows[personelKomboBox.SelectedIndex]["GorevAdi"].ToString();             
            }
            else
            {
                return;
            }
        }

        private void mesaiStarTime_ValueChanged(object sender, EventArgs e)
        {
            if (ControlAmongDates(mesaiStarTime.Value, mesaiFinishTime.Value))
            {
                mesaiSure.Text = Utils.Calculate_Hours(mesaiStarTime.Value, mesaiFinishTime.Value).ToString();
            }
            else
            {
                mesaiSure.Text = "0";
            }
        }

        private void mesaiFinishTime_ValueChanged(object sender, EventArgs e)
        {
            if (ControlAmongDates(mesaiStarTime.Value, mesaiFinishTime.Value))
            {
                mesaiSure.Text = Utils.Calculate_Hours(mesaiStarTime.Value, mesaiFinishTime.Value).ToString();
            }
            else
            {               
                mesaiSure.Text = "0";
            }
        }

        private string _izinTuru()
        {
            if (evetRadioButon.Checked)
            {
                return evetRadioButon.Text;
            }
            else
            {
                return hayirRadioButon.Text;
            }
        }

        private bool ControlAmongDates(DateTime firstDate, DateTime secondDate)
        {
            if (firstDate > secondDate)
            {mesaiSure.BackColor = Color.Red;
                mesaiSure.ForeColor = Color.White;
                mesaiSure.TextAlign = HorizontalAlignment.Center;
                
                return false;
            }
            mesaiSure.BackColor = Color.LightGray;
            mesaiSure.ForeColor = Color.Black;
            return true ;
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            string sorgu = "";

            if (mesaiNedenText.TextLength > 5)
            {
                if(mesaiSure.BackColor == Color.LightGray)
                {
                    sorgu = string.Format(@"INSERT INTO [dbo].[dbMesai]                 (MesaiBaslamaTarihiSaat,MesaiBitisTarihiSaat,MesaiNedeni,MesaiSignatureId,MesaiSure,MesaiTuru,CalisanId,MesaiDurumId) VALUES('{0}','{1}','{2}',{3},'{4}','{5}',{6},
                      {7})", mesaiStarTime.Value.ToString("yyyy-MM-dd HH:mm"), mesaiFinishTime.Value.ToString("yyyy-MM-dd HH:mm"), mesaiNedenText.Text, 2, mesaiSure.Text, _izinTuru(), personelKomboBox.SelectedValue,6);

                    if (Utils.ExecuteCommand(sorgu))
                    {
                        MessageBox.Show("Başarılı bir şekilde kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Hata", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearBoxes();
                    }
                    ShowDatas();
                }
                else
                {
                    MessageBox.Show("Lütfen Tarihleri Doğru Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mesaiStarTime.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Mesai Nedenini Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mesaiNedenText.Focus();
                mesaiNedenText.SelectAll();
                return;
            }

        }

        private void ShowDatas()
        {
            string sorgu = "";
            switch (Utils.personelUnvanId)
            {
                case 1: case 2:
                    sorgu = string.Format(@"SELECT dbMes.Id as 'mesaiId', dbMes.*,dbCal.*,dbGor.*,dbDur.Id as 'DurumId',dbDur.DurumKodu,dbDur.DurumAdi FROM [dbo].[dbMesai] AS dbMes
                                            INNER JOIN [dbo].[dbCalisan] AS dbCal ON dbMes.CalisanId = dbCal.Id
                                            INNER JOIN [dbo].[dbGorev] as dbGor ON dbCal.PersonelGorevId = dbGor.Id
                                            INNER JOIN [dbo].[dbDurum] as dbDur ON dbDur.Id = dbMes.MesaiDurumId");
                    break;

                case 3:
                    sorgu = string.Format(@"SELECT dbMes.Id as 'mesaiId',dbMes.*,dbCal.*,dbGor.*,dbDur.Id as 'DurumId',dbDur.DurumKodu,dbDur.DurumAdi FROM [dbo].[dbMesai] AS dbMes
                                            INNER JOIN [dbo].[dbCalisan] AS dbCal ON dbMes.CalisanId = dbCal.Id
                                            INNER JOIN [dbo].[dbGorev] as dbGor ON dbCal.PersonelGorevId = dbGor.Id
                                            INNER JOIN [dbo].[dbDurum] as dbDur ON dbDur.Id = dbMes.MesaiDurumId
                                            WHERE dbDur.Id = 3");
                    break;

                case 4:
                    sorgu = string.Format(@"SELECT dbMes.Id as 'mesaiId',dbMes.*,dbCal.*,dbGor.*,dbDur.Id as 'DurumId',dbDur.DurumKodu,dbDur.DurumAdi FROM [dbo].[dbMesai] AS dbMes
                                            INNER JOIN [dbo].[dbCalisan] AS dbCal ON dbMes.CalisanId = dbCal.Id
                                            INNER JOIN [dbo].[dbGorev] as dbGor ON dbCal.PersonelGorevId = dbGor.Id
                                            INNER JOIN [dbo].[dbDurum] as dbDur ON dbDur.Id = dbMes.MesaiDurumId
                                            WHERE dbDur.Id = 4");
                    break;

                default:
                    break;
            }
            DataTable dataTable = new DataTable();
            dataTable = Utils.CreateTable(sorgu);

            if(dataTable != null && dataTable.Rows.Count != 0)
            {
                listView1.Items.Clear();
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = dataTable.Rows[i]["PersonelAdiSoyadi"].ToString();
                    listViewItem.SubItems.Add(dataTable.Rows[i]["GorevAdi"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["MesaiBaslamaTarihiSaat"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["MesaiBitisTarihiSaat"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["MesaiSure"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["MesaiNedeni"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["DurumAdi"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["mesaiId"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["CalisanId"].ToString());
                    listViewItem.SubItems.Add(dataTable.Rows[i]["DurumId"].ToString());

                    listView1.Items.Add(listViewItem);

                    if(listView1.Items[i].SubItems[9].Text == "2")
                    {
                        listView1.Items[i].BackColor = Color.Red;
                    }
                    else if(listView1.Items[i].SubItems[9].Text == "1")
                    {
                        listView1.Items[i].BackColor = Color.Green;
                    }
                }
            }
            else
            {
                listView1.Items.Clear();
            }
            Utils.isSelected = false;
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Utils.isSelected = false;
            Close();
        }

        private void durumDegistir_Click(object sender, EventArgs e)
        {
            if (Utils.isSelected)
            {
                FrmDurumDegistir frmDurumDegistir = new FrmDurumDegistir();
                Hide();
                frmDurumDegistir.ShowDialog();
                FrmMesai_Load(sender, e);
                Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir mesai talebi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            Utils.mesaiId = Convert.ToInt32(listView1.Items[index].SubItems[7].Text);
            Utils.mesaiDurumId = Convert.ToInt32(listView1.Items[index].SubItems[9].Text);
            Utils.isSelected = true;
        }

        private void clearBoxes()
        {
            personelKomboBox.SelectedIndex = -1;
            gorevTextBox.Clear();
            mesaiStarTime.Value = DateTime.Now;
            mesaiFinishTime.Value = DateTime.Now;
            mesaiNedenText.Clear();
        }
    }
}

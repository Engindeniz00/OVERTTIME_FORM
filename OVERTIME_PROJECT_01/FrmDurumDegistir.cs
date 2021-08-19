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
    public partial class FrmDurumDegistir : Form
    {
        public FrmDurumDegistir()
        {
            InitializeComponent();
        }

        private void FrmDurumDegistir_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM [dbo].[dbDurum] WHERE  Id = 2 OR  Id=3 OR Id=4 OR Id=5";
            DataTable dataTable = new DataTable();
            dataTable = Utils.CreateTable(sorgu);
            komboxDurum.ValueMember = "Id";
            komboxDurum.DisplayMember = "DurumKodu";
            komboxDurum.DataSource = dataTable;
            komboxDurum.SelectedIndex = -1;
        }

        private void komboxDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.onayId = Convert.ToInt32(komboxDurum.SelectedValue);
            if (Utils.onayId == 2)
            {
                iptalNedenText.Enabled = true;
                iptalNedenText.ReadOnly = false;
            }
            else iptalNedenText.Enabled = false; iptalNedenText.Clear();
        }

        private void Temizle()
        {
            komboxDurum.SelectedIndex = -1;
            iptalNedenText.Clear();            
        }

        private void onaylaButon_Click(object sender, EventArgs e)
        {
            string sorgu = "";
            bool kont = false;
            if (Utils.personelUnvanId == 1)
            {
                if (Convert.ToInt32(komboxDurum.SelectedValue) == 2)
                {
                    if (iptalNedenText.Text.Length > 5)
                    {
                        sorgu = string.Format(@"UPDATE dbMesai SET MesaiDurumId = 2 WHERE Id = {0}", Utils.mesaiId);
                        kont = true;
                    }
                    else
                    {
                        MessageBox.Show("İptal nedeni 5'ten fazla harf içermeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        iptalNedenText.Focus();
                        iptalNedenText.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Yetki yetersiz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (Utils.personelUnvanId == 2)
            {
                if (Convert.ToInt32(komboxDurum.SelectedValue) == 2)
                {
                    if (iptalNedenText.Text.Length > 5)
                    {
                        sorgu = string.Format(@"UPDATE dbMesai SET MesaiDurumId = 2 WHERE Id = {0}", Utils.mesaiId);
                        kont = true;
                    }
                    else
                    {
                        MessageBox.Show("İptal nedeni 5'ten fazla harf içermeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        iptalNedenText.Focus();
                        iptalNedenText.SelectAll();
                    }
                }
                else if (Convert.ToInt32(komboxDurum.SelectedValue) == 3)
                {
                    sorgu = string.Format(@"UPDATE dbMesai SET MesaiDurumId = 3 WHERE Id = {0}", Utils.mesaiId);
                    kont = true;
                }

                else
                {
                    MessageBox.Show("Yetki yetersiz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (Utils.personelUnvanId == 3)
            {
                if (Convert.ToInt32(komboxDurum.SelectedValue) == 2)
                {
                    sorgu = string.Format(@"UPDATE dbMesai SET MesaiDurumId = 2 WHERE Id = {0}", Utils.mesaiId);
                    kont = true;
                }
                else if (Convert.ToInt32(komboxDurum.SelectedValue) == 4)
                {
                    sorgu = string.Format(@"UPDATE dbMesai SET MesaiDurumId = 4 WHERE Id = {0}", Utils.mesaiId);
                    kont = true;
                }

                else
                {
                    MessageBox.Show("Lütfen kendi yetkinizdeki onay işlemini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (Utils.personelUnvanId == 4)
            {
                if (Convert.ToInt32(komboxDurum.SelectedValue) == 2)
                {
                    sorgu = string.Format(@"UPDATE dbMesai SET MesaiDurumId = 2 WHERE Id = {0}", Utils.mesaiId);
                    kont = true;
                }
                else if (Convert.ToInt32(komboxDurum.SelectedValue) == 5)
                {
                    sorgu = string.Format(@"UPDATE dbMesai SET MesaiDurumId = 1 WHERE Id = {0}", Utils.mesaiId);
                    kont = true;
                }

                else
                {
                    MessageBox.Show("Lütfen kendi yetkinizdeki onay işlemini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (kont)
            {
                if (Utils.ExecuteCommand(sorgu))
                {
                    MessageBox.Show("İzin başarılı bir şekilde değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Herhangi Bir Değişim Yapılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Temizle();

        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}

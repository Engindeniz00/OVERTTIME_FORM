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
        }

        private void KomboxVeriGetir()
        {
            string sorgu = @"SELECT dbCl.*,dbGr.GorevAdi FROM [dbo].[dbCalisan] as dbCl
                             INNER JOIN  [dbo].[dbGorev] as dbGr on dbCl.PersonelGorevId = dbGr.Id";
            DataTable dtTable = new DataTable();
            dtTable = Utils.CreateTable(sorgu);
            personelKomboBox.DisplayMember = "PersonelAdiSoyadi";
            personelKomboBox.ValueMember = "Id";
            personelKomboBox.DataSource = dtTable;
            personelKomboBox.SelectedIndex = Utils.personelTabloIndex;
        }

        private void personelKomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            mesaiSure.Text = Utils.Calculate_Hours(mesaiStarTime.Value, mesaiFinishTime.Value).ToString();
        }

        private void mesaiFinishTime_ValueChanged(object sender, EventArgs e)
        {
            mesaiSure.Text = Utils.Calculate_Hours(mesaiStarTime.Value, mesaiFinishTime.Value).ToString();
        }
    }
}

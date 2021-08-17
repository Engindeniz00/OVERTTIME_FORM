
namespace OVERTIME_PROJECT_01
{
    partial class FrmMesai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.evetRadioButon = new System.Windows.Forms.RadioButton();
            this.hayirRadioButon = new System.Windows.Forms.RadioButton();
            this.personelKomboBox = new System.Windows.Forms.ComboBox();
            this.gorevTextBox = new System.Windows.Forms.TextBox();
            this.mesaiStarTime = new System.Windows.Forms.DateTimePicker();
            this.mesaiFinishTime = new System.Windows.Forms.DateTimePicker();
            this.mesaiSure = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Görev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesai Başlangıç Tarih Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesai Bitiş Tarih Saat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesai Süresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(63, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "İzin olarak kullanma";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hayirRadioButon);
            this.groupBox1.Controls.Add(this.evetRadioButon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(302, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // evetRadioButon
            // 
            this.evetRadioButon.AutoSize = true;
            this.evetRadioButon.Location = new System.Drawing.Point(19, 20);
            this.evetRadioButon.Name = "evetRadioButon";
            this.evetRadioButon.Size = new System.Drawing.Size(76, 29);
            this.evetRadioButon.TabIndex = 0;
            this.evetRadioButon.TabStop = true;
            this.evetRadioButon.Text = "Evet";
            this.evetRadioButon.UseVisualStyleBackColor = true;
            // 
            // hayirRadioButon
            // 
            this.hayirRadioButon.AutoSize = true;
            this.hayirRadioButon.Location = new System.Drawing.Point(102, 20);
            this.hayirRadioButon.Name = "hayirRadioButon";
            this.hayirRadioButon.Size = new System.Drawing.Size(83, 29);
            this.hayirRadioButon.TabIndex = 1;
            this.hayirRadioButon.TabStop = true;
            this.hayirRadioButon.Text = "Hayır";
            this.hayirRadioButon.UseVisualStyleBackColor = true;
            // 
            // personelKomboBox
            // 
            this.personelKomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personelKomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelKomboBox.FormattingEnabled = true;
            this.personelKomboBox.Location = new System.Drawing.Point(418, 47);
            this.personelKomboBox.Name = "personelKomboBox";
            this.personelKomboBox.Size = new System.Drawing.Size(264, 33);
            this.personelKomboBox.TabIndex = 7;
            this.personelKomboBox.SelectedIndexChanged += new System.EventHandler(this.personelKomboBox_SelectedIndexChanged);
            // 
            // gorevTextBox
            // 
            this.gorevTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gorevTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorevTextBox.Location = new System.Drawing.Point(418, 106);
            this.gorevTextBox.Name = "gorevTextBox";
            this.gorevTextBox.ReadOnly = true;
            this.gorevTextBox.Size = new System.Drawing.Size(264, 30);
            this.gorevTextBox.TabIndex = 8;
            // 
            // mesaiStarTime
            // 
            this.mesaiStarTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.mesaiStarTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaiStarTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mesaiStarTime.Location = new System.Drawing.Point(418, 161);
            this.mesaiStarTime.Name = "mesaiStarTime";
            this.mesaiStarTime.Size = new System.Drawing.Size(264, 30);
            this.mesaiStarTime.TabIndex = 9;
            this.mesaiStarTime.ValueChanged += new System.EventHandler(this.mesaiStarTime_ValueChanged);
            // 
            // mesaiFinishTime
            // 
            this.mesaiFinishTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.mesaiFinishTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaiFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mesaiFinishTime.Location = new System.Drawing.Point(418, 219);
            this.mesaiFinishTime.Name = "mesaiFinishTime";
            this.mesaiFinishTime.Size = new System.Drawing.Size(264, 30);
            this.mesaiFinishTime.TabIndex = 10;
            this.mesaiFinishTime.ValueChanged += new System.EventHandler(this.mesaiFinishTime_ValueChanged);
            // 
            // mesaiSure
            // 
            this.mesaiSure.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mesaiSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaiSure.Location = new System.Drawing.Point(418, 277);
            this.mesaiSure.Name = "mesaiSure";
            this.mesaiSure.ReadOnly = true;
            this.mesaiSure.Size = new System.Drawing.Size(100, 30);
            this.mesaiSure.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 390);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(953, 212);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmMesai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 616);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mesaiSure);
            this.Controls.Add(this.mesaiFinishTime);
            this.Controls.Add(this.mesaiStarTime);
            this.Controls.Add(this.gorevTextBox);
            this.Controls.Add(this.personelKomboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMesai";
            this.Text = "FrmMesai";
            this.Load += new System.EventHandler(this.FrmMesai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton hayirRadioButon;
        private System.Windows.Forms.RadioButton evetRadioButon;
        private System.Windows.Forms.ComboBox personelKomboBox;
        private System.Windows.Forms.TextBox gorevTextBox;
        private System.Windows.Forms.DateTimePicker mesaiStarTime;
        private System.Windows.Forms.DateTimePicker mesaiFinishTime;
        private System.Windows.Forms.TextBox mesaiSure;
        private System.Windows.Forms.ListView listView1;
    }
}

namespace OVERTIME_PROJECT_01
{
    partial class FrmLogin
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
            this.kullaniciKombox = new System.Windows.Forms.ComboBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.sifremiHatirlacheckBox = new System.Windows.Forms.CheckBox();
            this.butonGiris = new System.Windows.Forms.Button();
            this.butonIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // kullaniciKombox
            // 
            this.kullaniciKombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullaniciKombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciKombox.FormattingEnabled = true;
            this.kullaniciKombox.Location = new System.Drawing.Point(299, 73);
            this.kullaniciKombox.Name = "kullaniciKombox";
            this.kullaniciKombox.Size = new System.Drawing.Size(346, 39);
            this.kullaniciKombox.TabIndex = 2;
            this.kullaniciKombox.SelectedIndexChanged += new System.EventHandler(this.kullaniciKombox_SelectedIndexChanged);
            // 
            // sifreText
            // 
            this.sifreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreText.Location = new System.Drawing.Point(299, 122);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(346, 38);
            this.sifreText.TabIndex = 3;
            // 
            // sifremiHatirlacheckBox
            // 
            this.sifremiHatirlacheckBox.AutoSize = true;
            this.sifremiHatirlacheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremiHatirlacheckBox.Location = new System.Drawing.Point(82, 222);
            this.sifremiHatirlacheckBox.Name = "sifremiHatirlacheckBox";
            this.sifremiHatirlacheckBox.Size = new System.Drawing.Size(145, 29);
            this.sifremiHatirlacheckBox.TabIndex = 4;
            this.sifremiHatirlacheckBox.Text = "Beni Hatırla";
            this.sifremiHatirlacheckBox.UseVisualStyleBackColor = true;
            // 
            // butonGiris
            // 
            this.butonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonGiris.Location = new System.Drawing.Point(105, 276);
            this.butonGiris.Name = "butonGiris";
            this.butonGiris.Size = new System.Drawing.Size(232, 71);
            this.butonGiris.TabIndex = 5;
            this.butonGiris.Text = "Giriş";
            this.butonGiris.UseVisualStyleBackColor = true;
            this.butonGiris.Click += new System.EventHandler(this.butonGiris_Click);
            // 
            // butonIptal
            // 
            this.butonIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonIptal.Location = new System.Drawing.Point(390, 276);
            this.butonIptal.Name = "butonIptal";
            this.butonIptal.Size = new System.Drawing.Size(235, 71);
            this.butonIptal.TabIndex = 7;
            this.butonIptal.Text = "Çıkış";
            this.butonIptal.UseVisualStyleBackColor = true;
            this.butonIptal.Click += new System.EventHandler(this.butonIptal_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 393);
            this.Controls.Add(this.butonIptal);
            this.Controls.Add(this.butonGiris);
            this.Controls.Add(this.sifremiHatirlacheckBox);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kullaniciKombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kullaniciKombox;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.CheckBox sifremiHatirlacheckBox;
        private System.Windows.Forms.Button butonGiris;
        private System.Windows.Forms.Button butonIptal;
    }
}


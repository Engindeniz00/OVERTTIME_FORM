
namespace OVERTIME_PROJECT_01
{
    partial class FrmDurumDegistir
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
            this.komboxDurum = new System.Windows.Forms.ComboBox();
            this.iptalNedenText = new System.Windows.Forms.TextBox();
            this.onaylaButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "İptal Neden";
            // 
            // komboxDurum
            // 
            this.komboxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.komboxDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.komboxDurum.FormattingEnabled = true;
            this.komboxDurum.Location = new System.Drawing.Point(246, 63);
            this.komboxDurum.Name = "komboxDurum";
            this.komboxDurum.Size = new System.Drawing.Size(248, 39);
            this.komboxDurum.TabIndex = 2;
            this.komboxDurum.SelectedIndexChanged += new System.EventHandler(this.komboxDurum_SelectedIndexChanged);
            // 
            // iptalNedenText
            // 
            this.iptalNedenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalNedenText.Location = new System.Drawing.Point(246, 149);
            this.iptalNedenText.Multiline = true;
            this.iptalNedenText.Name = "iptalNedenText";
            this.iptalNedenText.ReadOnly = true;
            this.iptalNedenText.Size = new System.Drawing.Size(391, 141);
            this.iptalNedenText.TabIndex = 3;
            // 
            // onaylaButon
            // 
            this.onaylaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaButon.Location = new System.Drawing.Point(25, 337);
            this.onaylaButon.Name = "onaylaButon";
            this.onaylaButon.Size = new System.Drawing.Size(215, 74);
            this.onaylaButon.TabIndex = 4;
            this.onaylaButon.Text = "ONAYLA";
            this.onaylaButon.UseVisualStyleBackColor = true;
            this.onaylaButon.Click += new System.EventHandler(this.onaylaButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButon.Location = new System.Drawing.Point(246, 337);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(215, 74);
            this.cikisButon.TabIndex = 5;
            this.cikisButon.Text = "ÇIKIŞ";
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(467, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "İMZA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDurumDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.onaylaButon);
            this.Controls.Add(this.iptalNedenText);
            this.Controls.Add(this.komboxDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDurumDegistir";
            this.Text = "FrmDurumDegistir";
            this.Load += new System.EventHandler(this.FrmDurumDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox komboxDurum;
        private System.Windows.Forms.TextBox iptalNedenText;
        private System.Windows.Forms.Button onaylaButon;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button button1;
    }
}
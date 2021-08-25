
namespace OVERTIME_PROJECT_01
{
    partial class FrmSignature
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
            this.onaylaButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.signPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.signPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // onaylaButton
            // 
            this.onaylaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaButton.Location = new System.Drawing.Point(279, 359);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(247, 81);
            this.onaylaButton.TabIndex = 1;
            this.onaylaButton.Text = "ONAYLA";
            this.onaylaButton.UseVisualStyleBackColor = true;
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalButton.Location = new System.Drawing.Point(541, 359);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(247, 81);
            this.iptalButton.TabIndex = 2;
            this.iptalButton.Text = "İPTAL";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // signPicBox
            // 
            this.signPicBox.BackColor = System.Drawing.SystemColors.Window;
            this.signPicBox.Location = new System.Drawing.Point(12, 12);
            this.signPicBox.Name = "signPicBox";
            this.signPicBox.Size = new System.Drawing.Size(776, 330);
            this.signPicBox.TabIndex = 3;
            this.signPicBox.TabStop = false;
            this.signPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.signPicBox_Paint);
            this.signPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signPicBox_MouseDown);
            this.signPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signPicBox_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "İmza Adı";
            // 
            // signText
            // 
            this.signText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signText.Location = new System.Drawing.Point(97, 387);
            this.signText.Name = "signText";
            this.signText.Size = new System.Drawing.Size(155, 30);
            this.signText.TabIndex = 5;
            // 
            // FrmSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.signText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signPicBox);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.onaylaButton);
            this.Name = "FrmSignature";
            this.Text = "FrmSignature";
            ((System.ComponentModel.ISupportInitialize)(this.signPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button onaylaButton;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.PictureBox signPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signText;
    }
}
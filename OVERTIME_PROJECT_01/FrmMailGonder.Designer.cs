
namespace OVERTIME_PROJECT_01
{
    partial class FrmMailGonder
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
            this.sendButton = new System.Windows.Forms.Button();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ccCheck = new System.Windows.Forms.CheckBox();
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendButton.Location = new System.Drawing.Point(49, 54);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(181, 125);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Gönder";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailText.Location = new System.Drawing.Point(271, 72);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(233, 30);
            this.emailText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // ccCheck
            // 
            this.ccCheck.AutoSize = true;
            this.ccCheck.Location = new System.Drawing.Point(271, 128);
            this.ccCheck.Name = "ccCheck";
            this.ccCheck.Size = new System.Drawing.Size(142, 21);
            this.ccCheck.TabIndex = 3;
            this.ccCheck.Text = "CC eklenecek mi?";
            this.ccCheck.UseVisualStyleBackColor = true;
            this.ccCheck.CheckedChanged += new System.EventHandler(this.ccCheck_CheckedChanged);
            // 
            // ccTextBox
            // 
            this.ccTextBox.Enabled = false;
            this.ccTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ccTextBox.Location = new System.Drawing.Point(271, 149);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(233, 30);
            this.ccTextBox.TabIndex = 4;
            // 
            // FrmMailGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 252);
            this.Controls.Add(this.ccTextBox);
            this.Controls.Add(this.ccCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.sendButton);
            this.Name = "FrmMailGonder";
            this.Text = "FrmMailGonder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ccCheck;
        private System.Windows.Forms.TextBox ccTextBox;
    }
}

namespace OVERTIME_PROJECT_01
{
    partial class FrmFastReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFastReport));
            this.gosterButon = new System.Windows.Forms.Button();
            this.report1 = new FastReport.Report();
            this.dataSet1 = new OVERTIME_PROJECT_01.DataSet1();
            this.dbOverShiftAllDatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOverShiftAllDatasTableAdapter = new OVERTIME_PROJECT_01.DataSet1TableAdapters.dbOverShiftAllDatasTableAdapter();
            this.rprKaydetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOverShiftAllDatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gosterButon
            // 
            this.gosterButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gosterButon.Location = new System.Drawing.Point(157, 143);
            this.gosterButon.Name = "gosterButon";
            this.gosterButon.Size = new System.Drawing.Size(264, 105);
            this.gosterButon.TabIndex = 0;
            this.gosterButon.Text = "Raporu Göster";
            this.gosterButon.UseVisualStyleBackColor = true;
            this.gosterButon.Click += new System.EventHandler(this.gosterButon_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            this.report1.RegisterData(this.dataSet1, "dataSet1");
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbOverShiftAllDatasBindingSource
            // 
            this.dbOverShiftAllDatasBindingSource.DataMember = "dbOverShiftAllDatas";
            this.dbOverShiftAllDatasBindingSource.DataSource = this.dataSet1;
            // 
            // dbOverShiftAllDatasTableAdapter
            // 
            this.dbOverShiftAllDatasTableAdapter.ClearBeforeFill = true;
            // 
            // rprKaydetButton
            // 
            this.rprKaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rprKaydetButton.Location = new System.Drawing.Point(450, 143);
            this.rprKaydetButton.Name = "rprKaydetButton";
            this.rprKaydetButton.Size = new System.Drawing.Size(264, 105);
            this.rprKaydetButton.TabIndex = 1;
            this.rprKaydetButton.Text = "Raporu Kaydet ve Mail Gönder";
            this.rprKaydetButton.UseVisualStyleBackColor = true;
            this.rprKaydetButton.Click += new System.EventHandler(this.rprKaydetButton_Click);
            // 
            // FrmFastReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.rprKaydetButton);
            this.Controls.Add(this.gosterButon);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbOverShiftAllDatasBindingSource, "Id", true));
            this.Name = "FrmFastReport";
            this.Text = "FrmFastReport";
            this.Load += new System.EventHandler(this.FrmFastReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOverShiftAllDatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gosterButon;
        private FastReport.Report report1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dbOverShiftAllDatasBindingSource;
        private DataSet1TableAdapters.dbOverShiftAllDatasTableAdapter dbOverShiftAllDatasTableAdapter;
        private System.Windows.Forms.Button rprKaydetButton;
    }
}
namespace Final_1__Library.Report
{
    partial class EmSaRecs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empDataset = new Final_1__Library.EmpDataset();
            this.empDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new Final_1__Library.EmpDatasetTableAdapters.EMPLOYEESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.eMPLOYEESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Final_1__Library.EmpReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(988, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // empDataset
            // 
            this.empDataset.DataSetName = "EmpDataset";
            this.empDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empDatasetBindingSource
            // 
            this.empDatasetBindingSource.DataSource = this.empDataset;
            this.empDatasetBindingSource.Position = 0;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.empDatasetBindingSource;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // EmSaRecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmSaRecs";
            this.Text = "EmSaRecs";
            this.Load += new System.EventHandler(this.EmSaRecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EmpDataset empDataset;
        private System.Windows.Forms.BindingSource empDatasetBindingSource;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private EmpDatasetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
    }
}
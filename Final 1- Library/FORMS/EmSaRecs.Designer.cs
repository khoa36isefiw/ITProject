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
            this.eMPLOYEESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNV = new Final_1__Library.QLNV();
            this.qLNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new Final_1__Library.QLNVTableAdapters.EMPLOYEESTableAdapter();
            this.eMPLOYEESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.eMPLOYEESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Final_1__Library.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(988, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // eMPLOYEESBindingSource2
            // 
            this.eMPLOYEESBindingSource2.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource2.DataSource = this.qLNVBindingSource;
            // 
            // eMPLOYEESBindingSource3
            // 
            this.eMPLOYEESBindingSource3.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource3.DataSource = this.qLNVBindingSource;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.qLNV;
            // 
            // qLNV
            // 
            this.qLNV.DataSetName = "QLNV";
            this.qLNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNVBindingSource
            // 
            this.qLNVBindingSource.DataSource = this.qLNV;
            this.qLNVBindingSource.Position = 0;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEESBindingSource1
            // 
            this.eMPLOYEESBindingSource1.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource1.DataSource = this.qLNV;
            // 
            // qLNVBindingSource1
            // 
            this.qLNVBindingSource1.DataSource = this.qLNV;
            this.qLNVBindingSource1.Position = 0;
            // 
            // eMPLOYEESBindingSource4
            // 
            this.eMPLOYEESBindingSource4.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource4.DataSource = this.qLNVBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLNVBindingSource;
        private QLNV qLNV;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private QLNVTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource1;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource2;
        private System.Windows.Forms.BindingSource qLNVBindingSource1;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource3;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource4;
    }
}
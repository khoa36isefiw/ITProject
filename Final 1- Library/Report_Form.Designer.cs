namespace Final_1__Library
{
    partial class Report_Form
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
            this.dS_Borrowed_Book = new Final_1__Library.DS_Borrowed_Book();
            this.dSBorrowedBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrow_BookTableAdapter = new Final_1__Library.DS_Borrowed_BookTableAdapters.Borrow_BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Borrowed_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBorrowedBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.borrowBookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Final_1__Library.BorrowedBook_report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Borrowed_Book
            // 
            this.dS_Borrowed_Book.DataSetName = "DS_Borrowed_Book";
            this.dS_Borrowed_Book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSBorrowedBookBindingSource
            // 
            this.dSBorrowedBookBindingSource.DataSource = this.dS_Borrowed_Book;
            this.dSBorrowedBookBindingSource.Position = 0;
            // 
            // borrowBookBindingSource
            // 
            this.borrowBookBindingSource.DataMember = "Borrow_Book";
            this.borrowBookBindingSource.DataSource = this.dSBorrowedBookBindingSource;
            // 
            // borrow_BookTableAdapter
            // 
            this.borrow_BookTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Form";
            this.Text = "Report_Form";
            this.Load += new System.EventHandler(this.Report_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Borrowed_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBorrowedBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSBorrowedBookBindingSource;
        private DS_Borrowed_Book dS_Borrowed_Book;
        private System.Windows.Forms.BindingSource borrowBookBindingSource;
        private DS_Borrowed_BookTableAdapters.Borrow_BookTableAdapter borrow_BookTableAdapter;
    }
}

namespace Final_Project
{
    partial class ReportPage
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
            this.CRUD_SS_DBDataSet = new Final_Project.CRUD_SS_DBDataSet();
            this.ProductInfo_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductInfo_TableTableAdapter = new Final_Project.CRUD_SS_DBDataSetTableAdapters.ProductInfo_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CRUD_SS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfo_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductInfo_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Final_Project.ReportDataViewer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.MinimumSize = new System.Drawing.Size(1280, 960);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1280, 960);
            this.reportViewer1.TabIndex = 0;
            // 
            // CRUD_SS_DBDataSet
            // 
            this.CRUD_SS_DBDataSet.DataSetName = "CRUD_SS_DBDataSet";
            this.CRUD_SS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductInfo_TableBindingSource
            // 
            this.ProductInfo_TableBindingSource.DataMember = "ProductInfo_Table";
            this.ProductInfo_TableBindingSource.DataSource = this.CRUD_SS_DBDataSet;
            // 
            // ProductInfo_TableTableAdapter
            // 
            this.ProductInfo_TableTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.reportViewer1);
            this.MinimumSize = new System.Drawing.Size(1280, 960);
            this.Name = "ReportPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPage";
            this.Load += new System.EventHandler(this.ReportPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CRUD_SS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfo_TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductInfo_TableBindingSource;
        private CRUD_SS_DBDataSet CRUD_SS_DBDataSet;
        private CRUD_SS_DBDataSetTableAdapters.ProductInfo_TableTableAdapter ProductInfo_TableTableAdapter;
    }
}
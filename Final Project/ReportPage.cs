using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CRUD_SS_DBDataSet.ProductInfo_Table' table. You can move, or remove it, as needed.
            this.ProductInfo_TableTableAdapter.Fill(this.CRUD_SS_DBDataSet.ProductInfo_Table);

            this.reportViewer1.RefreshReport();
        }
    }
}

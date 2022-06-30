using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CasualPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABIYANSYAH;Initial Catalog=CRUD_SS_DB;Persist Security Info=True;User ID=sa;Password=1234");
        public CasualPage()
        {
            InitializeComponent();
        }

        private void CasualPage_Load(object sender, EventArgs e)
        {
            LoadKategoriCasual();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Search All Data
            //SqlCommand com = new SqlCommand("exec dbo.SS_Product_Search_Casual '"+int.Parse(textBox1.Text)+ "' or '" + textBox2.TextLength.ToString() + "'", con);
            SqlCommand com = new SqlCommand("select * from ProductInfo_Table where Id_Sepatu=@Id_Sepatu or Nama_Barang=@Nama_Barang and Kategori='Casual'", con);
            com.Parameters.AddWithValue("Id_Sepatu", textBox1.Text);
            com.Parameters.AddWithValue("Nama_Barang", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void LoadKategoriCasual() 
        {
            SqlCommand cmd = new SqlCommand("exec dbo.SS_Product_View_Casual", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriesPage cp = new CategoriesPage();
            cp.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class DataPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABIYANSYAH;Initial Catalog=CRUD_SS_DB;Persist Security Info=True;User ID=sa;Password=1234");
        public DataPage()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //Insert - Save with Exeption
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "" && textBox8.Text != "")
            {
                con.Open();
                SqlCommand com2 = new SqlCommand("select Id_Sepatu from ProductInfo_Table where Id_Sepatu=@Id_Sepatu", con);
                com2.Parameters.AddWithValue("Id_Sepatu", textBox1.Text);
                SqlDataReader myreader = com2.ExecuteReader();
                if (myreader.Read())
                {
                    con.Close();
                    MessageBox.Show("Can't Save a Duplicated Product_Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Close();
                    SqlCommand com = new SqlCommand("exec dbo.SS_Product_Insert '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox8.Text + "'", con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllData();
                }
            }
            else
            {
                MessageBox.Show("Empty Text Field", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        void LoadAllData()
        {
            //View All Data
            SqlCommand com = new SqlCommand("exec dbo.SS_Product_AllData", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DataPage_Load(object sender, EventArgs e)
        {
            //Load Form
            LoadAllData();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            //Update with Exeption
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "" && textBox8.Text != "")
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.SS_Product_Update '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox8.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Empty Text Field", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //Delete with Exeption
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "" && textBox8.Text != "")
            {
                if (MessageBox.Show("Are You Sure to Delete the Data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("exec dbo.SS_Product_Delete '" + int.Parse(textBox1.Text) + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllData();
                }
            }
            else
            {
                MessageBox.Show("Empty Text Field", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            //Log Out
            CategoriesPage cp = new CategoriesPage();
            cp.Show();
            Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //Search All Data
            //SqlCommand com = new SqlCommand("exec dbo.SS_Product_SearchAll '"+int.Parse(textBox1.Text)+ "' or '" + textBox2.TextLength.ToString() + "'", con);
            SqlCommand com = new SqlCommand("select * from ProductInfo_Table where Id_Sepatu=@Id_Sepatu or Nama_Barang=@Nama_Barang", con);
            com.Parameters.AddWithValue("Id_Sepatu", textBox1.Text);
            com.Parameters.AddWithValue("Nama_Barang", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Print_button_Click(object sender, EventArgs e)
        {
            ReportPage rp = new ReportPage();
            rp.Show();
            Close();
        }

        //Empty Field Pop Up Function
        //void EmptyFieldBox()
        //{
        //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "" && textBox8.Text != "")
        //{

        //}
        //else
        //{
        //MessageBox.Show("Empty Text Field", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}
        //}

    }
}

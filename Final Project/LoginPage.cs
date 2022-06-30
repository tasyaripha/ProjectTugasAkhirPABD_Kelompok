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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            CategoriesPage cp = new CategoriesPage();
            cp.Show();
            Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection con = new SqlConnection("Data Source=ABIYANSYAH;Initial Catalog=CRUD_SS_DB;Persist Security Info=True;User ID=sa;Password=1234"))
                {
                    string query = "select * from LoginInfo where Username = '"+textBox1.Text.Trim()+"' and Password = '"+textBox2.Text.Trim()+"'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Successfully Logged In!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataPage dp = new DataPage();
                        dp.Show();
                        Hide();
                    }
                }
            }
        }

        private bool isValid() 
        {
            if(textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid username please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                login_button.PerformClick();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                login_button.PerformClick();
        }
    }
}

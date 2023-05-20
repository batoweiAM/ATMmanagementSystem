using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMManagementSystem
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if(AccNametb.Text =="" || AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || PinTb.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into AccountTbl values('"+AccNumTb.Text+"','"+AccNametb.Text+"','"+FanameTb.Text+"','"+dobdate.Value.Date+"','"+PhoneTb.Text+"','"+Addresstb.Text+"','"+educationtb.SelectedItem.ToString()+"','"+occupationtb.Text+"'," + PinTb.Text+ "," +bal+")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }catch(Exception Ex) 
                {
                   MessageBox.Show(Ex.Message); 
                }
            }
        }

        private void educationtb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

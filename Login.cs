﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
        public static string AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accnum='"+AccNumTb.Text+"' and PIN = "+PinTb.Text+"", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();

            if (dt.Rows[0][0].ToString() == "1")
            {
                Con.Open();
                AccNumber = AccNumTb.Text;
                HOME home = new HOME();
                home.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number Or PIN Code");
            }
            Con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

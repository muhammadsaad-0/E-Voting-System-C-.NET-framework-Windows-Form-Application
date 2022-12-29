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

namespace SemesterProject
{
    public partial class AdminLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public AdminLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Enter Username !!");
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter Password !!");
            }
            else if (textBoxUsername.Text == "ADMIN" && textBoxPassword.Text == "12345")
            {
                this.Hide();
                Form frm2 = new admin();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credential");
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
                textBoxPassword.PasswordChar = '*';
        }

        private void back(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(); 
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void exitbtn(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }
    }
    
}

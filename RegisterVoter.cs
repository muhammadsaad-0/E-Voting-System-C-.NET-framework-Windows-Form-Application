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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace SemesterProject
{
    public partial class RegisterVoter : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public RegisterVoter()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void LoginL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VoterLogin lf = new VoterLogin();
            lf.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (FullnameT.Text.Length > 0 && RegidlT.Text.Length > 0 && RegPasswordT.Text.Length > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO Voter(FullNames,Regid,password,status) VALUES('"+FullnameT.Text+"','"+RegidlT.Text+ "','"+RegPasswordT.Text+"','false')", con);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Registered, you will be redirected to Login page.");

                        VoterLogin lf = new VoterLogin();
                        lf.Show();
                        this.Hide();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Failed to Register.");
                    }
                    
                    con.Close();    

                }
                catch(Exception)
                {
                    MessageBox.Show("Contact with Admin");
                }
            }

            else
                MessageBox.Show("Fullname and Reg id Are required!!!");

        }

        private void adminback_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

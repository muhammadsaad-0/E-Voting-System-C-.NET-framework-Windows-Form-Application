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

namespace SemesterProject
{
    public partial class StartStopVoting : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");

        public StartStopVoting()
        {
            InitializeComponent();
            CenterToScreen();
        }

        bool voting()
        {
            String pass = startvotingpass.Text;
            if(pass.ToLower() =="admin" )
            {
                return true;
            }else
                return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            if (voting())
            {
                SqlCommand com = new SqlCommand("update votingstart set voting='true'", con);


                com.ExecuteNonQuery();
                MessageBox.Show("Voting Started Successfully");
            }else
                MessageBox.Show("Enter Valid Password");
            con.Close();
            startvotingpass.Text = "";
            startvotingpass.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();

            if (voting())
            {
                SqlCommand com = new SqlCommand("update votingstart set voting='false'", con);


                com.ExecuteNonQuery();
                MessageBox.Show("Voting Stopped Successfully");
            }
            else
                MessageBox.Show("Enter Valid Password");
            con.Close();
            startvotingpass.Text = "";
            startvotingpass.Focus();
        }

        private void adminback_Click(object sender, EventArgs e)
        {
            admin form = new admin();
            form.Show();
            this.Hide();
        }

   

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            admin form = new admin();
            form.Show();
            this.Hide();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            admin form = new admin();
            form.Show();
            this.Hide();
        }
    }
}

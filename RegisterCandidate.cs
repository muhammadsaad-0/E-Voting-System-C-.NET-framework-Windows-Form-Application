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
    public partial class RegisterCandidate : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public RegisterCandidate()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CandidateNameT.Text.Length > 0 && CandidateIdT.Text.Length > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO candidatee VALUES('" + CandidateIdT.Text + "','" + CandidateNameT.Text + "','0')", con);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Candidate registered Successfully");
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to Register.");
                    }
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("!!!");
                }
            }

            else
                MessageBox.Show("Candidate's Name and Reg id are required!!!");

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

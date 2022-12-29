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

namespace SemesterProject
{
    public partial class VoterLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public VoterLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RegisterL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterVoter rf = new RegisterVoter();
            rf.Show();
            this.Hide();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {

            con.Open();
            string name, regid, pass;
            name = FullnameT.Text;
            regid = RegidT.Text;
            pass = passwordvlogin.Text;

            string logQuery1= "select * from votingstart";

            SqlCommand logCmd1 = new SqlCommand(logQuery1, con);
           

            SqlDataAdapter LogAdpater1 = new SqlDataAdapter(logCmd1);
            DataSet LogSet1 = new DataSet();
            LogAdpater1.Fill(LogSet1);

            String check = Convert.ToString(LogSet1.Tables[0].Rows[0].ItemArray[0]);
            if (check == "true")
            {
                if (FullnameT.Text.Length > 0 && RegidT.Text.Length > 0 && passwordvlogin.Text.Length > 0)
                {
                    string logQuery = "select * from Voter where FullNames = @fullname and Regid = @id and password = @pass";

                    SqlCommand logCmd = new SqlCommand(logQuery, con);
                    logCmd.Parameters.AddWithValue("@fullname", name);
                    logCmd.Parameters.AddWithValue("@id", regid);
                    logCmd.Parameters.AddWithValue("@pass", pass);

                    SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
                    DataSet LogSet = new DataSet();
                    LogAdpater.Fill(LogSet);

                    if ((LogSet.Tables[0].Rows.Count) > 0)
                    {
                        new vote(regid).Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Invalid Details");
                    }
                }

                else
                    MessageBox.Show("Fullname and Reg id Are required!!!");

            }
            else
            {
                MessageBox.Show("Voting is not started Yet!");
            }



           

            con.Close();
        



            
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

        private void DeclareResultBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

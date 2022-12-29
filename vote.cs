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
    public partial class vote : Form
    {
        String vid;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public vote(String id)
        {
            vid=id;
            InitializeComponent();
            CenterToScreen();
        }

        private void vote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voting_SaadDataSet.candidatee' table. You can move, or remove it, as needed.
            this.candidateeTableAdapter.Fill(this.voting_SaadDataSet.candidatee);

        }

        private void VoteB_Click(object sender, EventArgs e)
        {
            String selectedcan = CandidateCB.Text;

            con.Open();

            string logQuery = "select * from candidatee where CandidateName = @id";

            SqlCommand logCmd = new SqlCommand(logQuery, con);
            logCmd.Parameters.AddWithValue("@id", selectedcan);

            SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
            DataSet LogSet = new DataSet();
            LogAdpater.Fill(LogSet);

            String check = Convert.ToString(LogSet.Tables[0].Rows[0].ItemArray[1]);
            int Tvotes = Convert.ToInt32(LogSet.Tables[0].Rows[0].ItemArray[2]);

            if (selectedcan == check)
            {

                string logQuery1 = "select * from Voter where Regid ='" + vid + "' ";

                SqlCommand logCmd1 = new SqlCommand(logQuery1, con);
                

                SqlDataAdapter LogAdpater1 = new SqlDataAdapter(logCmd1);
                DataSet LogSet1 = new DataSet();
                LogAdpater1.Fill(LogSet1);

                String voterstatus = Convert.ToString(LogSet1.Tables[0].Rows[0].ItemArray[4]);
                String voterregid = Convert.ToString(LogSet1.Tables[0].Rows[0].ItemArray[2]);

                if(voterstatus == "false")
                {
                    Tvotes++;
                    SqlCommand com = new SqlCommand("update candidatee set Votes='" + Tvotes + "' where CandidateName = '" + check + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Vote Casted Successfully");
                    SqlCommand com1 = new SqlCommand("update Voter set status= 'true'  where Regid='"+voterregid+"'", con);
                    com1.ExecuteNonQuery();
                }else
                    MessageBox.Show("You Already Casted a Vote");

            }



            con.Close();

        }

        private void adminback_Click(object sender, EventArgs e)
        {
            VoterLogin form = new VoterLogin();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VoterLogin form = new VoterLogin();
            form.Show();
            this.Hide();
        }

    

        private void LogoutB_Click(object sender, EventArgs e)
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

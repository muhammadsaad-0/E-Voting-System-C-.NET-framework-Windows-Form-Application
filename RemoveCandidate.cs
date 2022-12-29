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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SemesterProject
{
    public partial class RemoveCandidate : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public RemoveCandidate()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string empty=CandidateIdT.Text;
            if (empty != "")
            {
                


                int id = int.Parse(CandidateIdT.Text);

                string logQuery = "select * from candidatee where CandidateRegId = @id";

                SqlCommand logCmd = new SqlCommand(logQuery, con);
                logCmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
                DataSet LogSet = new DataSet();
                LogAdpater.Fill(LogSet);

                if ((LogSet.Tables[0].Rows.Count) > 0)
                {
                    int check = Convert.ToInt32(LogSet.Tables[0].Rows[0].ItemArray[0]);
                    if (check == id)
                    {
                        SqlCommand com = new SqlCommand("delete candidatee where CandidateRegId='" + CandidateIdT.Text + "'", con);
                       
                        com.ExecuteNonQuery();
                        
                        MessageBox.Show("Candidate removed Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Candidate not found...!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter valid Candidate RegNo");
                }
            }else
                MessageBox.Show("Regno is Required");

                con.Close();
        
           

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

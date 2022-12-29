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
using System.Xml.Linq;

namespace SemesterProject
{
    public partial class DeclareVoting : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");

        public DeclareVoting()
        {
            InitializeComponent();
            gridfill();
            CenterToScreen();
        }
        void gridfill()
        {
            string query = "SELECT * FROM candidatee ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            con.Close();

            dataGridView1.DataSource = data;
        }
        private void DeclareResultBtn_Click(object sender, EventArgs e)
        {
            string logQuery1 = "select * from votingstart";
            con.Open();
            SqlCommand logCmd1 = new SqlCommand(logQuery1, con);


            SqlDataAdapter LogAdpater1 = new SqlDataAdapter(logCmd1);
            DataSet LogSet1 = new DataSet();
            LogAdpater1.Fill(LogSet1);

            String check = Convert.ToString(LogSet1.Tables[0].Rows[0].ItemArray[0]);
            if (check == "false")
            {
                string logQuery = "select * from candidatee ";

                SqlCommand logCmd = new SqlCommand(logQuery, con);
                SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
                DataSet LogSet = new DataSet();
                LogAdpater.Fill(LogSet);
                int tvotes = 0;
                int loop = LogSet.Tables[0].Columns.Count;
                string cname="";
               
                for(int i = 0; i <loop; i++)
                {
                    int votes = Convert.ToInt32(LogSet.Tables[0].Rows[i].ItemArray[2]);
                     
                    if (tvotes < votes)
                    {
                        tvotes = votes;
                        cname = Convert.ToString(LogSet.Tables[0].Rows[i].ItemArray[1]);
                    }
                }
                Console.WriteLine(tvotes + " "+ cname);
             
                Winner.Text = cname;
                TVotes.Text=tvotes.ToString();

            }
            else
            {
                MessageBox.Show("Please Stop the voting process!");
            }





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

        private void reset_Click(object sender, EventArgs e)
        {
            string logQuery1 = "UPDATE Voter SET status='false'";
            string logQuery2 = "UPDATE candidatee SET Votes='"+0+"'";
            con.Open();
            SqlCommand logCmd1 = new SqlCommand(logQuery1, con);

            logCmd1.ExecuteNonQuery(); 
            SqlCommand logCmd2 = new SqlCommand(logQuery2, con);

            logCmd2.ExecuteNonQuery();
           
        }
    }
}

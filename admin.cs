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
    
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public admin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form2 = new RegisterCandidate();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form2 = new RemoveCandidate();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form2 = new DeclareVoting();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var form2 = new StartStopVoting();
                form2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new StartStopVoting();
            form2.Show();
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

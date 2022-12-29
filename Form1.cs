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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NQ5QMQS\\SQLEXPRESS;Initial Catalog=Voting_Saad;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new RegisterVoter();
            form2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new AdminLogin();
            form2.Show();
            this.Hide();
        }

        private void admin(object sender, EventArgs e)
        {
            var form2 = new AdminLogin();
            form2.Show();
            this.Hide();
        }

        private void voter(object sender, EventArgs e)
        {
            var form2 = new RegisterVoter();
            form2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           // Application.Exit();
        }

        private void panel4_Paint(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

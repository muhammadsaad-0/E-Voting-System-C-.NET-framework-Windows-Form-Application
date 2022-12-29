namespace SemesterProject
{
    partial class vote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vote));
            this.VoteB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoutB = new System.Windows.Forms.Button();
            this.CandidateCB = new System.Windows.Forms.ComboBox();
            this.candidateeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voting_SaadDataSet = new SemesterProject.Voting_SaadDataSet();
            this.candidateeTableAdapter = new SemesterProject.Voting_SaadDataSetTableAdapters.candidateeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminback = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidateeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_SaadDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VoteB
            // 
            this.VoteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoteB.Location = new System.Drawing.Point(433, 300);
            this.VoteB.Name = "VoteB";
            this.VoteB.Size = new System.Drawing.Size(75, 32);
            this.VoteB.TabIndex = 21;
            this.VoteB.Text = "Vote";
            this.VoteB.UseVisualStyleBackColor = true;
            this.VoteB.Click += new System.EventHandler(this.VoteB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(197, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Candidate";
            // 
            // LogoutB
            // 
            this.LogoutB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutB.Location = new System.Drawing.Point(262, 300);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(75, 32);
            this.LogoutB.TabIndex = 24;
            this.LogoutB.Text = "Logout";
            this.LogoutB.UseVisualStyleBackColor = true;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // CandidateCB
            // 
            this.CandidateCB.DataSource = this.candidateeBindingSource;
            this.CandidateCB.DisplayMember = "CandidateName";
            this.CandidateCB.FormattingEnabled = true;
            this.CandidateCB.Location = new System.Drawing.Point(433, 187);
            this.CandidateCB.Name = "CandidateCB";
            this.CandidateCB.Size = new System.Drawing.Size(121, 21);
            this.CandidateCB.TabIndex = 25;
            // 
            // candidateeBindingSource
            // 
            this.candidateeBindingSource.DataMember = "candidatee";
            this.candidateeBindingSource.DataSource = this.voting_SaadDataSet;
            // 
            // voting_SaadDataSet
            // 
            this.voting_SaadDataSet.DataSetName = "Voting_SaadDataSet";
            this.voting_SaadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateeTableAdapter
            // 
            this.candidateeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(732, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 63);
            this.panel3.TabIndex = 22;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.adminback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 63);
            this.panel2.TabIndex = 21;
            // 
            // adminback
            // 
            this.adminback.BackColor = System.Drawing.Color.Transparent;
            this.adminback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminback.Image = ((System.Drawing.Image)(resources.GetObject("adminback.Image")));
            this.adminback.Location = new System.Drawing.Point(0, 0);
            this.adminback.Name = "adminback";
            this.adminback.Size = new System.Drawing.Size(75, 63);
            this.adminback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminback.TabIndex = 21;
            this.adminback.TabStop = false;
            this.adminback.Click += new System.EventHandler(this.adminback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SemesterProject.Properties.Resources.logo_no_background;
            this.pictureBox1.Location = new System.Drawing.Point(81, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(209, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "University E-Voting System";
            // 
            // vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CandidateCB);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.VoteB);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vote";
            this.Load += new System.EventHandler(this.vote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_SaadDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VoteB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogoutB;
        private System.Windows.Forms.ComboBox CandidateCB;
        private Voting_SaadDataSet voting_SaadDataSet;
        private System.Windows.Forms.BindingSource candidateeBindingSource;
        private Voting_SaadDataSetTableAdapters.candidateeTableAdapter candidateeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox adminback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackermeDB;

namespace CollegeManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StudentsAcctions uc = new StudentsAcctions();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            CoursesActions uc = new CoursesActions();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            DataList uc = new DataList();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void payementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Payment uc = new Payment();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}

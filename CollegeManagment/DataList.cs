using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackermeDB;

namespace CollegeManagment
{
    public partial class DataList : UserControl
    {
        public DataList()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.StudentsList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StudentsAcctions uc = new StudentsAcctions();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            CoursesActions uc = new CoursesActions();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

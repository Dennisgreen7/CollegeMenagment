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
    public partial class CoursesActions : UserControl
    {
        public CoursesActions()
        {
            InitializeComponent();
        }

        private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CourseBox.Text == "" || DateBox.Value.ToShortDateString() == "" || NOLBox.Text == "")
            {
                MessageBox.Show("Eror, Please fill in all fields");
                CourseBox.Focus(); // set focus to lastNameTextBox  
                return;
            }
            MyDB.CoursesList.Add(new Course(CourseBox.Text, DateBox.Value, int.Parse(NOLBox.Text)));
            MessageBox.Show("Course Added"); 
        }

        private void DateBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StudentsAcctions uc = new StudentsAcctions();
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

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            CoursesActions uc = new CoursesActions();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MyDB.CoursesList.Count; i++)
            {
                if (MyDB.CoursesList[i].CourseName == FNSearch.Text)
                {
                    MyDB.CoursesList.Remove(MyDB.CoursesList[i]);
                    i = MyDB.CoursesList.Count;
                }
            }
            MessageBox.Show("Courses Deleted");
        }
    }
}

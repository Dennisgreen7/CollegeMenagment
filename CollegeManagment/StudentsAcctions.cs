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
using System.Text.RegularExpressions;


namespace CollegeManagment
{
    public partial class StudentsAcctions : UserControl
    {
        public StudentsAcctions()
        {
            InitializeComponent();
            Save.Enabled = false;
            Delete.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Save.Enabled = true;
            Delete.Enabled = true;
            for (int i = 0; i < MyDB.StudentsList.Count; i++)
            {
                if (MyDB.StudentsList[i].FirstName == FNSearch.Text)
                {
                    IdBox.Text = MyDB.StudentsList[i].Id;
                    FirstNameBox.Text = MyDB.StudentsList[i].FirstName;
                    LastNameBox.Text = MyDB.StudentsList[i].LastName;
                    PhoneBox.Text = MyDB.StudentsList[i].PhoneNumber;
                    EmailBox.Text = MyDB.StudentsList[i].Email;
                    CityBox.SelectedText = MyDB.StudentsList[i].City;
                    DOBBox.Value = Convert.ToDateTime(MyDB.StudentsList[i].DateOfBirth);
                    for (int k = 0; k < MyDB.StudentsList[i].CoursesList.Count; k++)
                    {
                        if (checkBox1.Text == MyDB.StudentsList[i].CoursesList[k])
                        {
                            checkBox1.Checked = true;
                        }
                        if (checkBox2.Text == MyDB.StudentsList[i].CoursesList[k])
                        {
                            checkBox2.Checked = true;
                        }
                        if (checkBox3.Text == MyDB.StudentsList[i].CoursesList[k])
                        {
                            checkBox3.Checked = true;
                        }
                        if (checkBox4.Text == MyDB.StudentsList[i].CoursesList[k])
                        {
                            checkBox4.Checked = true;
                        }
                        if (checkBox5.Text == MyDB.StudentsList[i].CoursesList[k])
                        {
                            checkBox5.Checked = true;
                        }
                    }
                }
            }

        }



        private void Add_Click(object sender, EventArgs e)
        {
            if (IdBox.Text != "")
            {
                if (IdBox.Text.Length != 9)
                {
                    MessageBox.Show("Id should be 9 Digits");
                    IdBox.Focus();
                    return;
                }

                int res = 0;
                for (int i = 1; i < 8; i += 2)
                {
                    res += int.Parse(IdBox.Text[i - 1].ToString()) + ((int.Parse(IdBox.Text[i].ToString()) * 2) / 10) + ((int.Parse(IdBox.Text[i].ToString()) * 2) % 10);
                }
                int a = (res + int.Parse(IdBox.Text[8].ToString())) % 10;
                if ((res + int.Parse(IdBox.Text[8].ToString())) % 10 != 0)
                {
                    MessageBox.Show("Wrong Id");
                    IdBox.Focus();
                    return;
                }
            }

            //Empty Fields Check
            if (IdBox.Text == "" || FirstNameBox.Text == "" || LastNameBox.Text == "" || PhoneBox.Text == "" || CityBox.Text == "" || DOBBox.Value.ToShortDateString() == "" || EmailBox.Text == "")
            {
                MessageBox.Show("Eror, Please fill in all fields");
                IdBox.Focus(); // set focus to lastNameTextBox  
                return;
            }
            if (!Regex.Match(FirstNameBox.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid first name");
                FirstNameBox.Focus();
                return;
            }
            if (!Regex.Match(LastNameBox.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid last name");
                LastNameBox.Focus();
                return;
            }
            if (!Regex.Match(PhoneBox.Text, @"^\+?(972|0)(\-)?0?(([23489]{1}\d{7})|[5]{1}\d{8})$").Success)
            {
                MessageBox.Show("Invalid phone number");
                PhoneBox.Focus();
                return;
            }
            if (!Regex.Match(EmailBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                MessageBox.Show("Invalid Email Address");
                PhoneBox.Focus();
                return;
            }
            List<string> courselist = new List<string>();
            if (checkBox1.Checked)
            {
                courselist.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                courselist.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                courselist.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                courselist.Add(checkBox4.Text);
            }
            if (checkBox5.Checked)
            {
                courselist.Add(checkBox5.Text);
            }
            MyDB.StudentsList.Add(new Student(IdBox.Text, FirstNameBox.Text, LastNameBox.Text, PhoneBox.Text, DOBBox.Value.ToShortDateString(), CityBox.Text, EmailBox.Text, courselist));
            MessageBox.Show("Student Added");
            IdBox.Text = ""; FirstNameBox.Text = ""; LastNameBox.Text = ""; PhoneBox.Text = ""; EmailBox.Text = ""; CityBox.SelectedItem = null; DOBBox.ResetText(); checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox5.Checked = false;
        }

        private void StudentsAcct_Load(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> courselist = new List<string>();
            if (checkBox1.Checked)
            {
                courselist.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                courselist.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                courselist.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                courselist.Add(checkBox4.Text);
            }
            if (checkBox5.Checked)
            {
                courselist.Add(checkBox5.Text);
            }
            for (int i = 0; i < MyDB.StudentsList.Count; i++)
            {
                if (MyDB.StudentsList[i].FirstName == FNSearch.Text)
                {
                    MyDB.StudentsList[i].Id = IdBox.Text;
                    MyDB.StudentsList[i].FirstName = FirstNameBox.Text;
                    MyDB.StudentsList[i].LastName = LastNameBox.Text;
                    MyDB.StudentsList[i].PhoneNumber = PhoneBox.Text;
                    MyDB.StudentsList[i].Email = EmailBox.Text;
                    MyDB.StudentsList[i].City = CityBox.Text;
                    MyDB.StudentsList[i].DateOfBirth = DOBBox.Value.ToShortDateString();
                    MyDB.StudentsList[i].CoursesList = courselist;
                    i = MyDB.StudentsList.Count;
                }
            }
            MessageBox.Show("Student Saved");
            Add.Enabled = true;
            IdBox.Text = ""; FirstNameBox.Text = ""; LastNameBox.Text = ""; PhoneBox.Text = ""; EmailBox.Text = ""; CityBox.SelectedItem = null; DOBBox.ResetText();
            checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MyDB.StudentsList.Count; i++)
            {
                if (MyDB.StudentsList[i].FirstName == FNSearch.Text)
                {
                    MyDB.StudentsList.Remove(MyDB.StudentsList[i]);
                    i = MyDB.StudentsList.Count;
                }
            }
            MessageBox.Show("Student Deleted");
            IdBox.Text = ""; FirstNameBox.Text = ""; LastNameBox.Text = ""; PhoneBox.Text = ""; EmailBox.Text = ""; CityBox.SelectedIndex = -1; DOBBox.ResetText();
        }

        private void CityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Payment uc = new Payment();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FNSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

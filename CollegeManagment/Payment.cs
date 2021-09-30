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
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
            PaymentUpdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Payment = 20000;
            int NeedToPay = 0;
            for (int i = 0; i < MyDB.StudentsList.Count; i++)
            {
                if (MyDB.StudentsList[i].Id == FNSearch.Text)
                {
                    NeedToPay = Payment - int.Parse(MyDB.StudentsList[i].Paid);
                    StFName.Text = MyDB.StudentsList[i].FirstName + " " + MyDB.StudentsList[i].LastName;
                    PaidBox.Text = MyDB.StudentsList[i].Paid;
                    PayBox.Text = Convert.ToString(NeedToPay);
                }
            }
            PaymentUpdate.Enabled = true;
        }

        private void PayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PaymentUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MyDB.StudentsList.Count; i++)
            {
                if (MyDB.StudentsList[i].Id == FNSearch.Text)
                {
                    MyDB.StudentsList[i].Paid = ToPay.Text;
                }
            }
            MessageBox.Show("Updated");
            StFName.Text = "";
            PaidBox.Text =" ";
            PayBox.Text = " ";
            ToPay.Text = " ";
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

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

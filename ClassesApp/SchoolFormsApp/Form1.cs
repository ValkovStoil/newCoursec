using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingWithClasses;

namespace SchoolFormsApp
{
    public partial class text : Form
    {
        public text()
        {
            InitializeComponent();
        }

        private void BtnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = txtName.Text;
            testSchool.Addres = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.State = txtState.Text;
            testSchool.Zip = txtZip.Text;
            try
            {
                testSchool.TwitterAddress = txtTwitter.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());

            var studen = new Student(); // for test only - remove later
        }

        private void Text_Load(object sender, EventArgs e)
        {

        }

        private void BtnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show($"the teachers's  grede average is {gp}");
        }

        private void BtnTestingStudents_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.ComputeGradeAverage();
            MessageBox.Show($"the student's grade average is {gp}");
        }
    }
}

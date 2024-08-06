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

namespace StudentManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void GetRoll(string _roll)
        {
            lblWelcom.Text = "Wellcome to Student Managerment System "+_roll;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnStuList_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.ShowDialog();
            student.Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClassList_Click(object sender, EventArgs e)
        {
            Enroll enroll = new Enroll();
            this.Hide();
            enroll.ShowDialog();
            enroll.Close();
            this.Show();
        }

        private void btnClassList_Click_1(object sender, EventArgs e)
        {
            Class classs = new Class();
            this.Hide();
            classs.ShowDialog();
            classs.Close();
            this.Show();
        }

        private void btnCourseList_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            this.Hide();
            course.ShowDialog();
            course.Close();
            this.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }

        private void btnDepartmentView_Click_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            this.Hide();
            department.ShowDialog();
            department.Close();
            this.Show();
        }
    }
}

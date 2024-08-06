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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        DataSet GetCourse(string search = "")
        {
            DataSet data = new DataSet();
            int id = 0;
            string query = "SELECT * FROM Courses";

            if (!string.IsNullOrEmpty(search) && int.TryParse(search, out id))
            {
                query += " Where course_id = @CourseID OR department_id = @DepartmentID";
            }
            else if (!string.IsNullOrEmpty(search) && !int.TryParse(search, out _))
            {
                query += " WHERE course_name LIKE @CourseName+'%'";
            }
            //sqlConnection
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CourseID", id);
                cmd.Parameters.AddWithValue("@DepartmentID", id);
                cmd.Parameters.AddWithValue("@CourseName", txtSearch.Text.Trim());
                //sqlDataAdepter
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(data);
                connection.Close();
            }
            return data;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            datagrvCourse.DataSource = GetCourse(search).Tables[0];
            datagrvCourse.Refresh();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            //Fill bảng vừa form
            datagrvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagrvCourse.DataSource = GetCourse().Tables[0];
        }

        void refresh()
        {
            datagrvCourse.DataSource = GetCourse().Tables[0];
            datagrvCourse.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepartmentView_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    string addQry = "insert into Courses values (@CourseID,@CourseName,@DepartmentID)";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
                    cmd.Parameters.AddWithValue("@DepartmentID", int.Parse(txtDepartmentID.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi trùng ID
                {
                    MessageBox.Show("ID cannot be duplicated!");
                }
                else if (ex.Number == 547) // Lỗi khóa ngoại không tồn tại
                {
                    MessageBox.Show("ID not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    string addQry = "UPDATE Courses \n SET course_id = @CourseID, course_name = @CourseName" +
                        ", department_id = @DepartmentID WHERE course_id = @CourseID";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
                    cmd.Parameters.AddWithValue("@DepartmentID", int.Parse(txtDepartmentID.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection connection  = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    string delQry = "DELETE FROM Courses WHERE course_id = @CourseID";
                    SqlCommand cmd = new SqlCommand(delQry, connection);
                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void datagrvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowData = datagrvCourse.Rows[e.RowIndex];
                txtCourseID.Text = rowData.Cells["course_id"].Value.ToString();
                txtCourseName.Text = rowData.Cells["course_name"].Value.ToString();
                txtDepartmentID.Text = rowData.Cells["department_id"].Value.ToString();
                btnEditCourse.Enabled = true;
                btnDeleteCourse.Enabled = true;
            }
        }

        private void txtCourseID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            datagrvClass.DataSource = GetClass().Tables[0];
            datagrvClass.Refresh();
        }

        DataSet GetClass(string search = "")
        {
            DataSet data = new DataSet();
            int id = 0;
            string query = "SELECT * FROM Classes";

            if (!string.IsNullOrEmpty(search) && int.TryParse(search, out id))
            {
                query += " Where class_id = @ClassID OR course_id = @CourseID";
            }
            else if (!string.IsNullOrEmpty(search) && !int.TryParse(search, out _))
            {
                query += " WHERE class_name LIKE @ClassName+'%'";
            }
            //sqlConnection
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ClassID", id);
                cmd.Parameters.AddWithValue("@CourseID", id);
                cmd.Parameters.AddWithValue("@ClassName", txtSearch.Text.Trim());
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
            datagrvClass.DataSource = GetClass(search).Tables[0];
            datagrvClass.Refresh();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            //Fill bảng vừa form
            datagrvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagrvClass.DataSource = GetClass().Tables[0];

            btnDeleteClass.Enabled = false;
            btnEditClass.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCourseView_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.StartPosition = FormStartPosition.Manual;
            course.Show();
        }

        private void datagrvEnroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowData = datagrvClass.Rows[e.RowIndex];
                txtClassID.Text = rowData.Cells["class_id"].Value.ToString();
                txtCourseID.Text = rowData.Cells["course_id"].Value.ToString();
                btnEditClass.Enabled = true;
                btnDeleteClass.Enabled = true;
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    string addQry = "insert into Classes values (@ClassID,@CourseID,@ClassName)";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@ClassID", int.Parse(txtClassID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text.Trim());
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

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    string addQry = "UPDATE Classes \n SET class_id = @ClassID, course_id = @CourseID, class_name = @ClassName WHERE class_id = @ClassID";
                    SqlCommand cmd = new SqlCommand(addQry, connection);
                    cmd.Parameters.AddWithValue("@ClassID", int.Parse(txtClassID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text.Trim());
                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    string delQry = "DELETE FROM Classes WHERE class_id = @ClassID";
                    SqlCommand cmd = new SqlCommand(delQry, connection);
                    cmd.Parameters.AddWithValue("@ClassID", int.Parse(txtClassID.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}

        }

        private void datagrvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowData = datagrvClass.Rows[e.RowIndex];
                txtClassID.Text = rowData.Cells["class_id"].Value.ToString();
                txtCourseID.Text = rowData.Cells["course_id"].Value.ToString();
                txtClassName.Text = rowData.Cells["class_name"].Value.ToString();
                btnEditClass.Enabled = true;
                btnDeleteClass.Enabled = true;
            }
        }

        private void txtClassID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

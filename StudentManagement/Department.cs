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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            datagrvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagrvDepartment.DataSource = GetDepartment().Tables[0];
        }

        DataSet GetDepartment()
        {
            DataSet data = new DataSet();

            //sqlConnection
            string query = "select * from Departments";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);

                //sqlDataAdepter
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        void refresh()
        {
            datagrvDepartment.DataSource = GetDepartment().Tables[0];
            datagrvDepartment.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace logistic
{
    public partial class MainWindow : Form
    {
        public SqlConnection connection;
        public string connectionString;

        public string SendConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        public SqlConnection SendConnection
        {
            get
            {
                return connection;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewDeclaration NewDeclaration = new NewDeclaration();
            NewDeclaration.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();

        }

        private void ShowDeclarations_Click(object sender, EventArgs e)
        {
            Form ShowDeclarations = new ShowDeclarations();
            ShowDeclarations.Show();
        }

        //private void Some()
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT 1", connection))
        //    {


        //        //var query = "select 1";
        //        //var command = new SqlCommand(query, connection);

        //        DataTable test = new DataTable();
        //        adapter.Fill(test);
        //        //string result = (string)command.ExecuteReader();
        //        //SqlDataReader reader = command.ExecuteReader();

        //        //while (reader.Read())
        //        //{

        //            //MessageBox.Show("executing: {0}", reader.GetString(0));
        //        //}


        //    }
        //}
    }
}

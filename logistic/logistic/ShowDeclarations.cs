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
using System.Threading;
using System.Diagnostics;

namespace logistic
{
    public partial class ShowDeclarations : Form
    {
        private SqlConnection connection;
        private string connectionString;

        public ShowDeclarations()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

            string query = "SELECT TOP 31 * FROM Declaration a " +
                "ORDER BY DeclarationID DESC";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                DataTable declarationsTable = new DataTable();
                adapter.Fill(declarationsTable);

                dgvDeclarations.DataSource = declarationsTable;
                dgvDeclarations.Columns["DeclarationID"].HeaderText = "ID";
                dgvDeclarations.Columns["ContractNumber"].HeaderText = "Номер договора";
                dgvDeclarations.Columns["ContractDate"].HeaderText = "Дата договора";
                dgvDeclarations.Columns["ProdRef"].HeaderText = "Номер производственной справки";
                dgvDeclarations.Columns["ProdRefDate"].HeaderText = "Дата производственной справки";
                dgvDeclarations.Columns["ProductList"].HeaderText = "Наименование товаров";
                dgvDeclarations.Columns["Currency"].HeaderText = "Валюта";
                dgvDeclarations.Columns["AuthPerson"].HeaderText = "Уполномоченная особа";

            }

            dgvDeclarations.AllowUserToAddRows = false;
            //dgvAddedProducts.Columns["ImportedMaterials"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDeclarations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDeclarations.CellDoubleClick += new DataGridViewCellEventHandler(Show_Ditails); 

        }

        private void Show_Ditails(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int declarationID = Convert.ToInt32(dgvDeclarations.Rows[e.RowIndex].Cells["DeclarationID"].Value);
            ShowDeclaration ShowDeclaration = new ShowDeclaration(declarationID);
            ShowDeclaration.Show();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["tabPage1"])
            {
                string query = "SELECT * FROM Declaration a " +
                    "WHERE a.ContractNumber LIKE @ContractNumber " +
                    "AND a.ContractDate = @ContractDate";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@ContractNumber", contractNumber.Text);
                    command.Parameters.AddWithValue("@ContractDate", contractDate.Value.Date);

                    DataTable declarationsTable = new DataTable();
                    adapter.Fill(declarationsTable);

                    dgvDeclarations.DataSource = declarationsTable;
                    dgvDeclarations.Columns["DeclarationID"].HeaderText = "ID";
                    dgvDeclarations.Columns["ContractNumber"].HeaderText = "Номер договора";
                    dgvDeclarations.Columns["ContractDate"].HeaderText = "Дата договора";
                    dgvDeclarations.Columns["ProdRef"].HeaderText = "Номер производственной справки";
                    dgvDeclarations.Columns["ProdRefDate"].HeaderText = "Дата производственной справки";
                    dgvDeclarations.Columns["ProductList"].HeaderText = "Наименование товаров";
                    dgvDeclarations.Columns["Currency"].HeaderText = "Валюта";
                    dgvDeclarations.Columns["AuthPerson"].HeaderText = "Уполномоченная особа";

                }
            } else if (tabControl.SelectedTab == tabControl.TabPages["tabPage2"])
            {
                string query = "SELECT * FROM Declaration a " +
                    "INNER JOIN Supplements b ON a.DeclarationID = b.DeclarationID " +
                    "WHERE b.SupplementNumber LIKE @SupplementNumber " +
                    "AND b.SupplementDate = @SupplementDate";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@SupplementNumber", supplementNumber.Text);
                    command.Parameters.AddWithValue("@SupplementDate", supplementDate.Value.Date);

                    DataTable declarationsTable = new DataTable();
                    adapter.Fill(declarationsTable);

                    dgvDeclarations.DataSource = declarationsTable;
                    dgvDeclarations.Columns["DeclarationID"].HeaderText = "ID";
                    dgvDeclarations.Columns["ContractNumber"].HeaderText = "Номер договора";
                    dgvDeclarations.Columns["ContractDate"].HeaderText = "Дата договора";
                    dgvDeclarations.Columns["ProdRef"].HeaderText = "Номер производственной справки";
                    dgvDeclarations.Columns["ProdRefDate"].HeaderText = "Дата производственной справки";
                    dgvDeclarations.Columns["ProductList"].HeaderText = "Наименование товаров";
                    dgvDeclarations.Columns["Currency"].HeaderText = "Валюта";
                    dgvDeclarations.Columns["AuthPerson"].HeaderText = "Уполномоченная особа";

                }
            } else if (tabControl.SelectedTab == tabControl.TabPages["tabPage3"])
            {
                string query = "SELECT * FROM Declaration a " +
                    "INNER JOIN Invoices b ON a.DeclarationID = b.DeclarationID " +
                    "WHERE b.InvoiceNumber LIKE @InvoiceNumber " +
                    "AND b.invoiceDate = @InvoiceDate";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber.Text);
                    command.Parameters.AddWithValue("@InvoiceDate", invoiceDate.Value.Date);

                    DataTable declarationsTable = new DataTable();
                    adapter.Fill(declarationsTable);

                    dgvDeclarations.DataSource = declarationsTable;
                    dgvDeclarations.Columns["DeclarationID"].HeaderText = "ID";
                    dgvDeclarations.Columns["ContractNumber"].HeaderText = "Номер договора";
                    dgvDeclarations.Columns["ContractDate"].HeaderText = "Дата договора";
                    dgvDeclarations.Columns["ProdRef"].HeaderText = "Номер производственной справки";
                    dgvDeclarations.Columns["ProdRefDate"].HeaderText = "Дата производственной справки";
                    dgvDeclarations.Columns["ProductList"].HeaderText = "Наименование товаров";
                    dgvDeclarations.Columns["Currency"].HeaderText = "Валюта";
                    dgvDeclarations.Columns["AuthPerson"].HeaderText = "Уполномоченная особа";

                }
            } else if (tabControl.SelectedTab == tabControl.TabPages["tabPage4"])
            {
                string query = "SELECT * FROM Declaration a " +
                    "INNER JOIN PackingList b ON a.DeclarationID = b.DeclarationID " +
                    "WHERE b.PackingListNumber LIKE @PackingListNumber " +
                    "AND b.PackingListDate = @PackingListDate";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@PackingListNumber", packingListNumber.Text);
                    command.Parameters.AddWithValue("@PackingListDate", packingListDate.Value.Date);

                    DataTable declarationsTable = new DataTable();
                    adapter.Fill(declarationsTable);

                    dgvDeclarations.DataSource = declarationsTable;
                    dgvDeclarations.Columns["DeclarationID"].HeaderText = "ID";
                    dgvDeclarations.Columns["ContractNumber"].HeaderText = "Номер договора";
                    dgvDeclarations.Columns["ContractDate"].HeaderText = "Дата договора";
                    dgvDeclarations.Columns["ProdRef"].HeaderText = "Номер производственной справки";
                    dgvDeclarations.Columns["ProdRefDate"].HeaderText = "Дата производственной справки";
                    dgvDeclarations.Columns["ProductList"].HeaderText = "Наименование товаров";
                    dgvDeclarations.Columns["Currency"].HeaderText = "Валюта";
                    dgvDeclarations.Columns["AuthPerson"].HeaderText = "Уполномоченная особа";

                }
            }

        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 31 * FROM Declaration a " +
                "ORDER BY DeclarationID DESC";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                DataTable declarationsTable = new DataTable();
                adapter.Fill(declarationsTable);

                dgvDeclarations.DataSource = declarationsTable;
                dgvDeclarations.Columns["DeclarationID"].HeaderText = "ID";
                dgvDeclarations.Columns["ContractNumber"].HeaderText = "Номер договора";
                dgvDeclarations.Columns["ContractDate"].HeaderText = "Дата договора";
                dgvDeclarations.Columns["ProdRef"].HeaderText = "Номер производственной справки";
                dgvDeclarations.Columns["ProdRefDate"].HeaderText = "Дата производственной справки";
                dgvDeclarations.Columns["ProductList"].HeaderText = "Наименование товаров";
                dgvDeclarations.Columns["Currency"].HeaderText = "Валюта";
                dgvDeclarations.Columns["AuthPerson"].HeaderText = "Уполномоченная особа";

            }
        }

        private void btnNewDeclaration_Click(object sender, EventArgs e)
        {
            NewDeclaration NewDeclaration = new NewDeclaration();
            NewDeclaration.Show();
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            if (dgvDeclarations.RowCount == 0)
            {
                MessageBox.Show("Не выбран ни один объект.", "Формирование отчета", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }

            int declarationID = Convert.ToInt32(dgvDeclarations.CurrentRow.Cells["DeclarationID"].Value);
 
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;

                var uiTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

                Task taskA = Task.Factory.StartNew(() =>
                {
                    new Export().CreateDeclarationDocument(declarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskB = Task.Factory.StartNew(() =>
                {
                    new Export().CreateProdRefDocument(declarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskC = Task.Factory.StartNew(() =>
                {
                    new Export().CreateInvoiceDocument(declarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskD = Task.Factory.StartNew(() =>
                {
                    new Export().CreatePackingListDocument(declarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Process.Start(@folderName);

            }
        }
    }
}

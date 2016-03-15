using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic
{
    public partial class ShowDeclaration : Form
    {
        private int declarationID;
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        private string thisContractNumber;
        private DateTime thisContractDate;

        public ShowDeclaration(int declarationID)
        {
            this.declarationID = declarationID;
            InitializeComponent();

            string queryDeclaration = "SELECT * FROM Declaration a " +
                "WHERE a.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryDeclaration, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                DataTable declarationTable = new DataTable();
                adapter.Fill(declarationTable);

                if (declarationTable.Rows.Count == 1)
                {
                    thisContractNumber = declarationTable.Rows[0].Field<string>("ContractNumber");
                    thisContractDate = declarationTable.Rows[0].Field<DateTime>("ContractDate");

                    contractNumber.Text = declarationTable.Rows[0].Field<string>("ContractNumber");
                    contractDate.Value = declarationTable.Rows[0].Field<DateTime>("ContractDate");
                    prodRefNumber.Text = declarationTable.Rows[0].Field<string>("ProdRef");
                    prodRefDate.Value = declarationTable.Rows[0].Field<DateTime>("ProdRefDate");
                    productList.Text = declarationTable.Rows[0].Field<string>("ProductList");
                    currency.SelectedItem = declarationTable.Rows[0].Field<string>("Currency").ToString();
                    authPerson.SelectedItem = declarationTable.Rows[0].Field<string>("AuthPerson").ToString();

                }
            }

            lbTitle.Text = "Договор № " + thisContractNumber.ToString() + " от " + thisContractDate.ToShortDateString();

            Update_dgvSupplements();

            Update_dgvInvoices();

            Update_dgvPackingLists();

            dgvSupplements.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToAddRows = false;
            dgvPackingLists.AllowUserToAddRows = false;

            //dgvAddedProducts.Columns["ImportedMaterials"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSupplements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPackingLists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSupplements.CellDoubleClick += new DataGridViewCellEventHandler(Show_Supplement_Ditails);
            dgvInvoices.CellDoubleClick += new DataGridViewCellEventHandler(Show_Invoice_Ditails);
            dgvPackingLists.CellDoubleClick += new DataGridViewCellEventHandler(Show_PackingList_Ditails);

        }

        private void Show_PackingList_Ditails(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int packingListID = Convert.ToInt32(dgvPackingLists.Rows[e.RowIndex].Cells["PackingListID"].Value);
            ChangeDetailsPackingList PackingListDetailsForm = new ChangeDetailsPackingList(this, packingListID);
            PackingListDetailsForm.Show();
        }

        private void Show_Invoice_Ditails(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int invoiceID = Convert.ToInt32(dgvInvoices.Rows[e.RowIndex].Cells["InvoiceID"].Value);
            ShowInvoice ShowInvoice = new ShowInvoice(this, invoiceID);
            ShowInvoice.Show();
        }

        private void Show_Supplement_Ditails(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int supplementID = Convert.ToInt32(dgvSupplements.Rows[e.RowIndex].Cells["SupplementID"].Value);
            ShowSupplement ShowSupplement = new ShowSupplement(this, supplementID);
            ShowSupplement.Show();
        }

        public ShowDeclaration()
        {
            InitializeComponent();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Declaration " +
                "SET ContractNumber = @ContractNumber, ContractDate = @ContractDate, ProdRef = @ProdRef, ProdRefDate = @ProdRefDate, ProductList = @ProductList, Currency = @Currency, AuthPerson = @AuthPerson " +
                "WHERE DeclarationID = @DeclarationID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ContractNumber", contractNumber.Text);
                command.Parameters.AddWithValue("@ContractDate", contractDate.Value);
                command.Parameters.AddWithValue("@ProdRef", prodRefNumber.Text);
                command.Parameters.AddWithValue("@ProdRefDate", prodRefDate.Value);
                command.Parameters.AddWithValue("@ProductList", productList.Text);
                command.Parameters.AddWithValue("@Currency", currency.SelectedItem.ToString());
                command.Parameters.AddWithValue("@AuthPerson", authPerson.SelectedItem.ToString());

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                command.ExecuteNonQuery();
            }
        }

        private void btnAddSupplement_Click(object sender, EventArgs e)
        {
            AddSupplement AddSupplement = new AddSupplement(this, declarationID);
            AddSupplement.Show();
        }

        private void removeSupplement_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Удалить приложение?", "Запрос на удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                int supplementID = Convert.ToInt32(dgvSupplements.CurrentRow.Cells["SupplementID"].Value);

                string query = "DELETE FROM Supplements " +
                    "WHERE SupplementID = @SupplementID";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@SupplementID", supplementID);

                    command.ExecuteNonQuery();
                }

                Update_dgvSupplements();
                Update_dgvInvoices();
            }
            
        }

        public void Update_dgvSupplements()
        {
            string querySupplements = "SELECT a.SupplementID, a.SupplementNumber, a.SupplementDate, a.OfferNumber FROM Supplements a " +
                "WHERE a.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySupplements, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                DataTable supplementsTable = new DataTable();
                adapter.Fill(supplementsTable);

                dgvSupplements.DataSource = supplementsTable;
                dgvSupplements.Columns["SupplementID"].HeaderText = "ID";
                dgvSupplements.Columns["SupplementNumber"].HeaderText = "Номер приложения";
                dgvSupplements.Columns["SupplementDate"].HeaderText = "Дата приложения";
                dgvSupplements.Columns["OfferNumber"].HeaderText = "Номер ОФ";

            }

            if (dgvSupplements.RowCount == 0) btnRemoveSupplement.Enabled = false;
            else
            {
                btnRemoveSupplement.Enabled = true;
            }
        }

        public void Update_dgvInvoices()
        {
            string queryInvoices = "SELECT a.InvoiceID, a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                "WHERE a.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryInvoices, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                DataTable invoicesTable = new DataTable();
                adapter.Fill(invoicesTable);

                dgvInvoices.DataSource = invoicesTable;
                dgvInvoices.Columns["InvoiceID"].HeaderText = "ID";
                dgvInvoices.Columns["InvoiceNumber"].HeaderText = "Номер инвойса";
                dgvInvoices.Columns["InvoiceDate"].HeaderText = "Дата инвойса";

            }

            if (dgvInvoices.RowCount == 0)
            {
                btnRemoveInvoice.Enabled = false;
                btnAddSpecification.Enabled = false;
            }
            else
            {
                btnRemoveInvoice.Enabled = true;
                btnAddSpecification.Enabled = true;
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoice AddInvoice = new AddInvoice(this, declarationID);
            AddInvoice.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveInvoice_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить инвойс?", "Запрос на удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                int invoiceID = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceID"].Value);

                string query = "DELETE FROM Invoices " +
                    "WHERE InvoiceID = @InvoiceID";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                    command.ExecuteNonQuery();
                }

                Update_dgvInvoices();
            }
        }

        private void btnAddSpecification_Click(object sender, EventArgs e)
        {
            int invoiceID = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceID"].Value);
            Form AddSpecification = new AddSpecification(this, invoiceID);
            AddSpecification.Show();

        }

        public void Update_dgvPackingLists()
        {
            string queryPackingLists = "SELECT a.PackingListID, a.PackingListNumber, a.PackingListDate, a.CheckedPerson FROM PackingList a " +
                "WHERE a.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryPackingLists, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                DataTable packingListsTable = new DataTable();
                adapter.Fill(packingListsTable);

                dgvPackingLists.DataSource = packingListsTable;
                dgvPackingLists.Columns["PackingListID"].HeaderText = "ID";
                dgvPackingLists.Columns["PackingListNumber"].HeaderText = "Номер упаковочного листа";
                dgvPackingLists.Columns["PackingListDate"].HeaderText = "Дата упаковочного листа";
                dgvPackingLists.Columns["CheckedPerson"].HeaderText = "Проверил";

            }

            if (dgvPackingLists.RowCount == 0)
            {
                btnRemovePackingList.Enabled = false;
                btnFormPackingList.Enabled = false;
                btnAddPackingList.Enabled = true;
            }
            else
            {
                btnRemovePackingList.Enabled = true;
                btnFormPackingList.Enabled = true;
                btnAddPackingList.Enabled = false;
            }
        }

        private void btnAddPackingList_Click(object sender, EventArgs e)
        {
            AddPackingList AddPackingListForm = new AddPackingList(this, declarationID);
            AddPackingListForm.Show();
        }

        private void btnRemovePackingList_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить упаковочный лист?", "Запрос на удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                int packingListID = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["PackingListID"].Value);

                string query = "DELETE FROM PackingList " +
                    "WHERE PackingListID = @PackingListID";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@PackingListID", packingListID);

                    command.ExecuteNonQuery();
                }

                Update_dgvPackingLists();
            }
        }

        private void btnFormPackingList_Click(object sender, EventArgs e)
        {
            int packingListID = Convert.ToInt32(dgvPackingLists.CurrentRow.Cells["PackingListID"].Value);
            AddPackingListSpecification packingListSpecificationForm = new AddPackingListSpecification(packingListID);
            packingListSpecificationForm.Show();
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
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

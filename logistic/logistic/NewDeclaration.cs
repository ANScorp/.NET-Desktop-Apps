using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace logistic
{
    public partial class NewDeclaration : Form
    {
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        public int insertedDeclarationID;
        public int insertedPackingListID;
        public int productAmount;
        private string templatePath;

        public NewDeclaration()
        {
            InitializeComponent();

            authPerson.SelectedIndex = 0;
            currency.SelectedIndex = 0;
            checkedPerson.SelectedIndex = 0;

            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;

            //this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new DrawItemEventHandler(DisableTab_DrawItem);
        }

        private void btnAddSupplement_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Supplements (DeclarationID, SupplementNumber, SupplementDate, OfferNumber) VALUES (@DeclarationID, @SupplementNumber, @SupplementDate, @OfferNumber)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                command.Parameters.AddWithValue("@SupplementNumber", supplementNumber.Text);
                command.Parameters.AddWithValue("@SupplementDate", supplementDate.Value);

                command.Parameters.AddWithValue("@OfferNumber", offerNumber.Text);

                command.ExecuteNonQuery();
            }

            string querySelectSupplements = "SELECT a.SupplementNumber FROM Supplements a " +
                "INNER JOIN Declaration b ON a.DeclarationID = b.DeclarationID " +
                "WHERE b.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectSupplements, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                DataTable supplementTable = new DataTable();
                adapter.Fill(supplementTable);

                lstSupplements.DisplayMember = "SupplementNumber";
                lstSupplements.ValueMember = "SupplementID";
                lstSupplements.DataSource = supplementTable;

            }

            btnGoToInvoice.Enabled = true;
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Declaration (ContractNumber, ContractDate, ProdRef, ProdRefDate, ProductList, Currency, AuthPerson) VALUES (@ContractNumber, @ContractDate, @ProdRef, @ProdRefDate, @ProductList, @Currency, @AuthPerson) " +
                "SELECT SCOPE_IDENTITY()";
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

                insertedDeclarationID = Convert.ToInt32(command.ExecuteScalar());

                lbContract.Text = "№ " + contractNumber.Text + " от " + contractDate.Value.ToShortDateString();

                tabControl1.TabPages.Remove(tabPage1);
                tabPage2.Enabled = true;
                tabControl1.SelectedTab = tabPage2;

            }
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
                    new Export().CreateDeclarationDocument(insertedDeclarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskB = Task.Factory.StartNew(() =>
                {
                    new Export().CreateProdRefDocument(insertedDeclarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskC = Task.Factory.StartNew(() =>
                {
                    new Export().CreateInvoiceDocument(insertedDeclarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskD = Task.Factory.StartNew(() =>
                {
                    new Export().CreatePackingListDocument(insertedDeclarationID, folderName);
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Process.Start(@folderName);

            }
        }


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void DisableTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage page = tabControl.TabPages[e.Index];
            if (!page.Enabled)
            {
                //Draws disabled tab
                using (SolidBrush brush = new SolidBrush(SystemColors.GrayText))
                {
                    e.Graphics.DrawString(page.Text, page.Font, brush, e.Bounds.X + 3, e.Bounds.Y + 3);
                }
            }
            else
            {
                // Draws normal tab
                using (SolidBrush brush = new SolidBrush(page.ForeColor))
                {
                    e.Graphics.DrawString(page.Text, page.Font, brush, e.Bounds.X + 3, e.Bounds.Y + 3);
                }
            }
        }

        private void btnGoToInvoice_Click(object sender, EventArgs e)
        {
            lbContractInvoice.Text = "№ " + contractNumber.Text + " от " + contractDate.Value.ToShortDateString();

            string querySelectSupplements = "SELECT a.SupplementID, a.SupplementNumber FROM Supplements a " +
                "INNER JOIN Declaration b ON a.DeclarationID = b.DeclarationID " +
                "WHERE b.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectSupplements, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                DataTable supplementTable = new DataTable();
                adapter.Fill(supplementTable);

                cbSupplementToInvoice.DisplayMember = "SupplementNumber";
                cbSupplementToInvoice.ValueMember = "SupplementID";
                cbSupplementToInvoice.DataSource = supplementTable;

            }

            tabControl1.TabPages.Remove(tabPage2);
            tabPage3.Enabled = true;
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Invoices (DeclarationID, SupplementID, InvoiceNumber, InvoiceDate) VALUES (@DeclarationID, @SupplementID, @InvoiceNumber, @InvoiceDate)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                command.Parameters.AddWithValue("@SupplementID", cbSupplementToInvoice.SelectedValue);

                command.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber.Text);

                command.Parameters.AddWithValue("@InvoiceDate", invoiceDate.Value);

                command.ExecuteNonQuery();
            }

            string querySelectSupplements = "SELECT a.InvoiceID, a.InvoiceNumber FROM Invoices a " +
                "INNER JOIN Declaration b ON a.DeclarationID = b.DeclarationID " +
                "WHERE b.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectSupplements, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                DataTable supplementTable = new DataTable();
                adapter.Fill(supplementTable);

                lstInvoices.DisplayMember = "InvoiceNumber";
                lstInvoices.ValueMember = "InvoiceID";
                lstInvoices.DataSource = supplementTable;

            }

        }

        private void btnInvoicesToPackList_Click(object sender, EventArgs e)
        {
            lbContractPackList.Text = "№ " + contractNumber.Text + " от " + contractDate.Value.ToShortDateString();

            tabControl1.TabPages.Remove(tabPage3);
            tabPage4.Enabled = true;
            tabControl1.SelectedTab = tabPage4;
        }

        private void btnAddPackList_Click(object sender, EventArgs e)
        {
            btnAddPackList.Enabled = false;
            packingListNumber.Enabled = false;
            packingListDate.Enabled = false;
            checkedPerson.Enabled = false;
            btnMakeReport.Enabled = true;

            string query = "INSERT INTO PackingList (DeclarationID, PackingListNumber, PackingListDate, CheckedPerson) VALUES (@DeclarationID, @PackingListNumber, @PackingListDate, @CheckedPerson) " +
                "SELECT SCOPE_IDENTITY()";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                command.Parameters.AddWithValue("@PackingListNumber", packingListNumber.Text);

                command.Parameters.AddWithValue("@PackingListDate", packingListDate.Value);

                command.Parameters.AddWithValue("@CheckedPerson", checkedPerson.SelectedItem.ToString());

                insertedPackingListID = Convert.ToInt32(command.ExecuteScalar());
            }

            AddPackingListSpecification AddPackingList = new AddPackingListSpecification(insertedPackingListID);
            AddPackingList.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSpecification_Click(object sender, EventArgs e)
        {
            AddSpecification AddSpecification = new AddSpecification(this, Int32.Parse(lstInvoices.SelectedValue.ToString()));
            AddSpecification.Show();

            btnInvoicesToPackList.Enabled = true;
        }
    }

}

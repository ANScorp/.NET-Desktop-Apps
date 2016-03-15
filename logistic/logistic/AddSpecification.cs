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
    public partial class AddSpecification : Form
    {
        private NewDeclaration frm;
        private ShowDeclaration declarationForm;

        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        private string supplementNumber;
        private DateTime supplementDate;

        private string invoiceNumber;
        private DateTime invoiceDate;

        private string thisContractNumber;
        private DateTime thisContractDate;
        private string thisContractCurrency;
        private int thisInvoiceID;

        public AddSpecification(NewDeclaration form, int invoiceID)
        {

            this.frm = form;
            InitializeComponent();

            thisInvoiceID = invoiceID;

            lbContract.Text = "К договору " + "№ " + frm.contractNumber.Text + " от " + frm.contractDate.Value.ToShortDateString();

            string querySelectSupplement = "SELECT a.SupplementNumber, a.SupplementDate FROM Supplements a " +
                "INNER JOIN Invoices b ON a.SupplementID = b.SupplementID " +
                "WHERE b.InvoiceID = @InvoiceID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectSupplement, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@InvoiceID", frm.lstInvoices.SelectedValue);

                DataTable supplementTable = new DataTable();
                adapter.Fill(supplementTable);

                if (supplementTable.Rows.Count == 1)
                {
                    supplementNumber = supplementTable.Rows[0].Field<string>("SupplementNumber");
                    supplementDate = supplementTable.Rows[0].Field<DateTime>("SupplementDate");
                }

            }

            lbSupplement.Text = "Согласно приложения № " + supplementNumber.ToString() + " от " + supplementDate.ToShortDateString();


            string querySelectInvoice = "SELECT a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                "WHERE a.InvoiceID = @InvoiceID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectInvoice, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@InvoiceID", frm.lstInvoices.SelectedValue);

                DataTable invoiceTable = new DataTable();
                adapter.Fill(invoiceTable);

                if (invoiceTable.Rows.Count == 1)
                {
                    invoiceNumber = invoiceTable.Rows[0].Field<string>("InvoiceNumber");
                    invoiceDate = invoiceTable.Rows[0].Field<DateTime>("InvoiceDate");
                }

            }

            lbInvoice.Text = "Счет-фактура № " + invoiceNumber + " от " + invoiceDate.ToShortDateString();
            productCode.SelectedIndex = 0;
            lbPrice.Text = lbPrice.Text + frm.currency.SelectedItem.ToString() + "/шт.:";
            lbSum.Text = lbSum.Text + frm.currency.SelectedItem.ToString() + ":";

            Update_dgvAddedProducts();

            dgvAddedProducts.AllowUserToAddRows = false;
            //dgvAddedProducts.Columns["ImportedMaterials"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAddedProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.quantity.ValueChanged += new EventHandler (Calculate_Sum);
            this.productPrice.ValueChanged += new EventHandler(Calculate_Sum);

            dgvAddedProducts.CellDoubleClick += new DataGridViewCellEventHandler(Show_Edit_SpecificationItem);

        }

        private void Show_Edit_SpecificationItem(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int productID = Convert.ToInt32(dgvAddedProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
            EditSpecificationItem EditSpecificationItemForm = new EditSpecificationItem(this, productID);
            EditSpecificationItemForm.Show();
        }

        public AddSpecification(ShowDeclaration declarationForm, int invoiceID)
        {

            this.declarationForm = declarationForm;
            InitializeComponent();

            thisInvoiceID = invoiceID;

            string queryInvoice = "SELECT a.ContractNumber, a.ContractDate, a.Currency FROM Declaration a " +
                "INNER JOIN Invoices b ON a.DeclarationID = b.DeclarationID " +
                "WHERE b.InvoiceID = @InvoiceID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryInvoice, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                DataTable declarationTable = new DataTable();
                adapter.Fill(declarationTable);

                if (declarationTable.Rows.Count == 1)
                {
                    thisContractNumber = declarationTable.Rows[0].Field<string>("ContractNumber");
                    thisContractDate = declarationTable.Rows[0].Field<DateTime>("ContractDate");
                    thisContractCurrency = declarationTable.Rows[0].Field<string>("Currency");

                }
            }

            lbContract.Text = "К договору " + "№ " + thisContractNumber.ToString() + " от " + thisContractDate.ToShortDateString();

            string query = "SELECT b.InvoiceNumber, b.InvoiceDate, a.SupplementNumber, a.SupplementDate FROM Supplements a " +
                "INNER JOIN Invoices b ON a.SupplementID = b.SupplementID " +
                "WHERE b.InvoiceID = @InvoiceID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                DataTable detailsTable = new DataTable();
                adapter.Fill(detailsTable);

                if (detailsTable.Rows.Count == 1)
                {
                    supplementNumber = detailsTable.Rows[0].Field<string>("SupplementNumber");
                    supplementDate = detailsTable.Rows[0].Field<DateTime>("SupplementDate");
                    invoiceNumber = detailsTable.Rows[0].Field<string>("InvoiceNumber");
                    invoiceDate = detailsTable.Rows[0].Field<DateTime>("InvoiceDate");
                }

            }

            lbSupplement.Text = "Согласно приложения № " + supplementNumber.ToString() + " от " + supplementDate.ToShortDateString();

            lbInvoice.Text = "Счет-фактура № " + invoiceNumber + " от " + invoiceDate.ToShortDateString();
            productCode.SelectedIndex = 0;
            lbPrice.Text = lbPrice.Text + thisContractCurrency + "/шт.:";
            lbSum.Text = lbSum.Text + thisContractCurrency + ":";

            Update_dgvAddedProducts();

            dgvAddedProducts.AllowUserToAddRows = false;
            //dgvAddedProducts.Columns["ImportedMaterials"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAddedProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.quantity.ValueChanged += new EventHandler(Calculate_Sum);
            this.productPrice.ValueChanged += new EventHandler(Calculate_Sum);

            dgvAddedProducts.CellDoubleClick += new DataGridViewCellEventHandler(Show_Edit_SpecificationItem);

        }

        private void Calculate_Sum(object s, EventArgs e)
        {
            Sum.Text = (quantity.Value * productPrice.Value).ToString();
        }

        public AddSpecification()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Specifications (InvoiceID, ProductName, ProductCode, Quantity, ProductPrice, Sum, ImportedMaterials) VALUES (@InvoiceID, @ProductName, @ProductCode, @Quantity, @ProductPrice, @Sum, @ImportedMaterials)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@InvoiceID", thisInvoiceID);

                command.Parameters.AddWithValue("@ProductName", productName.Text);

                command.Parameters.AddWithValue("@ProductCode", Int64.Parse(productCode.SelectedItem.ToString()));

                command.Parameters.AddWithValue("@Quantity", quantity.Value);

                command.Parameters.AddWithValue("@ProductPrice", productPrice.Value);

                command.Parameters.AddWithValue("@Sum", quantity.Value * productPrice.Value);

                command.Parameters.AddWithValue("@ImportedMaterials", importedMaterials.Value);

                command.ExecuteNonQuery();
            }

            Update_dgvAddedProducts();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить продукт?", "Запрос на удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                int productID = Convert.ToInt32(dgvAddedProducts.CurrentRow.Cells["ProductID"].Value);

                string query = "DELETE FROM Specifications " +
                    "WHERE ProductID = @ProductID";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@ProductID", productID);

                    command.ExecuteNonQuery();
                }

                Update_dgvAddedProducts();
            }

            
        }

        public void Update_dgvAddedProducts()
        {
            string querySelectSpecifications = "SELECT a.ProductID, a.ProductName, a.ProductCode, a.Quantity, a.ProductPrice, a.Sum, a.ImportedMaterials FROM Specifications a " +
                "WHERE a.InvoiceID = @InvoiceID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectSpecifications, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@InvoiceID", thisInvoiceID);

                DataTable supplementTable = new DataTable();
                adapter.Fill(supplementTable);

                //lstSupplements.DisplayMember = "SupplementNumber";
                //lstSupplements.ValueMember = "SupplementID";
                dgvAddedProducts.DataSource = supplementTable;
                dgvAddedProducts.Columns["ProductID"].HeaderText = "ID";
                dgvAddedProducts.Columns["ProductName"].HeaderText = "Наименование товара";
                dgvAddedProducts.Columns["ProductCode"].HeaderText = "Код товара";
                dgvAddedProducts.Columns["Quantity"].HeaderText = "Количество, шт.";
                dgvAddedProducts.Columns["ProductPrice"].HeaderText = "Цена, " + thisContractCurrency + "/шт.";
                dgvAddedProducts.Columns["Sum"].HeaderText = "Сумма, " + thisContractCurrency;
                dgvAddedProducts.Columns["ImportedMaterials"].HeaderText = "Удельный вес импортного сырья, %";
            }

            if (dgvAddedProducts.RowCount == 0) btnRemoveProduct.Enabled = false;
            else
            {
                btnRemoveProduct.Enabled = true;
            }
        }

    }
}

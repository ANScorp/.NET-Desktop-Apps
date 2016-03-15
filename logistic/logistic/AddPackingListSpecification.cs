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
    public partial class AddPackingListSpecification : Form
    {
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;
        private int packingListID;

        private void Show_Edit_PackingListSpecificationItem(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int packingListItemID = Convert.ToInt32(dgvAddedProducts.Rows[e.RowIndex].Cells["PackingListItemID"].Value);
            EditPackingListSpecificationItem EditPackingListSpecificationItemForm = new EditPackingListSpecificationItem(this, packingListItemID);
            EditPackingListSpecificationItemForm.Show();
        }

        private void See_Products(object sender, EventArgs e)
        {
            string query = "SELECT a.ProductID, a.ProductName FROM Specifications a " +
                "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                "WHERE b.InvoiceID = @InvoiceID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@InvoiceID", cbInvoiceNumber.SelectedValue);

                DataTable productsTable = new DataTable();
                adapter.Fill(productsTable);

                cbProductName.DisplayMember = "ProductName";
                cbProductName.ValueMember = "ProductID";
                cbProductName.DataSource = productsTable;

            }
        }

        public AddPackingListSpecification()
        {
            InitializeComponent();
        }

        public AddPackingListSpecification(int packingListID)
        {
            int declarationID;
            string contractNumber;
            DateTime contractDate;
            string packingListNumber;
            DateTime packingListDate;

            // TODO: Complete member initialization
            this.packingListID = packingListID;
            InitializeComponent();

            string query = "SELECT b.DeclarationID, b.ContractNumber, b.ContractDate, a.PackingListNumber, a.PackingListDate FROM PackingList a " +
                "INNER JOIN Declaration b ON a.DeclarationID = b.DeclarationID " +
                "WHERE a.PackingListID = @PackingListID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@PackingListID", packingListID);

                DataTable table = new DataTable();
                adapter.Fill(table);

                declarationID = table.Rows[0].Field<int>("DeclarationID");
                contractNumber = table.Rows[0].Field<string>("ContractNumber");
                contractDate = table.Rows[0].Field<DateTime>("ContractDate");
                packingListNumber = table.Rows[0].Field<string>("PackingListNumber");
                packingListDate = table.Rows[0].Field<DateTime>("PackingListDate");
            }

            lbContract.Text = "К договору " + "№ " + contractNumber.ToString() + " от " + contractDate.ToShortDateString();

            lbPakingList.Text = "Упаковочный лист № " + packingListNumber + " от " + packingListDate.ToShortDateString();

            string queryInvoices = "SELECT a.InvoiceID, a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                "INNER JOIN Declaration b ON a.DeclarationID = b.DeclarationID " +
                "WHERE b.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryInvoices, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                DataTable invoicesTable = new DataTable();
                adapter.Fill(invoicesTable);

                cbInvoiceNumber.DisplayMember = "InvoiceNumber";
                cbInvoiceNumber.ValueMember = "InvoiceID";
                cbInvoiceNumber.DataSource = invoicesTable;

            }

            Update_dgvAddedProducts();

            this.cbInvoiceNumber.SelectedIndexChanged += new EventHandler(See_Products);
            See_Products(cbInvoiceNumber, new EventArgs());

            dgvAddedProducts.AllowUserToAddRows = false;
            dgvAddedProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAddedProducts.CellDoubleClick += new DataGridViewCellEventHandler(Show_Edit_PackingListSpecificationItem);
        }

        public void Update_dgvAddedProducts()
        {
            string querySelectSpecifications = "SELECT a.PackingListItemID, a.ItemName, a.PackageType, a.Quantity, a.PackingWeight, a.NetPerItem, a.Net, a.Gross, a.PalletNumber, a.SeatsNumber FROM PackingListSpecification a " +
                "WHERE a.PackingListID = @PackingListID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectSpecifications, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@PackingListID", packingListID);

                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);

                //lstSupplements.DisplayMember = "SupplementNumber";
                //lstSupplements.ValueMember = "SupplementID";
                dgvAddedProducts.DataSource = itemsTable;
                dgvAddedProducts.Columns["PackingListItemID"].HeaderText = "ID";
                dgvAddedProducts.Columns["ItemName"].HeaderText = "Наименование";
                dgvAddedProducts.Columns["PackageType"].HeaderText = "Вид упаковки";
                dgvAddedProducts.Columns["Quantity"].HeaderText = "Количество, шт.";
                dgvAddedProducts.Columns["PackingWeight"].HeaderText = "Вес упаковки, кг";
                dgvAddedProducts.Columns["NetPerItem"].HeaderText = "Вес нетто за ед., кг";
                dgvAddedProducts.Columns["Net"].HeaderText = "Общий вес нетто, кг";
                dgvAddedProducts.Columns["Gross"].HeaderText = "Общий вес брутто, кг";
                dgvAddedProducts.Columns["PalletNumber"].HeaderText = "№ поддона";
                dgvAddedProducts.Columns["SeatsNumber"].HeaderText = "Количество мест";

            }

            if (dgvAddedProducts.RowCount == 0) btnRemoveItem.Enabled = false;
            else
            {
                btnRemoveItem.Enabled = true;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO PackingListSpecification (PackingListID, InvoiceID, ProductID, ItemName, PackageType, Quantity, PackingWeight, NetPerItem, Net, Gross, PalletNumber, SeatsNumber) VALUES (@PackingListID, @InvoiceID, @ProductID, @ItemName, @PackageType, @Quantity, @PackingWeight, @NetPerItem, @Net, @Gross, @PalletNumber, @SeatsNumber)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@PackingListID", packingListID);

                command.Parameters.AddWithValue("@InvoiceID", cbInvoiceNumber.SelectedValue);

                command.Parameters.AddWithValue("@ProductID", cbProductName.SelectedValue);

                command.Parameters.AddWithValue("@ItemName", itemName.Text);

                command.Parameters.AddWithValue("@PackageType", packageType.Text);

                command.Parameters.AddWithValue("@Quantity", quantity.Value);

                command.Parameters.AddWithValue("@PackingWeight", packingWeight.Value);

                command.Parameters.AddWithValue("@NetPerItem", netPerItem.Value);

                command.Parameters.AddWithValue("@Net", netPerItem.Value * quantity.Value);

                command.Parameters.AddWithValue("@Gross", (netPerItem.Value + packingWeight.Value) * quantity.Value);

                command.Parameters.AddWithValue("@PalletNumber", palletNumber.Text);

                command.Parameters.AddWithValue("@SeatsNumber", seatsNumber.Value);

                command.ExecuteNonQuery();
            }

            Update_dgvAddedProducts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить позицию?", "Запрос на удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                int packingListItemID = Convert.ToInt32(dgvAddedProducts.CurrentRow.Cells["PackingListItemID"].Value);

                string query = "DELETE FROM PackingListSpecification " +
                    "WHERE PackingListItemID = @PackingListItemID";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@PackingListItemID", packingListItemID);

                    command.ExecuteNonQuery();
                }

                Update_dgvAddedProducts();
            }
        }
    }
}

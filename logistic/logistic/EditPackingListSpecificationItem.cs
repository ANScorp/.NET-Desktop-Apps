using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic
{
    public partial class EditPackingListSpecificationItem : Form
    {
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;
        private AddPackingListSpecification addPackingListSpecification;
        private int packingListItemID;

        public EditPackingListSpecificationItem()
        {
            InitializeComponent();
        }

        public EditPackingListSpecificationItem(AddPackingListSpecification addPackingListSpecification, int packingListItemID)
        {
            int declarationID;
            string thisContractNumber;
            DateTime thisContractDate;
            string thisPackingListNumber;
            DateTime thisPackingListDate;
            int thisInvoiceID;
            int thisProductID;

            // TODO: Complete member initialization
            this.addPackingListSpecification = addPackingListSpecification;
            this.packingListItemID = packingListItemID;
            InitializeComponent();

            string query = "SELECT a.DeclarationID, a.ContractNumber, a.ContractDate, b.PackingListNumber, b.PackingListDate, c.InvoiceID, c.ProductID, c.ItemName, c.PackageType, c.Quantity, c.PackingWeight, c.NetPerItem, c.Net, c.Gross, c.PalletNumber, c.SeatsNumber FROM Declaration a " +
                "INNER JOIN PackingList b ON a.DeclarationID = b.DeclarationID " +
                "INNER JOIN PackingListSpecification c ON b.PackingListID = c.PackingListID " +
                "WHERE c.PackingListItemID = @PackingListItemID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@PackingListItemID", packingListItemID);

                DataTable table = new DataTable();
                adapter.Fill(table);

                declarationID = table.Rows[0].Field<int>("DeclarationID");
                thisContractNumber = table.Rows[0].Field<string>("ContractNumber");
                thisContractDate = table.Rows[0].Field<DateTime>("ContractDate");
                thisPackingListNumber = table.Rows[0].Field<string>("PackingListNumber");
                thisPackingListDate = table.Rows[0].Field<DateTime>("PackingListDate");

                thisInvoiceID = table.Rows[0].Field<int>("InvoiceID");

                thisProductID = table.Rows[0].Field<int>("ProductID");

                itemName.Text = table.Rows[0].Field<string>("ItemName");

                packageType.Text = table.Rows[0].Field<string>("PackageType");

                quantity.Value = table.Rows[0].Field<int>("Quantity");

                packingWeight.Value = table.Rows[0].Field<int>("PackingWeight");

                netPerItem.Value = table.Rows[0].Field<int>("NetPerItem");

                palletNumber.Text = table.Rows[0].Field<string>("PalletNumber");

                seatsNumber.Value = table.Rows[0].Field<int>("SeatsNumber");
            }

            lbContract.Text = "К договору " + "№ " + thisContractNumber.ToString() + " от " + thisContractDate.ToShortDateString();

            lbPakingList.Text = "Упаковочный лист № " + thisPackingListNumber + " от " + thisPackingListDate.ToShortDateString();

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

            cbInvoiceNumber.SelectedValue = thisInvoiceID;

            this.cbInvoiceNumber.SelectedIndexChanged += new EventHandler(See_Products);
            See_Products(cbInvoiceNumber, new EventArgs());

            cbProductName.SelectedValue = thisProductID;

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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string query = "UPDATE PackingListSpecification " +
                "SET InvoiceID = @InvoiceID, ProductID = @ProductID, ItemName = @ItemName, PackageType = @PackageType, Quantity = @Quantity, PackingWeight = @PackingWeight, NetPerItem = @NetPerItem, Net = @Net, Gross = @Gross, PalletNumber = @PalletNumber, SeatsNumber = @SeatsNumber " +
                "WHERE PackingListItemID = @PackingListItemID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

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


                command.Parameters.AddWithValue("@PackingListItemID", packingListItemID);


                command.ExecuteNonQuery();
            }

            addPackingListSpecification.Update_dgvAddedProducts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class EditSpecificationItem : Form
    {
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;
        private AddSpecification addSpecification;
        private int productID;

        public EditSpecificationItem()
        {
            InitializeComponent();
        }

        public EditSpecificationItem(AddSpecification addSpecification, int productID)
        {
            // TODO: Complete member initialization
            this.addSpecification = addSpecification;
            this.productID = productID;
            InitializeComponent();

            string thisContractNumber;
            DateTime thisContractDate;
            string thisSupplementNumber;
            DateTime thisSupplementDate;
            string thisInvoiceNumber;
            DateTime thisInvoiceDate;

            string query = "SELECT a.ContractNumber, a.ContractDate, b.SupplementNumber, b.SupplementDate, c.InvoiceNumber, c.InvoiceDate FROM Declaration a " +
                "INNER JOIN Invoices c ON a.DeclarationID = c.DeclarationID " +
                "INNER JOIN Specifications d ON d.InvoiceID = c.InvoiceID " +
                "INNER JOIN Supplements b ON c.SupplementID = b.SupplementID " +
                "WHERE d.ProductID = @ProductID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@ProductID", productID);

                DataTable table = new DataTable();
                adapter.Fill(table);

                thisContractNumber = table.Rows[0].Field<string>("ContractNumber");
                thisContractDate = table.Rows[0].Field<DateTime>("ContractDate");
                thisSupplementNumber = table.Rows[0].Field<string>("SupplementNumber");
                thisSupplementDate = table.Rows[0].Field<DateTime>("SupplementDate");
                thisInvoiceNumber = table.Rows[0].Field<string>("InvoiceNumber");
                thisInvoiceDate = table.Rows[0].Field<DateTime>("InvoiceDate");

            }

            lbContract.Text = "К договору " + "№ " + thisContractNumber.ToString() + " от " + thisContractDate.ToShortDateString();

            lbSupplement.Text = "Согласно приложения № " + thisSupplementNumber.ToString() + " от " + thisSupplementDate.ToShortDateString();

            lbInvoice.Text = "Счет-фактура № " + thisInvoiceNumber + " от " + thisInvoiceDate.ToShortDateString();

            string querySelectProductItem = "SELECT a.ProductName, a.ProductCode, a.Quantity, a.ProductPrice, a.Sum, a.ImportedMaterials FROM Specifications a " +
                "WHERE a.ProductID = @ProductID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectProductItem, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@ProductID", productID);

                DataTable productItemTable = new DataTable();
                adapter.Fill(productItemTable);

                productName.Text = productItemTable.Rows[0].Field<string>("ProductName");
                productCode.SelectedItem = productItemTable.Rows[0].Field<Int64>("ProductCode").ToString();
                quantity.Value = productItemTable.Rows[0].Field<int>("Quantity");
                productPrice.Value = productItemTable.Rows[0].Field<decimal>("ProductPrice");
                Sum.Text = productItemTable.Rows[0].Field<decimal>("Sum").ToString();
                importedMaterials.Value = productItemTable.Rows[0].Field<decimal>("ImportedMaterials");

            }

            this.quantity.ValueChanged += new EventHandler(Calculate_Sum);
            this.productPrice.ValueChanged += new EventHandler(Calculate_Sum);
        }

        private void Calculate_Sum(object sender, EventArgs e)
        {
            Sum.Text = (quantity.Value * productPrice.Value).ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Specifications " +
                "SET ProductName = @ProductName, ProductCode = @ProductCode, Quantity = @Quantity, ProductPrice = @ProductPrice, Sum = @Sum, ImportedMaterials = @ImportedMaterials " +
                "WHERE ProductID = @ProductID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ProductName", productName.Text);

                command.Parameters.AddWithValue("@ProductCode", Int64.Parse(productCode.SelectedItem.ToString()));

                command.Parameters.AddWithValue("@Quantity", quantity.Value);

                command.Parameters.AddWithValue("@ProductPrice", productPrice.Value);

                command.Parameters.AddWithValue("@Sum", quantity.Value * productPrice.Value);

                command.Parameters.AddWithValue("@ImportedMaterials", importedMaterials.Value);


                command.Parameters.AddWithValue("@ProductID", productID);

                command.ExecuteNonQuery();
            }

            addSpecification.Update_dgvAddedProducts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

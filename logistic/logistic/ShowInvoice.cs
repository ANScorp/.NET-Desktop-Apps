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
    public partial class ShowInvoice : Form
    {
        private ShowDeclaration frm;
        private int declarationID;
        private int invoiceID;
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;
        private int supplementID;

        public ShowInvoice(ShowDeclaration declarationForm, int invoiceID)
        {
            this.frm = declarationForm;
            this.invoiceID = invoiceID;
            InitializeComponent();

            string queryInvoice = "SELECT a.DeclarationID, a.SupplementID, a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                "WHERE a.InvoiceID = @InvoiceID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryInvoice, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                DataTable invoiceTable = new DataTable();
                adapter.Fill(invoiceTable);

                declarationID = invoiceTable.Rows[0].Field<int>("DeclarationID");
                supplementID = invoiceTable.Rows[0].Field<int>("SupplementID");
                invoiceNumber.Text = invoiceTable.Rows[0].Field<string>("InvoiceNumber");
                invoiceDate.Value = invoiceTable.Rows[0].Field<DateTime>("InvoiceDate");

            }

            string querySelectSupplements = "SELECT a.SupplementID, a.SupplementNumber FROM Supplements a " +
                "INNER JOIN Declaration b ON a.DeclarationID = b.DeclarationID " +
                "WHERE b.DeclarationID = @DeclarationID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySelectSupplements, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                DataTable supplementTable = new DataTable();
                adapter.Fill(supplementTable);

                cbSupplementToInvoice.DisplayMember = "SupplementNumber";
                cbSupplementToInvoice.ValueMember = "SupplementID";
                cbSupplementToInvoice.DataSource = supplementTable;

            }

            cbSupplementToInvoice.SelectedValue = supplementID;
        }

        public ShowInvoice()
        {
            InitializeComponent();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Invoices " +
                "SET SupplementID = @SupplementID, InvoiceNumber = @InvoiceNumber, InvoiceDate = @InvoiceDate " +
                "WHERE InvoiceID = @InvoiceID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@SupplementID", cbSupplementToInvoice.SelectedValue);
                command.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber.Text);
                command.Parameters.AddWithValue("@InvoiceDate", invoiceDate.Value);

                command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                command.ExecuteNonQuery();
            }

            frm.Update_dgvInvoices();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

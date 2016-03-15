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
    public partial class AddInvoice : Form
    {
        private ShowDeclaration frm;
        private int declarationID;
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;
        
        public AddInvoice(ShowDeclaration declarationForm, int declarationID)
        {
            this.frm = declarationForm;
            this.declarationID = declarationID;
            InitializeComponent();

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
        }
        public AddInvoice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Invoices (DeclarationID, SupplementID, InvoiceNumber, InvoiceDate) VALUES (@DeclarationID, @SupplementID, @InvoiceNumber, @InvoiceDate)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                command.Parameters.AddWithValue("@SupplementID", cbSupplementToInvoice.SelectedValue);

                command.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber.Text);

                command.Parameters.AddWithValue("@InvoiceDate", invoiceDate.Value);

                command.ExecuteNonQuery();
            }

            frm.Update_dgvInvoices();
        }
    }
}

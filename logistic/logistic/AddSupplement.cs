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
    public partial class AddSupplement : Form
    {
        private int declarationID;
        private ShowDeclaration frm;
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        public AddSupplement(ShowDeclaration declarationForm, int declarationID)
        {
            this.declarationID = declarationID;
            this.frm = declarationForm;
            InitializeComponent();
        }

        public AddSupplement()
        {
            InitializeComponent();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Supplements (DeclarationID, SupplementNumber, SupplementDate, OfferNumber) VALUES (@DeclarationID, @SupplementNumber, @SupplementDate, @OfferNumber)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                command.Parameters.AddWithValue("@SupplementNumber", supplementNumber.Text);
                command.Parameters.AddWithValue("@SupplementDate", supplementDate.Value);

                command.Parameters.AddWithValue("@OfferNumber", offerNumber.Text);

                command.ExecuteNonQuery();
            }

            frm.Update_dgvSupplements();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

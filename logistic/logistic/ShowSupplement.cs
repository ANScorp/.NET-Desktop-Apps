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
    public partial class ShowSupplement : Form
    {
        private int supplementID;
        private ShowDeclaration frm;
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;


        public ShowSupplement(ShowDeclaration declarationForm, int supplementID)
        {
            this.supplementID = supplementID;
            this.frm = declarationForm;
            InitializeComponent();

            string querySupplement = "SELECT a.SupplementNumber, a.SupplementDate, a.OfferNumber FROM Supplements a " +
                "WHERE a.SupplementID = @SupplementID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySupplement, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@SupplementID", supplementID);

                DataTable supplementTable = new DataTable();
                adapter.Fill(supplementTable);

                supplementNumber.Text = supplementTable.Rows[0].Field<string>("SupplementNumber");
                supplementDate.Value = supplementTable.Rows[0].Field<DateTime>("SupplementDate");
                offerNumber.Text = supplementTable.Rows[0].Field<int>("OfferNumber").ToString();

            }
        }

        public ShowSupplement()
        {
            InitializeComponent();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Supplements " +
                "SET SupplementNumber = @SupplementNumber, SupplementDate = @SupplementDate, OfferNumber = @OfferNumber " +
                "WHERE SupplementID = @SupplementID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@SupplementNumber", supplementNumber.Text);
                command.Parameters.AddWithValue("@SupplementDate", supplementDate.Value);
                command.Parameters.AddWithValue("@OfferNumber", offerNumber.Text);

                command.Parameters.AddWithValue("@SupplementID", supplementID);

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

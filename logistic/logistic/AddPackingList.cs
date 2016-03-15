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
    public partial class AddPackingList : Form
    {
        private ShowDeclaration showDeclaration;
        private int declarationID;
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        public AddPackingList()
        {
            InitializeComponent();
        }

        public AddPackingList(ShowDeclaration showDeclaration, int declarationID)
        {
            // TODO: Complete member initialization
            this.showDeclaration = showDeclaration;
            this.declarationID = declarationID;
            InitializeComponent();

            checkedPerson.SelectedIndex = 0;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO PackingList (DeclarationID, PackingListNumber, PackingListDate, CheckedPerson) VALUES (@DeclarationID, @PackingListNumber, @PackingListDate, @CheckedPerson)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@DeclarationID", declarationID);

                command.Parameters.AddWithValue("@PackingListNumber", packingListNumber.Text);

                command.Parameters.AddWithValue("@PackingListDate", packingListDate.Value);

                command.Parameters.AddWithValue("@CheckedPerson", checkedPerson.SelectedItem);

                command.ExecuteNonQuery();
            }

            showDeclaration.Update_dgvPackingLists();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

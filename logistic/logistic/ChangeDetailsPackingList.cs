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
    public partial class ChangeDetailsPackingList : Form
    {
        private int packingListID;
        private ShowDeclaration showDeclaration;
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        public ChangeDetailsPackingList()
        {
            InitializeComponent();
        }

        public ChangeDetailsPackingList(int packingListID)
        {
            // TODO: Complete member initialization
            this.packingListID = packingListID;
            InitializeComponent();
        }

        public ChangeDetailsPackingList(ShowDeclaration showDeclaration, int packingListID)
        {
            // TODO: Complete member initialization
            this.showDeclaration = showDeclaration;
            this.packingListID = packingListID;
            InitializeComponent();

            string query = "SELECT a.PackingListNumber, a.PackingListDate, a.CheckedPerson FROM PackingList a " +
                "WHERE a.PackingListID = @PackingListID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@PackingListID", packingListID);

                DataTable table = new DataTable();
                adapter.Fill(table);

                packingListNumber.Text = table.Rows[0].Field<string>("PackingListNumber");
                packingListDate.Value = table.Rows[0].Field<DateTime>("PackingListDate");
                checkedPerson.SelectedItem = table.Rows[0].Field<string>("CheckedPerson");

            }

            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string query = "UPDATE PackingList " +
                "SET PackingListNumber = @PackingListNumber, PackingListDate = @PackingListDate, CheckedPerson = @CheckedPerson " +
                "WHERE PackingListID = @PackingListID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@PackingListNumber", packingListNumber.Text);
                command.Parameters.AddWithValue("@PackingListDate", packingListDate.Value);
                command.Parameters.AddWithValue("@CheckedPerson", checkedPerson.SelectedItem.ToString());

                command.Parameters.AddWithValue("@PackingListID", packingListID);

                command.ExecuteNonQuery();
            }

            showDeclaration.Update_dgvPackingLists();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

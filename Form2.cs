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

namespace BillingSoftware
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["billingFormData"].ConnectionString;
        }
        public static void ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                // Perform database operations
            }
        }
        private void accountSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(account_name.Text))
            {
                MessageBox.Show("Account Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into account_master (account_name, status, created_at) values(@account_name,@status,@created_at)", connection);

                    cmd.Parameters.AddWithValue("@account_name", account_name.Text);
                    cmd.Parameters.AddWithValue("@status", "A");
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }

                // Clear fields after successful save
                account_name.Clear();

                // Show success message
                MessageBox.Show("Successfully saved", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.account_masterTableAdapter.Fill(this.billingFormDataAccountsDataSet.account_master);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingFormDataAccountsDataSet.account_master' table. You can move, or remove it, as needed.
            this.account_masterTableAdapter.Fill(this.billingFormDataAccountsDataSet.account_master);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}

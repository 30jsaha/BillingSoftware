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
        public int ac_id = 0;
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
            if (ac_id==0)
            {
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
                    // this.account_masterTableAdapter.Fill(this.billingFormDataAccountsDataSet.account_master);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } 
            else
            {
                if (!account_name.Enabled)
                {
                    MessageBox.Show("Please click on the modify button to edit fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Update the database with the edited values if validation passes
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                    {
                        connection.Open();
                        string query = "UPDATE account_master SET account_name = @account_name, " +
                                    "updated_at = @updated_at " +
                                    "WHERE id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@account_name", account_name.Text);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", ac_id);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data updated successfully", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // TODO: This line of code loads data into the 'billingFormDataAccountsDataSet.account_master' table. You can move, or remove it, as needed.
                // this.account_masterTableAdapter.Fill(this.billingFormDataAccountsDataSet.account_master);
                LoadData();
                account_name.Clear();
                account_name.Enabled=false;
                accountAddNewBtn.Enabled=true;
                accountSaveBtn.Enabled=false;
                accountModifyBtn.Enabled=false;
                accountRemoveBtn.Enabled=false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingFormDataAccountsDataSet.account_master' table. You can move, or remove it, as needed.
            // this.account_masterTableAdapter.Fill(this.billingFormDataAccountsDataSet.account_master);
            LoadData();
            account_name.Clear();
            account_name.Enabled=false;
            accountAddNewBtn.Enabled=true;
            accountSaveBtn.Enabled=false;
            accountModifyBtn.Enabled=false;
            accountRemoveBtn.Enabled=false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index is valid
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return; // Ignore if row index is out of bounds

            // Get the edited row's data
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Fetch the column indices using DataPropertyName
            int accountNameIndex = FindColumnIndexByPropertyName("account_name");
            int accountIdIndex = FindColumnIndexByPropertyName("id");

            if (accountNameIndex >= 0 && accountIdIndex >= 0)
            {
               // Check if expected columns exist using DataPropertyName
                bool hasRequiredColumns = true;
                string[] requiredColumns = { "id", "account_name" };

                foreach (string columnName in requiredColumns)
                {
                    bool columnExists = false;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        Console.WriteLine(column.Name);
                        Console.ReadLine();
                        // Check if DataPropertyName matches the required column name
                        if (column.DataPropertyName.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                        {
                            columnExists = true;
                            break;
                        }
                    }

                    if (!columnExists)
                    {
                        hasRequiredColumns = false;
                        MessageBox.Show($"The required column '{columnName}' is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (hasRequiredColumns)
                {
                    // Access the values by column index
                    string accountName = row.Cells[accountNameIndex].Value?.ToString();

                    // Assuming the ID is part of the data bound properties
                    int accountId = Convert.ToInt32(row.Cells[accountIdIndex].Value); // Adjust if DataPropertyName is different
                    account_name.Text=accountName;
                    account_name.Enabled=false;
                    accountAddNewBtn.Enabled=true;
                    accountSaveBtn.Enabled=false;
                    accountModifyBtn.Enabled=true;
                    accountRemoveBtn.Enabled=true;
                    ac_id=accountId;
                }
            }
            else
            {
                MessageBox.Show("One or more expected columns do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int FindColumnIndexByPropertyName(string propertyName)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName.Equals(propertyName, StringComparison.OrdinalIgnoreCase))
                {
                    return column.Index;
                }
            }
            return -1; // Not found
        }

        private void accountAddNewBtn_Click(object sender, EventArgs e)
        {
            account_name.Clear();
            account_name.Enabled = true;
            accountAddNewBtn.Enabled = false;
            accountSaveBtn.Enabled = true;
            accountModifyBtn.Enabled = false;
            accountRemoveBtn.Enabled = false;
            ac_id=0;
        }

        private void accountModifyBtn_Click(object sender, EventArgs e)
        {
            account_name.Enabled = true;
            accountAddNewBtn.Enabled = true;
            accountSaveBtn.Enabled = true;
            accountModifyBtn.Enabled = false;
            accountRemoveBtn.Enabled = false;
        }

        private void AccountFormCancelBtn_Click(object sender, EventArgs e)
        {
            account_name.Clear();
            account_name.Enabled = false;
            accountAddNewBtn.Enabled = true;
            accountSaveBtn.Enabled = false;
            accountModifyBtn.Enabled = false;
            accountRemoveBtn.Enabled = false;
            ac_id=0;
        }

        private void AccountFormExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountRemoveBtn_Click(object sender, EventArgs e)
        {
            if (ac_id==0)
            {
                MessageBox.Show("Oops Something Went Wrong !", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Remove the item ?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                    {
                        connection.Open();
                        string query = "UPDATE account_master SET status = @status, updated_at = @updated_at " +
                                    "WHERE id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@status", "D");
                        cmd.Parameters.AddWithValue("@id", ac_id);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Removed successfully", "Data Remove Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //after successfull deletion, Load the datagridview data again
                // TODO: This line of code loads data into the 'billingFormDataAccountsDataSet.account_master' table. You can move, or remove it, as needed.
                // this.account_masterTableAdapter.Fill(this.billingFormDataAccountsDataSet.account_master);
                LoadData();
                account_name.Clear();
                account_name.Enabled=false;
                accountAddNewBtn.Enabled=true;
                accountSaveBtn.Enabled=false;
                accountModifyBtn.Enabled=false;
                accountRemoveBtn.Enabled=false;
                ac_id = 0;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    // SQL query
                    string query = @"
                        SELECT 
                            id,
                            account_name,
                            created_at
                        FROM dbo.account_master
                        WHERE status = 'A'";

                    // Execute the query and fill the data into a DataTable
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;

                    // (Optional) Set custom column header text in the DataGridView
                    dataGridView1.Columns["id"].HeaderText = "Id";
                    dataGridView1.Columns["account_name"].HeaderText = "Name";
                    dataGridView1.Columns["created_at"].HeaderText = "Creation Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

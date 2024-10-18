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
    public partial class currencyForm : Form
    {
        public int currId=0;
        public currencyForm()
        {
            InitializeComponent();
        }
        private void currencyForm_Load(object sender, EventArgs e)
        {
            currId=0;
            disableCurrencyFormFields();
            clearCurrencyFormFields();
            currencyAddNewBtn.Enabled=true;
            currencyModifyBtn.Enabled=false;
            currencySaveBtn.Enabled=false;
            currencyRemoveBtn.Enabled=false;
            LoadData();
        }
        private void currencyFormExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void enableCurrencyFormFields()
        {
            currency_name.Enabled=true;
            currency_details.Enabled=true;
        }
        private void disableCurrencyFormFields()
        {
            currency_name.Enabled=false;
            currency_details.Enabled=false;
        }
        private void clearCurrencyFormFields()
        {
            currency_name.Clear();
            currency_details.Clear();
        }

        private void currencyFormCancelBtn_Click(object sender, EventArgs e)
        {
            disableCurrencyFormFields();
            currId=0;
            clearCurrencyFormFields();
            currencyAddNewBtn.Enabled=true;
            currencyModifyBtn.Enabled=false;
            currencySaveBtn.Enabled=false;
            currencyRemoveBtn.Enabled=false;
        }

        private void currencyAddNewBtn_Click(object sender, EventArgs e)
        {
            enableCurrencyFormFields();
            currId=0;
            clearCurrencyFormFields();
            currencyAddNewBtn.Enabled=false;
            currencyModifyBtn.Enabled=false;
            currencySaveBtn.Enabled=true;
            currencyRemoveBtn.Enabled=false;
        }

        private void currencySaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currency_name.Text))
            {
                MessageBox.Show("Currency Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // if (string.IsNullOrWhiteSpace(currency_details.Text))
            // {
            //     MessageBox.Show("Currency Details cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return;
            // }
            string currDetails=(string.IsNullOrWhiteSpace(currency_details.Text)) ? null : currency_details.Text;
            if (currId==0)
            {
                //Save Data
                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnection.GetMasterConnectionString()))
                    {
                        connection.Open();
                        var mSql = "insert into currency_master (currency_name, currency_details, status, created_at) values(@currency_name, @currency_details, @status, @created_at)";
                        SqlCommand cmd = new SqlCommand(mSql, connection);
                        cmd.Parameters.AddWithValue("@currency_name", currency_name.Text);
                        cmd.Parameters.AddWithValue("@currency_details", currDetails);
                        cmd.Parameters.AddWithValue("@status", 'A');
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    // Clear fields after successful save
                    clearCurrencyFormFields();
                    currencyFormCancelBtn.PerformClick();
                    // Show success message
                    MessageBox.Show("Successfully saved", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.item_masterTableAdapter.Fill(this.billingFormDataDataSet.item_master);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Update Data
                if (!currency_name.Enabled)
                {
                    MessageBox.Show("Please click on the modify button to edit fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnection.GetMasterConnectionString()))
                    {
                        connection.Open();
                        string query = "UPDATE currency_master SET currency_name = @currency_name, currency_details = @currency_details, updated_at = @updated_at " +
                                    "WHERE id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@currency_name", currency_name.Text);
                        cmd.Parameters.AddWithValue("@currency_details", currDetails);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", currId);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data updated successfully", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    currencyFormCancelBtn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currencyAddNewBtn.Enabled=true;
            currencyModifyBtn.Enabled=true;
            currencySaveBtn.Enabled=false;
            currencyRemoveBtn.Enabled=true;
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return; // Ignore if row index is out of bounds
            
            // Get the edited row's data
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Fetch the column indices using DataPropertyName
            int currencyNameIndex = FindColumnIndexByPropertyName("currency_name");
            int currencyDetailsIndex = FindColumnIndexByPropertyName("currency_details");
            int currencyIdIndex = FindColumnIndexByPropertyName("id");

            if (currencyNameIndex >= 0 && currencyDetailsIndex >= 0 && currencyIdIndex >= 0)
            {
                string currencyName = row.Cells[currencyNameIndex].Value?.ToString();
                string currencyDetails = row.Cells[currencyDetailsIndex].Value?.ToString();
                int currencyId = Convert.ToInt32(row.Cells[currencyIdIndex].Value);

                currency_name.Text=currencyName;
                currency_details.Text=currencyDetails;
                currId=currencyId;
                disableCurrencyFormFields();
            }

        }
        // Helper function to find the column index by DataPropertyName
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
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection.GetMasterConnectionString()))
                {
                    // SQL query
                    string query = @"
                        SELECT 
                            id, 
                            currency_name,
                            currency_details,
                            created_at
                        FROM dbo.currency_master 
                        WHERE status = 'A'";

                    // Execute the query and fill the data into a DataTable
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;

                    // (Optional) Set custom column header text in the DataGridView
                    dataGridView1.Columns["id"].HeaderText = "ID";
                    dataGridView1.Columns["currency_name"].HeaderText = "Currency Name";
                    dataGridView1.Columns["currency_details"].HeaderText = "Currency Details";
                    dataGridView1.Columns["created_at"].HeaderText = "Created At";
                    dataGridView1.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the 'created_at' column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "created_at")
            {
                // Check if the cell value is not null and is of DateTime type
                if (e.Value != null && e.Value is DateTime)
                {
                    // Format the DateTime value to 'yyyy-MM-dd hh:mm:ss'
                    e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void currencyModifyBtn_Click(object sender, EventArgs e)
        {
            enableCurrencyFormFields();
            currencyAddNewBtn.Enabled=true;
            currencyModifyBtn.Enabled=false;
            currencySaveBtn.Enabled=true;
            currencyRemoveBtn.Enabled=false;
        }

        private void currencyRemoveBtn_Click(object sender, EventArgs e)
        {
            if (currId==0)
            {
                MessageBox.Show("Oops Something Went Wrong !", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Remove the item ?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnection.GetMasterConnectionString()))
                    {
                        connection.Open();
                        string query = "UPDATE currency_master SET status = @status " +
                                    "WHERE id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@status", "D");
                        cmd.Parameters.AddWithValue("@id", currId);

                        cmd.ExecuteNonQuery();
                    }
                    //after successfull deletion, Load the datagridview data again
                    LoadData();
                    disableCurrencyFormFields();
                    clearCurrencyFormFields();
                    currencyFormCancelBtn.PerformClick();
                    currId = 0;
                    MessageBox.Show("Removed successfully", "Data Remove Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}

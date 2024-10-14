using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class vendorForm : Form
    {
        public int vendorId=0;
        public vendorForm()
        {
            InitializeComponent();
        }

        private void vendorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingFormDataDataSet3.currency_master' table. You can move, or remove it, as needed.
            this.currency_masterTableAdapter.Fill(this.billingFormDataDataSet3.currency_master);
            LoadData();
            disableVendorFormFields();
            clearVendorFormFields();
            vendorModifyBtn.Enabled=false;
            vendorSaveBtn.Enabled=false;
            vendorDeleteBtn.Enabled=false;
            vendorAddNewBtn.Enabled=true;
            vendorId=0;
        }
        private void vendorFormExitBtn_Click(object sender, EventArgs e)
        {
            vendorId = 0;
            this.Close();
        }
        private void clearVendorFormFields()
        {
            vendor_name.Clear();
            vendorPhone.Clear();
            vendorEmail.Clear();
            vendorCurrency.SelectedIndex = 0;
            vendorCity.Clear();
            vendorState.Clear();
            vendorPincode.Clear();
            vendorAddress.Clear();
        }
        private void enableVendorFormFields()
        {
            vendor_name.Enabled=true;
            vendorPhone.Enabled=true;
            vendorEmail.Enabled=true;
            vendorCurrency.Enabled=true;
            vendorCity.Enabled=true;
            vendorState.Enabled=true;
            vendorPincode.Enabled=true;
            vendorAddress.Enabled=true;
        }
        private void disableVendorFormFields()
        {
            vendor_name.Enabled=false;
            vendorPhone.Enabled=false;
            vendorEmail.Enabled=false;
            vendorCurrency.Enabled=false;
            vendorCity.Enabled=false;
            vendorState.Enabled=false;
            vendorPincode.Enabled=false;
            vendorAddress.Enabled=false;
        }

        private void vendorAddNewBtn_Click(object sender, EventArgs e)
        {
            clearVendorFormFields();
            enableVendorFormFields();
            vendorModifyBtn.Enabled=false;
            vendorSaveBtn.Enabled=true;
            vendorDeleteBtn.Enabled=false;
            vendorId=0;
        }

        private void vendorFormCancelBtn_Click(object sender, EventArgs e)
        {
            clearVendorFormFields();
            disableVendorFormFields();
            vendorModifyBtn.Enabled=false;
            vendorSaveBtn.Enabled=false;
            vendorDeleteBtn.Enabled=false;
            vendorAddNewBtn.Enabled=true;
            vendorId=0;
        }

        private void vendorSaveBtn_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(vendor_name.Text))
           {
                MessageBox.Show("Vendor name cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           } 
           if (string.IsNullOrWhiteSpace(vendorPhone.Text))
           {
                MessageBox.Show("Vendor Contact cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           } 
           else 
           {
                if (!decimal.TryParse(vendorPhone.Text, out decimal vphone))
                {
                    MessageBox.Show("Vendor contact must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
           }
           if (string.IsNullOrWhiteSpace(vendorEmail.Text))
           {
                MessageBox.Show("Vendor email cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           } 
           if (vendorCurrency.SelectedItem == null)
           {
                MessageBox.Show("Currency must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           } 
           if (string.IsNullOrWhiteSpace(vendorCity.Text))
           {
                MessageBox.Show("Vendor city cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           }
           if (string.IsNullOrWhiteSpace(vendorState.Text))
           {
                MessageBox.Show("Vendor state cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           }
           if (string.IsNullOrWhiteSpace(vendorPincode.Text))
           {
                MessageBox.Show("Vendor pincode cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           }  
           else 
           {
                if (!decimal.TryParse(vendorPincode.Text, out decimal vpcode))
                {
                    MessageBox.Show("Vendor pincode must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
           }
            // If validation passes, proceed to save data
           if (vendorId==0)
           {
                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                    {
                        connection.Open();
                        var mSql = "INSERT INTO dbo.vendor_master (vendor_name, vendor_phone, vendor_email, vendor_currency_id," +
                            " vendor_city, vendor_state, vendor_pincode, vendor_address, status, created_at) values (@vendor_name, @vendor_phone, @vendor_email, @vendor_currency_id," +
                            " @vendor_city, @vendor_state, @vendor_pincode, @vendor_address, @status, @created_at)";
                        SqlCommand cmd = new SqlCommand(mSql, connection);
                        cmd.Parameters.AddWithValue("@vendor_name", vendor_name.Text);
                        cmd.Parameters.AddWithValue("@vendor_phone", vendorPhone.Text);
                        cmd.Parameters.AddWithValue("@vendor_email", vendorEmail.Text);
                        cmd.Parameters.AddWithValue("@vendor_currency_id", vendorCurrency.SelectedValue);
                        cmd.Parameters.AddWithValue("@vendor_city", vendorCity.Text);
                        cmd.Parameters.AddWithValue("@vendor_state", vendorState.Text);
                        cmd.Parameters.AddWithValue("@vendor_pincode", vendorPincode.Text);
                        cmd.Parameters.AddWithValue("@vendor_address", vendorAddress.Text);
                        cmd.Parameters.AddWithValue("@status", 'A');
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data inserted successfully", "Data Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load the table data
                    LoadData();
                    // Perform the cancel button click
                    vendorFormCancelBtn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
           }
           else
           {
            //Proceed to update data
            // MessageBox.Show("Data updation initiated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                    {
                        connection.Open();
                        var mSql = "UPDATE dbo.vendor_master SET vendor_name = @vendor_name, vendor_phone = @vendor_phone, vendor_email = @vendor_email," +
                            " vendor_currency_id = @vendor_currency_id, vendor_city = @vendor_city, vendor_state = @vendor_state, vendor_pincode = @vendor_pincode, vendor_address = @vendor_address," +
                            " updated_at = @updated_at WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(mSql, connection);
                        cmd.Parameters.AddWithValue("@vendor_name", vendor_name.Text);
                        cmd.Parameters.AddWithValue("@vendor_phone", vendorPhone.Text);
                        cmd.Parameters.AddWithValue("@vendor_email", vendorEmail.Text);
                        cmd.Parameters.AddWithValue("@vendor_currency_id", vendorCurrency.SelectedValue);
                        cmd.Parameters.AddWithValue("@vendor_city", vendorCity.Text);
                        cmd.Parameters.AddWithValue("@vendor_state", vendorState.Text);
                        cmd.Parameters.AddWithValue("@vendor_pincode", vendorPincode.Text);
                        cmd.Parameters.AddWithValue("@vendor_address", vendorAddress.Text);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", vendorId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data updated successfully", "Data Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load the table data
                    LoadData();
                    // Perform the cancel button click
                    vendorFormCancelBtn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
           }
        }
        private void vendorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disableVendorFormFields();
            vendorModifyBtn.Enabled=true;
            vendorSaveBtn.Enabled=false;
            vendorDeleteBtn.Enabled=true;
            vendorAddNewBtn.Enabled=true;
            if (e.RowIndex < 0 || e.RowIndex >= vendorDataGridView.Rows.Count)
                return; // Ignore if row index is out of bounds
            
            DataGridViewRow row = vendorDataGridView.Rows[e.RowIndex];

            // Fetch the column indices using DataPropertyName
            int vendorIdIndex = FindColumnIndexByPropertyName("id");
            int vendor_nameIndex = FindColumnIndexByPropertyName("vendor_name");
            int vendor_phoneIndex = FindColumnIndexByPropertyName("vendor_phone");
            int vendor_emailIndex = FindColumnIndexByPropertyName("vendor_email");
            int vendor_cityIndex = FindColumnIndexByPropertyName("vendor_city");
            int vendor_currency_idIndex = FindColumnIndexByPropertyName("vendor_currency_id");
            int vendor_stateIndex = FindColumnIndexByPropertyName("vendor_state");
            int vendor_pincodeIndex = FindColumnIndexByPropertyName("vendor_pincode");
            int vendor_addressIndex = FindColumnIndexByPropertyName("vendor_address");

            if (vendorIdIndex>=0 && vendor_nameIndex>=0 && vendor_phoneIndex>=0 && vendor_emailIndex>=0 &&
                vendor_cityIndex >= 0 && vendor_currency_idIndex>=0 && vendor_stateIndex>=0 && vendor_pincodeIndex>=0 &&
                vendor_addressIndex >=0)
            {
                string vName = row.Cells[vendor_nameIndex].Value?.ToString();
                string vPhone = row.Cells[vendor_phoneIndex].Value?.ToString();
                string vEmail = row.Cells[vendor_emailIndex].Value?.ToString();
                string vCity = row.Cells[vendor_cityIndex].Value?.ToString();
                string vState = row.Cells[vendor_stateIndex].Value?.ToString();
                string vPincode = row.Cells[vendor_pincodeIndex].Value?.ToString();
                string vAddress = row.Cells[vendor_addressIndex].Value?.ToString();
                
                int vId = Convert.ToInt32(row.Cells[vendorIdIndex].Value);
                int vCurrId = Convert.ToInt32(row.Cells[vendor_currency_idIndex].Value);

                vendor_name.Text=vName;
                vendorPhone.Text=vPhone;
                vendorEmail.Text=vEmail;
                vendorCurrency.SelectedValue=vCurrId;
                vendorCity.Text=vCity;
                vendorState.Text=vState;
                vendorPincode.Text=vPincode;
                vendorAddress.Text=vAddress;
                vendorId=vId;
            }
        }
        // Helper function to find the column index by DataPropertyName
        private int FindColumnIndexByPropertyName(string propertyName)
        {
            foreach (DataGridViewColumn column in vendorDataGridView.Columns)
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
                using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                {
                    //SQL Query
                    string query = @"SELECT"+
                    " * FROM dbo.vendor_master"+
                    " WHERE dbo.vendor_master.status='A'";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    vendorDataGridView.DataSource = dt;
                    vendorDataGridView.Columns["vendor_name"].HeaderText = "Name";
                    vendorDataGridView.Columns["vendor_phone"].HeaderText = "Phone";
                    vendorDataGridView.Columns["vendor_email"].HeaderText = "Email";
                    vendorDataGridView.Columns["vendor_city"].HeaderText = "City";
                    vendorDataGridView.Columns["vendor_state"].HeaderText = "State";
                    vendorDataGridView.Columns["vendor_pincode"].HeaderText = "Pincode";
                    vendorDataGridView.Columns["vendor_address"].HeaderText = "Address";
                    vendorDataGridView.Columns["created_at"].HeaderText = "Date";
                    vendorDataGridView.Columns["id"].Visible = false;
                    vendorDataGridView.Columns["vendor_currency_id"].Visible = false;
                    vendorDataGridView.Columns["updated_at"].Visible = false;
                }
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error Loading Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void vendorDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (vendorDataGridView.Columns[e.ColumnIndex].Name=="created_at")
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

        private void vendorModifyBtn_Click(object sender, EventArgs e)
        {
            enableVendorFormFields();
            vendorModifyBtn.Enabled=false;
            vendorSaveBtn.Enabled=true;
            vendorDeleteBtn.Enabled=false;
            vendorAddNewBtn.Enabled=false;
        }

        private void vendorDeleteBtn_Click(object sender, EventArgs e)
        {
            if (vendorId==0)
            {
                MessageBox.Show("Oops Something Went Wrong !", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Remove the Vendor: '"+ vendor_name.Text +"' ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                    {
                        connection.Open();
                        string query = "UPDATE vendor_master SET status = @status " +
                                    "WHERE id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@status", "D");
                        cmd.Parameters.AddWithValue("@id", vendorId);

                        cmd.ExecuteNonQuery();
                    }
                    //after successfull deletion, Load the datagridview data again
                    LoadData();
                    vendorFormCancelBtn.PerformClick();
                    vendorId = 0;
                    MessageBox.Show("Removed successfully", "Data Remove Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}

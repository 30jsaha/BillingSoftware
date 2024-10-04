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
    public partial class Form4 : Form
    {
        public int customerId { get; set; } // Public property to hold the 'id'
        // public int customerId = 0;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingFormDataDataSet3.currency_master' table. You can move, or remove it, as needed.
            this.currency_masterTableAdapter.Fill(this.billingFormDataDataSet3.currency_master);
            if (customerId != 0)
            {
                custSaveBtn.Enabled = false;
                custModifyBtn.Enabled = true;
                customerFormHeading.Text = "Modify New Customer";
                disableCustomerFormFields();
                MessageBox.Show("Customer ID is: "+ customerId);
            }
            else 
            {
                enableCustomerFormFields();
                custSaveBtn.Enabled = true;
                custModifyBtn.Enabled = false;
                customerFormHeading.Text = "Add New Customer";
            }
        }

        private void custSaveBtn_Click(object sender, EventArgs e)
        {
            //validation of the data
            if (!custType1.Checked && !custType2.Checked)
            {
                MessageBox.Show("Please select the Customer Type (Business or Individual).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(custName.Text))
            {
                MessageBox.Show("Customer name cannot be left blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(custPrimContact.Text) || !decimal.TryParse(custPrimContact.Text, out decimal contact))
            {
                MessageBox.Show("Contact must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(custEmail.Text))
            {
                MessageBox.Show("Customer email cannot be left blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // if (custCurrency.SelectedItem == null)
            // {
            //     MessageBox.Show("Please select a currency.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return;
            // }
            //if (string.IsNullOrWhiteSpace(custState.Text))
            //{
            //    MessageBox.Show("Customer state cannot be left blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (string.IsNullOrWhiteSpace(custPincode.Text) || !decimal.TryParse(custPincode.Text, out decimal pincode))
            {
                MessageBox.Show("Pincode must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cType = custType1.Checked ? 1 : 2;
            string compName = (string.IsNullOrWhiteSpace(custCompName.Text)) ? null : custCompName.Text;
            string customerCity = (string.IsNullOrWhiteSpace(custCity.Text)) ? null : custCity.Text;
            string customerState = (string.IsNullOrWhiteSpace(custState.Text)) ? null : custState.Text;
            string customerAddress = (string.IsNullOrWhiteSpace(custAddress.Text)) ? null : custAddress.Text;
            if (customerId==0)
            {
                //Save Customer Data
                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                    {
                        connection.Open();
                        var mSql = "insert into customer_master " +
                            "(customer_name, customer_email, customer_phone, customer_type, company_name, " +
                            "currency_id, customer_city, customer_state, customer_pincode, customer_address, created_at, status) " +
                            "values(@customer_name, @customer_email, @customer_phone, @customer_type, " + // <-- Add the comma here
                            "@company_name, @currency_id, @customer_city, @customer_state, @customer_pincode, " +
                            "@customer_address, @created_at, @status)";

                        SqlCommand cmd = new SqlCommand(mSql, connection);

                        cmd.Parameters.AddWithValue("@customer_name", custName.Text);
                        cmd.Parameters.AddWithValue("@customer_email", custEmail.Text);
                        cmd.Parameters.AddWithValue("@customer_phone", custPrimContact.Text);
                        cmd.Parameters.AddWithValue("@customer_type", cType);
                        cmd.Parameters.AddWithValue("@company_name", compName);
                        cmd.Parameters.AddWithValue("@currency_id", custCurrency.SelectedValue);
                        cmd.Parameters.AddWithValue("@customer_city", customerCity);
                        cmd.Parameters.AddWithValue("@customer_state", customerState);
                        cmd.Parameters.AddWithValue("@customer_pincode", custPincode.Text);
                        cmd.Parameters.AddWithValue("@customer_address", customerAddress);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@status", 'A');

                        cmd.ExecuteNonQuery();
                    }

                    // Clear fields after successful save
                    clearCustomerFormFields();

                    // Show success message
                    MessageBox.Show("Successfully saved", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 form3 = Application.OpenForms["Form3"] as Form3;

                    if (form3 != null)
                    {
                        form3.LoadData(); // Call the LoadData method of Form3
                    }
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Update Customer Data
            }
        }

        private void clearCustomerFormFields()
        {
            custName.Clear();
            custEmail.Clear();
            custPrimContact.Clear();
            custCompName.Clear();
            custCurrency.SelectedIndex = 0;
            custCity.Clear();
            custState.Clear();
            custPincode.Clear();
            custAddress.Clear();
            custType1.Checked = true;
            custType2.Checked = false;
        }
        private void enableCustomerFormFields()
        {
            custName.Enabled=true;
            custEmail.Enabled=true;
            custPrimContact.Enabled=true;
            custCompName.Enabled=true;
            custCurrency.Enabled=true;
            custCity.Enabled=true;
            custState.Enabled=true;
            custPincode.Enabled=true;
            custAddress.Enabled=true;
            custType1.Enabled=true;
            custType2.Enabled=true;
        }
        private void disableCustomerFormFields()
        {
            custName.Enabled=false;
            custEmail.Enabled=false;
            custPrimContact.Enabled=false;
            custCompName.Enabled=false;
            custCurrency.Enabled=false;
            custCity.Enabled=false;
            custState.Enabled=false;
            custPincode.Enabled=false;
            custAddress.Enabled=false;
            custType1.Enabled=false;
            custType2.Enabled=false;
        }

        private void custCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void custModifyBtn_Click(object sender, EventArgs e)
        {
            enableCustomerFormFields();
            custModifyBtn.Enabled=false;
            custSaveBtn.Enabled = true;
        }

        private void custCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

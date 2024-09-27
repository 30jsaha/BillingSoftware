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
    public partial class Form1 : Form
    {
        
        public string mType;
        public Form1()
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
        private void itemSaveBtn_Click(object sender, EventArgs e)
        {
            // Perform validation checks before executing the insert
            if (string.IsNullOrWhiteSpace(item_name.Text))
            {
                MessageBox.Show("Item Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (item_unit_select.SelectedItem == null)
            {
                MessageBox.Show("Please select an Item Unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(item_selling_price.Text))
            {
                MessageBox.Show("Item Selling Price cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // if (item_account_select.SelectedItem == null)
            // {
            //     MessageBox.Show("Please select an Item Account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return;
            // }

            //if (string.IsNullOrWhiteSpace(item_description.Text))
            //{
            //    MessageBox.Show("Item Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             //   return;
            //}

            if (!item_type_goods.Checked && !item_type_service.Checked)
            {
                MessageBox.Show("Please select the Item Type (Goods or Service).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If validation passes, proceed to save data
            string mType = item_type_goods.Checked ? "goods" : "service";

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    var mSql = "insert into item_master (item_type,item_name, item_unit, item_selling_price, item_account, item_description) values(@item_type, @item_name, @item_unit, @item_selling_price, @item_account, @item_description)";
                    SqlCommand cmd = new SqlCommand(mSql, connection);

                    cmd.Parameters.AddWithValue("@item_type", mType);
                    cmd.Parameters.AddWithValue("@item_name", item_name.Text);
                    cmd.Parameters.AddWithValue("@item_unit", item_unit_select.SelectedItem);
                    cmd.Parameters.AddWithValue("@item_selling_price", item_selling_price.Text);
                    cmd.Parameters.AddWithValue("@item_account", item_account_select.Text);
                    cmd.Parameters.AddWithValue("@item_description", item_description.Text);

                    cmd.ExecuteNonQuery();
                }

                // Clear fields after successful save
                item_name.Clear();
                item_unit_select.SelectedIndex = -1;
                item_selling_price.Clear();
                item_account_select.SelectedIndex = -1;
                item_description.Clear();
                item_type_goods.Checked = false;
                item_type_service.Checked = false;

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



        private void Item_type_goods_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("successfully Clicked"+sender);
        }

        private void item_type_goods_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'itemMasterListViewDataSet.item_master' table. You can move, or remove it, as needed.
            //this.item_masterTableAdapter1.Fill(this.itemMasterListViewDataSet.item_master);
            //// TODO: This line of code loads data into the 'itemMasterListViewDataSet.account_master' table. You can move, or remove it, as needed.
            //this.account_masterTableAdapter2.Fill(this.itemMasterListViewDataSet.account_master);
            //// TODO: This line of code loads data into the 'billingFormDataDataSet2.account_master' table. You can move, or remove it, as needed.
            //this.account_masterTableAdapter1.Fill(this.billingFormDataDataSet2.account_master);
            //// TODO: This line of code loads data into the 'billingFormDataDataSet1.account_master' table. You can move, or remove it, as needed.
            //this.account_masterTableAdapter.Fill(this.billingFormDataDataSet1.account_master);
            //// TODO: This line of code loads data into the 'billingFormDataDataSet.item_master' table. You can move, or remove it, as needed.
            //this.item_masterTableAdapter.Fill(this.billingFormDataDataSet.item_master);
            LoadData();
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
                            im.id AS ItemID, 
                            im.item_type AS ItemType, 
                            im.item_name AS ItemName, 
                            im.item_unit AS ItemUnit, 
                            im.item_selling_price AS SellingPrice, 
                            im.item_account AS AccountID, 
                            im.item_description AS Description, 
                            am.account_name AS AccountName
                        FROM dbo.item_master AS im
                        JOIN dbo.account_master AS am
                            ON im.item_account = am.id
                        WHERE im.status = 'A'";

                    // Execute the query and fill the data into a DataTable
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;

                    // (Optional) Set custom column header text in the DataGridView
                    dataGridView1.Columns["ItemID"].HeaderText = "Item ID";
                    dataGridView1.Columns["ItemType"].HeaderText = "Type";
                    dataGridView1.Columns["ItemName"].HeaderText = "Name";
                    dataGridView1.Columns["ItemUnit"].HeaderText = "Unit";
                    dataGridView1.Columns["SellingPrice"].HeaderText = "Price";
                    dataGridView1.Columns["AccountName"].HeaderText = "Account Name";
                    dataGridView1.Columns["Description"].HeaderText = "Description";
                    dataGridView1.Columns["AccountID"].HeaderText = "Account ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index is valid
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return; // Ignore if row index is out of bounds

            //MessageBox.Show("CellEndEdit event triggered!");
            // Get the edited row's data
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Fetch the column indices using DataPropertyName
            int itemTypeIndex = FindColumnIndexByPropertyName("item_type");
            int itemNameIndex = FindColumnIndexByPropertyName("item_name");
            int itemUnitIndex = FindColumnIndexByPropertyName("item_unit");
            int itemSellingPriceIndex = FindColumnIndexByPropertyName("item_selling_price");
            int itemAccountIndex = FindColumnIndexByPropertyName("item_account");
            int itemDescriptionIndex = FindColumnIndexByPropertyName("item_description");
            int itemIdIndex = FindColumnIndexByPropertyName("id");

            if (itemTypeIndex >= 0 && itemNameIndex >= 0 && itemUnitIndex >= 0 &&
            itemSellingPriceIndex >= 0 && itemAccountIndex >= 0 && itemDescriptionIndex >= 0)
            {
               // Check if expected columns exist using DataPropertyName
                bool hasRequiredColumns = true;
                string[] requiredColumns = { "item_type", "item_name", "item_unit", "item_selling_price", "item_account", "item_description", "id" };

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
                    string itemType = row.Cells[itemTypeIndex].Value?.ToString();
                    string itemName = row.Cells[itemNameIndex].Value?.ToString();
                    string itemUnit = row.Cells[itemUnitIndex].Value?.ToString();
                    string itemSellingPrice = row.Cells[itemSellingPriceIndex].Value?.ToString();
                    string itemAccount = row.Cells[itemAccountIndex].Value?.ToString();
                    string itemDescription = row.Cells[itemDescriptionIndex].Value?.ToString();

                    // Assuming the ID is part of the data bound properties
                    int itemId = Convert.ToInt32(row.Cells[itemIdIndex].Value); // Adjust if DataPropertyName is different

                    // Validate the inputs before proceeding
                    if (ValidateInputs(itemType, itemName, itemUnit, itemSellingPrice, itemAccount, itemDescription))
                    {
                        // Update the database with the edited values if validation passes
                        UpdateDatabase(itemId, itemType, itemName, itemUnit, itemSellingPrice, itemAccount, itemDescription);
                    }
                    else
                    {
                        MessageBox.Show("Please ensure all fields are filled in correctly before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("One or more expected columns do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Validate Inputs: Method to check if fields are not empty
        private bool ValidateInputs(string itemType, string itemName, string itemUnit, string itemSellingPrice, string itemAccount, string itemDescription)
        {
            // Check for empty or null values in the required fields
            if (string.IsNullOrWhiteSpace(itemType))
            {
                MessageBox.Show("Item Type cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Item Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(itemUnit))
            {
                MessageBox.Show("Item Unit cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(itemSellingPrice) || !decimal.TryParse(itemSellingPrice, out decimal price))
            {
                MessageBox.Show("Selling Price must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(itemAccount))
            {
                MessageBox.Show("Item Account cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if (string.IsNullOrWhiteSpace(itemDescription))
            //{
            //    MessageBox.Show("Item Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }

        // Method to update the edited data into the database
        private void UpdateDatabase(int itemId, string itemType, string itemName, string itemUnit, string itemSellingPrice, string itemAccount, string itemDescription)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "UPDATE item_master SET item_type = @item_type, item_name = @item_name, item_unit = @item_unit, " +
                                   "item_selling_price = @item_selling_price, item_account = @item_account, item_description = @item_description " +
                                   "WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@item_type", itemType);
                    cmd.Parameters.AddWithValue("@item_name", itemName);
                    cmd.Parameters.AddWithValue("@item_unit", itemUnit);
                    cmd.Parameters.AddWithValue("@item_selling_price", itemSellingPrice);
                    cmd.Parameters.AddWithValue("@item_account", itemAccount);
                    cmd.Parameters.AddWithValue("@item_description", itemDescription);
                    cmd.Parameters.AddWithValue("@id", itemId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data updated successfully", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // string value = "";
            // value = dataGridView1.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
            // MessageBox.Show("Data in the datagridview: "+ value, "Test Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Ensure the row index is valid
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return; // Ignore if row index is out of bounds

            //MessageBox.Show("CellEndEdit event triggered!");
            // Get the edited row's data
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Fetch the column indices using DataPropertyName
            int itemTypeIndex = FindColumnIndexByPropertyName("ItemType");
            int itemNameIndex = FindColumnIndexByPropertyName("ItemName");
            int itemUnitIndex = FindColumnIndexByPropertyName("ItemUnit");
            int itemSellingPriceIndex = FindColumnIndexByPropertyName("SellingPrice");
            int itemAccountIndex = FindColumnIndexByPropertyName("AccountName");
            int itemDescriptionIndex = FindColumnIndexByPropertyName("Description");
            int itemIdIndex = FindColumnIndexByPropertyName("ItemID");
            int itemAccountIdIndex = FindColumnIndexByPropertyName("AccountID");

            if (itemTypeIndex >= 0 && itemNameIndex >= 0 && itemUnitIndex >= 0 &&
            itemSellingPriceIndex >= 0 && itemAccountIndex >= 0 && itemDescriptionIndex >= 0)
            {
                // Check if expected columns exist using DataPropertyName
                bool hasRequiredColumns = true;
                string[] requiredColumns = { "ItemType", "ItemName", "ItemUnit", "SellingPrice", "AccountName", "Description", "ItemID" };

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
                    string itemType = row.Cells[itemTypeIndex].Value?.ToString();
                    string itemName = row.Cells[itemNameIndex].Value?.ToString();
                    string itemUnit = row.Cells[itemUnitIndex].Value?.ToString();
                    string itemSellingPrice = row.Cells[itemSellingPriceIndex].Value?.ToString();
                    string itemAccount = row.Cells[itemAccountIndex].Value?.ToString();
                    string itemDescription = row.Cells[itemDescriptionIndex].Value?.ToString();

                    // Assuming the ID is part of the data bound properties
                    int itemId = Convert.ToInt32(row.Cells[itemIdIndex].Value); // Adjust if DataPropertyName is different
                    int itemAccountID = Convert.ToInt32(row.Cells[itemAccountIdIndex].Value); // Adjust if DataPropertyName is different

                    item_name.Text = itemName;
                    item_unit_select.Text = itemUnit;
                    item_selling_price.Text = itemSellingPrice;
                    item_account_select.SelectedIndex = itemAccountID;
                    item_description.Text= itemDescription;
                    item_type_goods.Checked = (itemType== "goods") ? true : false;
                    item_type_goods.Checked = (itemType == "service") ? true : false;

                    // Validate the inputs before proceeding
                    //if (ValidateInputs(itemType, itemName, itemUnit, itemSellingPrice, itemAccount, itemDescription))
                    //{
                    //    // Update the database with the edited values if validation passes
                    //    UpdateDatabase(itemId, itemType, itemName, itemUnit, itemSellingPrice, itemAccount, itemDescription);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Please ensure all fields are filled in correctly before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }
            }
            else
            {
                MessageBox.Show("One or more expected columns do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.account_masterTableAdapter2.FillBy(this.itemMasterListViewDataSet.account_master);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getAccountDataForItemsSaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.account_masterTableAdapter2.getAccountDataForItemsSave(this.itemMasterListViewDataSet.account_master);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

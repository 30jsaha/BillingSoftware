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
    public partial class Form3 : Form
    {
        public int cust_id=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
            customerModifyBtn.Enabled=false;
            custRemoveBtn.Enabled=false;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerModifyBtn.Enabled=true;
            custRemoveBtn.Enabled=true;
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return; // Ignore if row index is out of bounds

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int customerIdIndex = FindColumnIndexByPropertyName("cid");
            int customerId = Convert.ToInt32(row.Cells[customerIdIndex].Value);
            cust_id=customerId;
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                {
                    // SQL query
                    string query = @"
                                SELECT 
                                    cust.id AS cid,
                                    cust.customer_name AS cname,
                                    cust.customer_email AS cemail,
                                    cust.customer_phone AS cphone,
                                    cust.customer_type AS ctype,
                                    cust.company_name AS comnm,
                                    cust.customer_city AS ccity,
                                    cust.customer_state AS cstate,
                                    cust.customer_pincode AS cpcode,
                                    cust.customer_address AS caddr,
                                    cur.currency_name,
                                    cur.currency_details,
                                    cust.created_at
                                FROM dbo.customer_master AS cust
                                LEFT JOIN dbo.currency_master AS cur
                                    ON cust.currency_id = cur.id
                                WHERE cust.status = 'A'";

                    // Execute the query and fill the data into a DataTable
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;

                    // (Optional) Set custom column header text in the DataGridView
                    dataGridView1.Columns["cname"].HeaderText = "Name";
                    dataGridView1.Columns["cemail"].HeaderText = "Email";
                    dataGridView1.Columns["cphone"].HeaderText = "Primary Contact";
                    dataGridView1.Columns["ctype"].HeaderText = "Cust. Type";
                    dataGridView1.Columns["comnm"].HeaderText = "Company Name";
                    dataGridView1.Columns["ccity"].HeaderText = "City";
                    dataGridView1.Columns["cstate"].HeaderText = "State";
                    dataGridView1.Columns["cpcode"].HeaderText = "Pincode";
                    dataGridView1.Columns["caddr"].HeaderText = "Address";
                    dataGridView1.Columns["created_at"].HeaderText = "Date";
                    dataGridView1.Columns["currency_name"].HeaderText = "Currency";
                    dataGridView1.Columns["cid"].Visible = false;
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ctype")
            {
                // Check if the cell value is not null and is an integer
                if (e.Value != null && e.Value is int)
                {
                    int customerTypeValue = (int)e.Value; // Cast the value to int

                    if (customerTypeValue == Constants.customerBtype) // Compare with the constant
                    {
                        e.Value = "Business"; // Set the cell value to "Business"
                    }
                    else
                    {
                        e.Value = "Individual"; // Set the cell value to "Individual"
                    }

                    e.FormattingApplied = true; // Mark the formatting as applied
                }
            }
        }

        private void customerAddNewBtn_Click(object sender, EventArgs e)
        {
            customerModifyBtn.Enabled=false;
            custRemoveBtn.Enabled=false;
            cust_id=0;
            Form f = Application.OpenForms["Form4"]; // Get an open instance of Form4
            if (f == null) // If the form is not already open, create a new instance
            {
                f = new Form4(); // Form4 is the class name of the form
            }

            ((Form4)f).customerId = cust_id;

            f.ShowDialog(this); // Show the form as a modal dialog
        }

        private void customerModifyBtn_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form4"]; // Get an open instance of Form4
            if (f == null) // If the form is not already open, create a new instance
            {
                f = new Form4(); // Form4 is the class name of the form
            }

            ((Form4)f).customerId = cust_id;

            f.ShowDialog(this); // Show the form as a modal dialog
        }

        private void customerCancelBtn_Click(object sender, EventArgs e)
        {
            cust_id=0;
            this.Close();
        }
    }
}

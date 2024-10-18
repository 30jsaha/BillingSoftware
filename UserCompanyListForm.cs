using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillingSoftware
{
    public partial class UserCompanyListForm : Form
    {
        public UserCompanyListForm()
        {
            InitializeComponent();
            LoadCompanyDetails();
        }
        private void LoadCompanyDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                {
                    string sql = @"SELECT cm.[company_id], cm.[company_name], cm.[company_country], 
                                        cm.[company_state], cm.[fiscal_year_start_date], 
                                        cm.[fiscal_year_end_date], cm.[company_industry_type], 
                                        cm.[status], cm.[created_at], cur.[currency_name]
                                FROM [" + Constants.dbName + @"].[dbo].[company_master] cm
                                JOIN [billingFormData].[dbo].[currency_master] cur
                                ON cm.currency_id = cur.id
                                WHERE cm.company_id = @company_id";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@company_id", Constants.selectedCompanyId);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // companyIdTextBox.Text = reader["company_id"].ToString();
                            UserCompanyListcompanyName.Text = reader["company_name"].ToString();
                            UserCompanyListcompanyCountry.Text = reader["company_country"].ToString();
                            UserCompanyListcompanyState.Text = reader["company_state"].ToString();
                            UserCompanyListcompanyCurrency.Text = reader["currency_name"].ToString();  // Now display the currency name
                            UserCompanyListcomFiscalYrStDate.Text = reader["fiscal_year_start_date"].ToString();
                            UserCompanyListcomFiscalYrEndDate.Text = reader["fiscal_year_end_date"].ToString();
                            UserCompanyListcompanyIndustryType.Text = reader["company_industry_type"].ToString();
                            UserCompanyListcompanyCreateDate.Text = reader["created_at"].ToString();

                            UserCompanyListcompanyName.Enabled = false;
                            UserCompanyListcompanyCountry.Enabled = false;
                            UserCompanyListcompanyState.Enabled = false;
                            UserCompanyListcompanyCurrency.Enabled = false;
                            UserCompanyListcomFiscalYrStDate.Enabled = false;
                            UserCompanyListcomFiscalYrEndDate.Enabled = false;
                            UserCompanyListcompanyIndustryType.Enabled = false;
                            UserCompanyListcompanyCreateDate.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No company details found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading company details: {ex.Message}");
            }
        }
    }
}

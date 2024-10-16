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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingFormDataDataSet3.currency_master' table. You can move, or remove it, as needed.
            this.currency_masterTableAdapter.Fill(this.billingFormDataDataSet3.currency_master);

        }

        private void companyExitBtn_Click(object sender, EventArgs e)
        {
            if (
                (string.IsNullOrWhiteSpace(companyName.Text))&&
                (string.IsNullOrWhiteSpace(companyCountry.Text)) &&
                (string.IsNullOrWhiteSpace(companyState.Text)) &&
                (string.IsNullOrWhiteSpace(companyIndustryType.Text))
            )
            {
                clearCompanyFormFields();
                this.Close();
            }
            else
            {
                DialogResult closeConf = MessageBox.Show("Are you sure you want to exit ?", "Exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (closeConf==DialogResult.Yes)
                {
                    clearCompanyFormFields();
                    this.Close();
                }
            }
        }
        private void clearCompanyFormFields()
        {
            companyName.Clear();
            companyCountry.Clear();
            companyState.Clear();
            companyIndustryType.Clear();
            companyCurrency.SelectedIndex = 0;
            comFiscalYrStDate.Value = DateTime.Now;
            comFiscalYrEndDate.Value = DateTime.Now;
            comUserId.Clear();
            comUserPassword.Clear();
        }
        // The simple version without creating the database
        // private void companySaveBtn_Click(object sender, EventArgs e)
        // {
        //     if (string.IsNullOrWhiteSpace(companyName.Text))
        //     {
        //         MessageBox.Show("Name cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //         companyName.Focus();
        //         return;
        //     }
        //     if (string.IsNullOrWhiteSpace(companyCountry.Text))
        //     {
        //         MessageBox.Show("Country cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //         companyCountry.Focus();
        //         return;
        //     }
        //     if (string.IsNullOrWhiteSpace(companyState.Text))
        //     {
        //         MessageBox.Show("State cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //         companyState.Focus();
        //         return;
        //     }
        //     if (companyCurrency.SelectedItem==null)
        //     {
        //         MessageBox.Show("Currency must be selected", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //         companyCurrency.Focus();
        //         return;
        //     }
        //     if (string.IsNullOrWhiteSpace(comFiscalYrStDate.Text))
        //     {
        //         MessageBox.Show("Fiscal Year start date cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //         comFiscalYrStDate.Focus();
        //         return;
        //     }
        //     if (string.IsNullOrWhiteSpace(comFiscalYrEndDate.Text))
        //     {
        //         MessageBox.Show("Fiscal Year start date cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //         comFiscalYrEndDate.Focus();
        //         return;
        //     }

        //     try
        //     {
        //         using (SqlConnection conn = new SqlConnection(dbConnection.GetConnectionString()))
        //         {
        //             conn.Open();
        //             var msql = "insert into company_master (company_name, company_country, company_state, currency_id, fiscal_year_start_date, " +
        //                 "fiscal_year_end_date, company_industry_type, status, created_at) " +
        //                 "values(@company_name, @company_country, @company_state, @currency_id, @fiscal_year_start_date, " +
        //                 "@fiscal_year_end_date, @company_industry_type, @status, @created_at)";
        //             SqlCommand cmd = new SqlCommand(msql, conn);
        //             cmd.Parameters.AddWithValue("@company_name", companyName.Text);
        //             cmd.Parameters.AddWithValue("@company_country", companyCountry.Text);
        //             cmd.Parameters.AddWithValue("@company_state", companyState.Text);
        //             cmd.Parameters.AddWithValue("@currency_id", companyCurrency.SelectedValue);
        //             cmd.Parameters.AddWithValue("@fiscal_year_start_date", comFiscalYrStDate.Value);
        //             cmd.Parameters.AddWithValue("@fiscal_year_end_date", comFiscalYrEndDate.Value);
        //             cmd.Parameters.AddWithValue("@company_industry_type", companyIndustryType.Text);
        //             cmd.Parameters.AddWithValue("@status", 'A');
        //             cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
        //             cmd.ExecuteNonQuery();
        //         }
        //         MessageBox.Show("Data Inserted Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //         clearCompanyFormFields();
        //         this.Close();
        //         return;
                
        //     }
        //     catch (System.Exception ex)
        //     {
        //         MessageBox.Show($"Error Saving Data: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //         throw;
        //     }
        // }

        private async void companySaveBtn_Click(object sender, EventArgs e)
        {
            // form validation logic...
            if (string.IsNullOrWhiteSpace(companyName.Text))
            {
                MessageBox.Show("Name cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                companyName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(companyCountry.Text))
            {
                MessageBox.Show("Country cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                companyCountry.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(companyState.Text))
            {
                MessageBox.Show("State cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                companyState.Focus();
                return;
            }
            if (companyCurrency.SelectedItem == null)
            {
                MessageBox.Show("Currency must be selected", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                companyCurrency.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(comFiscalYrStDate.Text))
            {
                MessageBox.Show("Fiscal Year start date cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comFiscalYrStDate.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(comFiscalYrEndDate.Text))
            {
                MessageBox.Show("Fiscal Year end date cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comFiscalYrEndDate.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(comUserId.Text))
            {
                MessageBox.Show("Admin user id cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comUserId.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(comUserPassword.Text))
            {
                MessageBox.Show("Admin Password cannot be empty", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comUserPassword.Focus();
                return;
            }

            // Extract year from fiscal start and end dates
            string fiscalStartYear = comFiscalYrStDate.Value.Year.ToString();
            string fiscalEndYear = comFiscalYrEndDate.Value.Year.ToString();

            // Check if the fiscal start and end years are the same
            if (fiscalStartYear == fiscalEndYear)
            {
                MessageBox.Show("Fiscal start year and end year cannot be the same!", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comFiscalYrStDate.Focus();
                return;
            }

            // Show loader form
            LoaderForm loader = new LoaderForm();
            loader.Show();

            try
            {
                // Run the long-running task asynchronously
                await Task.Run(() =>
                {
                    // Since we're in a background thread, we must use Invoke to safely access the UI elements
                    int companyId = 0;
                    int userLastInsertedID = 0;
                    string companyNameText = "";
                    string companyCountryText = "";
                    string companyStateText = "";
                    object companyCurrencyValue = null;
                    DateTime fiscalYearStartDate = DateTime.MinValue;
                    DateTime fiscalYearEndDate = DateTime.MinValue;
                    string comUserIdText = "";
                    string comUserPasswordText = "";

                    // Access UI controls using Invoke
                    Invoke(new Action(() =>
                    {
                        companyNameText = companyName.Text;
                        companyCountryText = companyCountry.Text;
                        companyStateText = companyState.Text;
                        companyCurrencyValue = companyCurrency.SelectedValue;
                        fiscalYearStartDate = comFiscalYrStDate.Value;
                        fiscalYearEndDate = comFiscalYrEndDate.Value;
                        comUserIdText = comUserId.Text;
                        comUserPasswordText = comUserPassword.Text;
                    }));

                    // string companyDbName = $"accountsData_{companyNameText.Replace(" ", "_")}_{fiscalStartYear}_{fiscalEndYear}";
                    string companyDbName = $"accountsData_{companyNameText.Replace(" ", "_")}";

                    using (SqlConnection commonConnection = new SqlConnection(dbConnection.GetCommonDBConnectionString()))
                    {
                        commonConnection.Open();

                        // Check if database with the same name exists
                        var checkDbSql = $"SELECT database_id FROM sys.databases WHERE Name = '{companyDbName}'";
                        SqlCommand checkCmd = new SqlCommand(checkDbSql, commonConnection);
                        var dbExists = checkCmd.ExecuteScalar();

                        if (dbExists != null)
                        {
                            throw new Exception("Database with the same name already exists!");
                        }

                        //get company id
                        // Using ExecuteScalar for single value query
                        var getComIdSql = $"SELECT TOP 1 company_id FROM company_data ORDER BY company_id DESC";
                        SqlCommand getComId = new SqlCommand(getComIdSql, commonConnection);

                        var commonComData = getComId.ExecuteScalar(); 

                        // Make sure to handle null values or convert them to the correct type
                        companyId = (commonComData != null) ? (Convert.ToInt32(commonComData)+1) : Constants.companyStartId;

                        var setCompCommonDbEntrySql = "INSERT INTO company_data (company_id, company_name, full_database_name, active, status, creation_date) " +
                        "VALUES (@company_id, @company_name, @full_database_name, @active, @status, @creation_date)";
                        SqlCommand setCompCommDbEntry = new SqlCommand(setCompCommonDbEntrySql, commonConnection);
                        setCompCommDbEntry.Parameters.AddWithValue("@company_id", companyId);
                        setCompCommDbEntry.Parameters.AddWithValue("@company_name", companyNameText);
                        setCompCommDbEntry.Parameters.AddWithValue("@full_database_name", companyDbName);
                        setCompCommDbEntry.Parameters.AddWithValue("@active", 1);
                        setCompCommDbEntry.Parameters.AddWithValue("@status", 'A');
                        setCompCommDbEntry.Parameters.AddWithValue("@creation_date", DateTime.Now);
                        setCompCommDbEntry.ExecuteNonQuery();
                        commonConnection.Close();
                    }

                    using (SqlConnection conn = new SqlConnection(dbConnection.GetConnectionString()))
                    {
                        conn.Open();

                        // Create the new database
                        var createDbSql = $"CREATE DATABASE [{companyDbName}]";
                        SqlCommand createDbCmd = new SqlCommand(createDbSql, conn);
                        createDbCmd.ExecuteNonQuery();

                        // Clone the sample database 'billingFormData' to the newly created database (only structure)
                        var cloneDbSql = $@"
                            DECLARE @sql NVARCHAR(MAX) = N'';
                            SELECT @sql += 'SELECT * INTO [{companyDbName}].dbo.' + QUOTENAME(TABLE_NAME) + ' FROM [billingFormData].dbo.' + QUOTENAME(TABLE_NAME) + ' WHERE 1 = 0;' 
                            FROM [billingFormData].INFORMATION_SCHEMA.TABLES 
                            WHERE TABLE_TYPE = 'BASE TABLE';
                            EXEC sp_executesql @sql;";
                        
                        SqlCommand cloneDbCmd = new SqlCommand(cloneDbSql, conn);
                        cloneDbCmd.ExecuteNonQuery();

                        

                        // Insert company details into company_master table
                        var msql = "USE "+companyDbName+";"+
                            "INSERT INTO company_master (company_id, company_name, company_country, company_state, currency_id, fiscal_year_start_date, " +
                            "fiscal_year_end_date, company_industry_type, status, created_at) " +
                            "VALUES(@company_id, @company_name, @company_country, @company_state, @currency_id, @fiscal_year_start_date, " +
                            "@fiscal_year_end_date, @company_industry_type, @status, @created_at)";
                        SqlCommand cmd = new SqlCommand(msql, conn);
                        cmd.Parameters.AddWithValue("@company_id", companyId);
                        cmd.Parameters.AddWithValue("@company_name", companyNameText);
                        cmd.Parameters.AddWithValue("@company_country", companyCountryText);
                        cmd.Parameters.AddWithValue("@company_state", companyStateText);
                        cmd.Parameters.AddWithValue("@currency_id", companyCurrencyValue);
                        cmd.Parameters.AddWithValue("@fiscal_year_start_date", fiscalYearStartDate);
                        cmd.Parameters.AddWithValue("@fiscal_year_end_date", fiscalYearEndDate);
                        cmd.Parameters.AddWithValue("@company_industry_type", companyIndustryType.Text);
                        cmd.Parameters.AddWithValue("@status", 'A');
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        
                        var userSql = "USE "+companyDbName+";"+
                        "INSERT INTO user_data (user_type, user_id, password, active, status, created_at) " +
                        "VALUES (@user_type, @user_id, @password, @active, @status, @created_at)";
                        SqlCommand setUserData = new SqlCommand(userSql, conn);
                        setUserData.Parameters.AddWithValue("@user_type", Constants.ADMIN);
                        setUserData.Parameters.AddWithValue("@user_id", comUserIdText);
                        setUserData.Parameters.AddWithValue("@password", comUserPasswordText);
                        setUserData.Parameters.AddWithValue("@active", 1);
                        setUserData.Parameters.AddWithValue("@status", 'A');
                        setUserData.Parameters.AddWithValue("@created_at", DateTime.Now);
                        setUserData.ExecuteNonQuery();
                        var getLstUserTabId = "USE "+companyDbName+";"+
                        "SELECT IDENT_CURRENT('user_data')";
                        SqlCommand lastId = new SqlCommand(getLstUserTabId, conn);
                        var getLastId = lastId.ExecuteScalar();
                        userLastInsertedID = (getLastId != null) ? (Convert.ToInt32(getLastId)) : 0;
                    }

                    using (SqlConnection commonConnection = new SqlConnection(dbConnection.GetCommonDBConnectionString()))
                    {
                        commonConnection.Open();
                        if (userLastInsertedID != 0)
                        {
                            var fSql = "INSERT INTO user_data (user_id, company_id, user_type, full_database_name, login_user_id, login_password)"+
                            " VALUES (@user_id, @company_id, @user_type, @full_database_name, @login_user_id, @login_password)";
                            SqlCommand setUserCommDbEntry = new SqlCommand(fSql, commonConnection);
                            setUserCommDbEntry.Parameters.AddWithValue("@user_id", userLastInsertedID);
                            setUserCommDbEntry.Parameters.AddWithValue("@company_id", companyId);
                            setUserCommDbEntry.Parameters.AddWithValue("@user_type", Constants.ADMIN);
                            setUserCommDbEntry.Parameters.AddWithValue("@full_database_name", companyDbName);
                            setUserCommDbEntry.Parameters.AddWithValue("@login_user_id", comUserIdText);
                            setUserCommDbEntry.Parameters.AddWithValue("@login_password", comUserPasswordText);
                            setUserCommDbEntry.ExecuteNonQuery();
                        }

                    }

                });

                MessageBox.Show($"Data Inserted Successfully and Database Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Saving Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the loader form when the task is done
                loader.Close();
            }

            clearCompanyFormFields();
            this.Close();
        }

    }
}

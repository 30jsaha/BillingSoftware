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
    public partial class AppLoginForm : Form
    {
        public AppLoginForm()
        {
            InitializeComponent();
        }

        private void AppLoginForm_Load(object sender, EventArgs e)
        {
            DataTable rstData = new DataTable();
            
            using (SqlConnection connection = new SqlConnection(dbConnection.GetCommonDBConnectionString()))
            {
                var cSql = @"SELECT [id], [company_id], [company_name] 
                            FROM [accountsGeneralData].[dbo].[company_data]
                            WHERE active = @active 
                            AND status = @status";
                
                using (SqlCommand checkLoginData = new SqlCommand(cSql, connection))
                {
                    checkLoginData.Parameters.AddWithValue("@active", 1);
                    checkLoginData.Parameters.AddWithValue("@status", 'A');
                    
                    connection.Open();
                    rstData.Load(checkLoginData.ExecuteReader());
                    
                    // Bind the data to the ComboBox
                    loginCompanySelect.DataSource = rstData;
                    loginCompanySelect.DisplayMember = "company_name"; // Column to display
                    loginCompanySelect.ValueMember = "company_id"; // Column to use as value
                    
                    // Add a blank selection option at the top
                    loginCompanySelect.SelectedIndex = 0; // Set no initial selection
                }
            }
        }


        private void appLoginExitBtn_Click(object sender, EventArgs e)
        {
            // this.Close();
            // if (!Constants.isLoggedIn)
            // {
            //     ShowbeginningForm();
            // }
            Application.Exit();
        }
        private void ShowbeginningForm()
        {
            // Check if the form is already open
            Form existingForm = Application.OpenForms["beginningForm"];

            if (existingForm == null)  // If form doesn't exist, create a new one
            {
                beginningForm beginning_form = new beginningForm();
                //beginning_form.MdiParent = this;  // Set as child of MDI parent if this is an MDI form
                beginning_form.Show();
            }
            else
            {
                // Minimize all other open forms except the one being brought to the front
                foreach (Form form in this.MdiChildren)
                {
                    if (form != existingForm)
                    {
                        form.WindowState = FormWindowState.Minimized;
                    }
                }

                // Bring the existing form to the front and restore it if it was minimized
                existingForm.WindowState = FormWindowState.Normal;
                existingForm.BringToFront();
            }
        }

        private void appLoginCancelBtn_Click(object sender, EventArgs e)
        {
            appLoginUserIdInpt.Clear();
            appLoginPwdInpt.Clear();
        }

        private void appLoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(appLoginUserIdInpt.Text))
            {
                MessageBox.Show("User id cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                appLoginUserIdInpt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(appLoginPwdInpt.Text))
            {
                MessageBox.Show("User password cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                appLoginPwdInpt.Focus();
                return;
            }
            if (loginCompanySelect.SelectedItem == null)
            {
                MessageBox.Show("A company must be selected !", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loginCompanySelect.Focus();
                return;
            }

            // Display loader
            LoaderForm loader = new LoaderForm();
            loader.Show();

            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection.GetCommonDBConnectionString()))
                {
                    connection.Open();

                    // Check if user id is already logged in
                    var checkAlreadyLoggedinSql = "SELECT is_logged_in FROM [accountsGeneralData].[dbo].[user_data] WHERE is_logged_in = 1";
                    SqlCommand checkAlreadyLogged = new SqlCommand(checkAlreadyLoggedinSql, connection);
                    var alreadyLogged = checkAlreadyLogged.ExecuteScalar();

                    if (alreadyLogged != null)
                    {
                        // Log out the previously logged-in user if exists
                        var LoggedOutSql = @"UPDATE [accountsGeneralData].[dbo].[user_data] 
                                            SET is_logged_in = @is_logged_in, last_logged_out = @last_logged_out 
                                            WHERE is_logged_in = 1";
                        SqlCommand LoggedOutExe = new SqlCommand(LoggedOutSql, connection);
                        LoggedOutExe.Parameters.AddWithValue("@is_logged_in", 0);
                        LoggedOutExe.Parameters.AddWithValue("@last_logged_out", DateTime.Now);
                        LoggedOutExe.ExecuteNonQuery();
                    }

                    // Check login data
                    var checkLoginDataSql = @"SELECT * FROM [accountsGeneralData].[dbo].[user_data] 
                                            WHERE login_user_id = @login_user_id 
                                            AND login_password = @login_password 
                                            AND company_id = @company_id
                                            AND status = @status";
                    SqlCommand checkLoginData = new SqlCommand(checkLoginDataSql, connection);
                    checkLoginData.Parameters.AddWithValue("@login_user_id", appLoginUserIdInpt.Text);
                    checkLoginData.Parameters.AddWithValue("@login_password", appLoginPwdInpt.Text);
                    checkLoginData.Parameters.AddWithValue("@company_id", loginCompanySelect.SelectedValue);
                    checkLoginData.Parameters.AddWithValue("@status", 'A');

                    using (SqlDataReader reader = checkLoginData.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Retrieve and store relevant data
                                var userId = reader["user_id"];
                                var rowId = reader["id"];
                                var companyId = reader["company_id"];
                                var userType = reader["user_type"];
                                var fullDatabaseName = reader["full_database_name"];
                                var userActive = reader["active"];

                                if (Convert.ToInt32(userActive) != 1)
                                {
                                    MessageBox.Show("User currently inactive!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    loader.Close();
                                    return;
                                }

                                // Set global constants for user and company data
                                Constants.dbName = fullDatabaseName.ToString();
                                Constants.selectedCompanyId = Convert.ToInt32(companyId);
                                Constants.LoggedInUserId = Convert.ToInt32(userId);
                                Constants.LoggedInUserType = Convert.ToInt32(userType);
                                Constants.isLoggedIn = true;

                                // Close reader before executing another query
                                reader.Close();

                                // Update user login status
                                var setLoggedInSql = @"UPDATE [accountsGeneralData].[dbo].[user_data] 
                                                    SET is_logged_in = @is_logged_in, 
                                                    last_logged_in = @last_logged_in 
                                                    WHERE id = @id";
                                SqlCommand setLoggedIn = new SqlCommand(setLoggedInSql, connection);
                                setLoggedIn.Parameters.AddWithValue("@is_logged_in", 1);
                                setLoggedIn.Parameters.AddWithValue("@last_logged_in", DateTime.Now);
                                setLoggedIn.Parameters.AddWithValue("@id", rowId);
                                setLoggedIn.ExecuteNonQuery();

                                break;  // Break loop after successful login
                            }
                            // Reference the MDI parent form
                            // MDIParent1 mdiParent = (MDIParent1)this.MdiParent;
                            // if (mdiParent != null)
                            // {
                            //     // Enable the menu items
                            //     mdiParent.accountsToolStripMenuItem.Enabled = true;
                            //     mdiParent.itemsToolStripMenuItem.Enabled = true;
                            //     mdiParent.customerToolStripMenuItem.Enabled = true;
                            //     mdiParent.vendorToolStripMenuItem.Enabled = true;
                            //     mdiParent.currencyToolStripMenuItem.Enabled = true;

                            //     // Change the login menu item text to 'Exit'
                            //     mdiParent.loginToolStripMenuItem.Enabled = true;
                            //     mdiParent.loginToolStripMenuItem.Text = "Exit";
                            // }
                            MDIParent1 parentForm = (MDIParent1)this.MdiParent;

                            // parentForm.masterToolStripMenuItem.Enabled = true;
                            // parentForm.transactionToolStripMenuItem.Enabled = true;
                            // parentForm.reportToolStripMenuItem.Enabled = true;
                            // parentForm.utilityToolStripMenuItem.Enabled = true;
                            parentForm.accountsToolStripMenuItem.Enabled = true;
                            parentForm.itemsToolStripMenuItem.Enabled = true;
                            parentForm.customerToolStripMenuItem.Enabled = true;
                            parentForm.vendorToolStripMenuItem.Enabled = true;
                            parentForm.currencyToolStripMenuItem.Enabled = true;
                            parentForm.loginToolStripMenuItem.Enabled = true;
                            parentForm.loginToolStripMenuItem.Text = "Exit";
                            // MessageBox.Show("Displaying Constants: /n isLoggedIn: " + Constants.isLoggedIn + ", dbName: "+ Constants.dbName);
                            // Close login form and open UserCompanyListForm
                            this.Close();
                            Form LoggedInStatForm = Application.OpenForms["UserCompanyListForm"];

                            if (LoggedInStatForm == null)
                            {
                                UserCompanyListForm userCompanyListForm = new UserCompanyListForm();
                                userCompanyListForm.Show();
                            }
                            else
                            {
                                // Bring existing form to the front if already open
                                LoggedInStatForm.WindowState = FormWindowState.Normal;
                                LoggedInStatForm.BringToFront();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid login credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loader.Close();
                            return;
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loader.Close();  // Close the loader after login process
            }
        }

        private void appCompRegisterBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoaderForm loader = new LoaderForm();
            loader.Show();
            // Check if the form is already open
            Form existingForm = Application.OpenForms["CompanyForm"];

            if (existingForm == null)  // If form doesn't exist, create a new one
            {
                CompanyForm Company_Form = new CompanyForm();
                //Company_Form.MdiParent = this;  // Set as child of MDI parent if this is an MDI form
                Company_Form.Show();
            }
            else
            {
                // Minimize all other open forms except the one being brought to the front
                foreach (Form form in this.MdiChildren)
                {
                    if (form != existingForm)
                    {
                        form.WindowState = FormWindowState.Minimized;
                    }
                }

                // Bring the existing form to the front and restore it if it was minimized
                existingForm.WindowState = FormWindowState.Normal;
                existingForm.BringToFront();
            }
            loader.Close();
        }
    }
}

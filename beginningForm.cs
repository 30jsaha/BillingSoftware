using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class beginningForm : Form
    {
        public beginningForm()
        {
            InitializeComponent();
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

        private void appExitBtn_Click(object sender, EventArgs e)
        {
            MDIParent1 Mdpar = new MDIParent1();
            //Mdpar.Close();
            Application.Exit();
        }

        private void appLoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoaderForm loader = new LoaderForm();
            loader.Show();
            // Check if the form is already open
            Form existingForm = Application.OpenForms["AppLoginForm"];

            if (existingForm == null)  // If form doesn't exist, create a new one
            {
                AppLoginForm Login_Form = new AppLoginForm();
                Login_Form.Show();
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

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
    }
}

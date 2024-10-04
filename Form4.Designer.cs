namespace BillingSoftware
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customerDetailsGbox = new System.Windows.Forms.GroupBox();
            this.custPincode = new System.Windows.Forms.TextBox();
            this.custPincodeLabel = new System.Windows.Forms.Label();
            this.custState = new System.Windows.Forms.TextBox();
            this.custStateLabel = new System.Windows.Forms.Label();
            this.custCity = new System.Windows.Forms.TextBox();
            this.custCityLabel = new System.Windows.Forms.Label();
            this.custAddress = new System.Windows.Forms.RichTextBox();
            this.custAddressLabel = new System.Windows.Forms.Label();
            this.custCurrency = new System.Windows.Forms.ComboBox();
            this.custCurrencyLabel = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.TextBox();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custEmailLabel = new System.Windows.Forms.Label();
            this.custCompName = new System.Windows.Forms.TextBox();
            this.custCompNameLabel = new System.Windows.Forms.Label();
            this.custPrimContact = new System.Windows.Forms.TextBox();
            this.custPrimContactLabel = new System.Windows.Forms.Label();
            this.custType2 = new System.Windows.Forms.RadioButton();
            this.custType1 = new System.Windows.Forms.RadioButton();
            this.customerTypeLabel = new System.Windows.Forms.Label();
            this.custSaveBtn = new System.Windows.Forms.Button();
            this.custModifyBtn = new System.Windows.Forms.Button();
            this.custCancelBtn = new System.Windows.Forms.Button();
            this.customerFormHeading = new System.Windows.Forms.Label();
            this.billingFormDataDataSet3 = new BillingSoftware.billingFormDataDataSet3();
            this.currencymasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currency_masterTableAdapter = new BillingSoftware.billingFormDataDataSet3TableAdapters.currency_masterTableAdapter();
            this.customerDetailsGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencymasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDetailsGbox
            // 
            this.customerDetailsGbox.Controls.Add(this.custPincode);
            this.customerDetailsGbox.Controls.Add(this.custPincodeLabel);
            this.customerDetailsGbox.Controls.Add(this.custState);
            this.customerDetailsGbox.Controls.Add(this.custStateLabel);
            this.customerDetailsGbox.Controls.Add(this.custCity);
            this.customerDetailsGbox.Controls.Add(this.custCityLabel);
            this.customerDetailsGbox.Controls.Add(this.custAddress);
            this.customerDetailsGbox.Controls.Add(this.custAddressLabel);
            this.customerDetailsGbox.Controls.Add(this.custCurrency);
            this.customerDetailsGbox.Controls.Add(this.custCurrencyLabel);
            this.customerDetailsGbox.Controls.Add(this.custName);
            this.customerDetailsGbox.Controls.Add(this.custNameLabel);
            this.customerDetailsGbox.Controls.Add(this.custEmail);
            this.customerDetailsGbox.Controls.Add(this.custEmailLabel);
            this.customerDetailsGbox.Controls.Add(this.custCompName);
            this.customerDetailsGbox.Controls.Add(this.custCompNameLabel);
            this.customerDetailsGbox.Controls.Add(this.custPrimContact);
            this.customerDetailsGbox.Controls.Add(this.custPrimContactLabel);
            this.customerDetailsGbox.Controls.Add(this.custType2);
            this.customerDetailsGbox.Controls.Add(this.custType1);
            this.customerDetailsGbox.Controls.Add(this.customerTypeLabel);
            this.customerDetailsGbox.Location = new System.Drawing.Point(12, 74);
            this.customerDetailsGbox.Name = "customerDetailsGbox";
            this.customerDetailsGbox.Size = new System.Drawing.Size(776, 304);
            this.customerDetailsGbox.TabIndex = 0;
            this.customerDetailsGbox.TabStop = false;
            this.customerDetailsGbox.Text = "Customer Details";
            // 
            // custPincode
            // 
            this.custPincode.AcceptsTab = true;
            this.custPincode.Location = new System.Drawing.Point(482, 155);
            this.custPincode.Name = "custPincode";
            this.custPincode.Size = new System.Drawing.Size(193, 20);
            this.custPincode.TabIndex = 21;
            // 
            // custPincodeLabel
            // 
            this.custPincodeLabel.AutoSize = true;
            this.custPincodeLabel.Location = new System.Drawing.Point(411, 158);
            this.custPincodeLabel.Name = "custPincodeLabel";
            this.custPincodeLabel.Size = new System.Drawing.Size(46, 13);
            this.custPincodeLabel.TabIndex = 20;
            this.custPincodeLabel.Text = "Pincode";
            // 
            // custState
            // 
            this.custState.AcceptsTab = true;
            this.custState.Location = new System.Drawing.Point(482, 107);
            this.custState.Name = "custState";
            this.custState.Size = new System.Drawing.Size(193, 20);
            this.custState.TabIndex = 19;
            // 
            // custStateLabel
            // 
            this.custStateLabel.AutoSize = true;
            this.custStateLabel.Location = new System.Drawing.Point(411, 110);
            this.custStateLabel.Name = "custStateLabel";
            this.custStateLabel.Size = new System.Drawing.Size(32, 13);
            this.custStateLabel.TabIndex = 18;
            this.custStateLabel.Text = "State";
            // 
            // custCity
            // 
            this.custCity.AcceptsTab = true;
            this.custCity.Location = new System.Drawing.Point(482, 59);
            this.custCity.Name = "custCity";
            this.custCity.Size = new System.Drawing.Size(193, 20);
            this.custCity.TabIndex = 17;
            // 
            // custCityLabel
            // 
            this.custCityLabel.AutoSize = true;
            this.custCityLabel.Location = new System.Drawing.Point(411, 62);
            this.custCityLabel.Name = "custCityLabel";
            this.custCityLabel.Size = new System.Drawing.Size(24, 13);
            this.custCityLabel.TabIndex = 16;
            this.custCityLabel.Text = "City";
            // 
            // custAddress
            // 
            this.custAddress.AcceptsTab = true;
            this.custAddress.Location = new System.Drawing.Point(482, 202);
            this.custAddress.Name = "custAddress";
            this.custAddress.Size = new System.Drawing.Size(257, 77);
            this.custAddress.TabIndex = 15;
            this.custAddress.Text = "";
            // 
            // custAddressLabel
            // 
            this.custAddressLabel.AutoSize = true;
            this.custAddressLabel.Location = new System.Drawing.Point(411, 208);
            this.custAddressLabel.Name = "custAddressLabel";
            this.custAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.custAddressLabel.TabIndex = 14;
            this.custAddressLabel.Text = "Address";
            // 
            // custCurrency
            // 
            this.custCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currencymasterBindingSource, "id", true));
            this.custCurrency.DataSource = this.currencymasterBindingSource;
            this.custCurrency.DisplayMember = "currency_name";
            this.custCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custCurrency.FormattingEnabled = true;
            this.custCurrency.Location = new System.Drawing.Point(168, 235);
            this.custCurrency.Name = "custCurrency";
            this.custCurrency.Size = new System.Drawing.Size(193, 21);
            this.custCurrency.TabIndex = 12;
            this.custCurrency.ValueMember = "id";
            this.custCurrency.SelectedIndexChanged += new System.EventHandler(this.custCurrency_SelectedIndexChanged);
            // 
            // custCurrencyLabel
            // 
            this.custCurrencyLabel.AutoSize = true;
            this.custCurrencyLabel.Location = new System.Drawing.Point(18, 238);
            this.custCurrencyLabel.Name = "custCurrencyLabel";
            this.custCurrencyLabel.Size = new System.Drawing.Size(49, 13);
            this.custCurrencyLabel.TabIndex = 11;
            this.custCurrencyLabel.Text = "Currency";
            // 
            // custName
            // 
            this.custName.AcceptsTab = true;
            this.custName.Location = new System.Drawing.Point(168, 63);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(193, 20);
            this.custName.TabIndex = 10;
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(18, 66);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(82, 13);
            this.custNameLabel.TabIndex = 9;
            this.custNameLabel.Text = "Customer Name";
            // 
            // custEmail
            // 
            this.custEmail.AcceptsTab = true;
            this.custEmail.Location = new System.Drawing.Point(168, 190);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(193, 20);
            this.custEmail.TabIndex = 8;
            // 
            // custEmailLabel
            // 
            this.custEmailLabel.AutoSize = true;
            this.custEmailLabel.Location = new System.Drawing.Point(18, 193);
            this.custEmailLabel.Name = "custEmailLabel";
            this.custEmailLabel.Size = new System.Drawing.Size(79, 13);
            this.custEmailLabel.TabIndex = 7;
            this.custEmailLabel.Text = "Customer Email";
            // 
            // custCompName
            // 
            this.custCompName.AcceptsTab = true;
            this.custCompName.Location = new System.Drawing.Point(168, 144);
            this.custCompName.Name = "custCompName";
            this.custCompName.Size = new System.Drawing.Size(193, 20);
            this.custCompName.TabIndex = 6;
            // 
            // custCompNameLabel
            // 
            this.custCompNameLabel.AutoSize = true;
            this.custCompNameLabel.Location = new System.Drawing.Point(18, 147);
            this.custCompNameLabel.Name = "custCompNameLabel";
            this.custCompNameLabel.Size = new System.Drawing.Size(82, 13);
            this.custCompNameLabel.TabIndex = 5;
            this.custCompNameLabel.Text = "Company Name";
            // 
            // custPrimContact
            // 
            this.custPrimContact.AcceptsTab = true;
            this.custPrimContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.custPrimContact.Location = new System.Drawing.Point(168, 101);
            this.custPrimContact.Name = "custPrimContact";
            this.custPrimContact.Size = new System.Drawing.Size(193, 20);
            this.custPrimContact.TabIndex = 4;
            // 
            // custPrimContactLabel
            // 
            this.custPrimContactLabel.AutoSize = true;
            this.custPrimContactLabel.Location = new System.Drawing.Point(18, 104);
            this.custPrimContactLabel.Name = "custPrimContactLabel";
            this.custPrimContactLabel.Size = new System.Drawing.Size(81, 13);
            this.custPrimContactLabel.TabIndex = 3;
            this.custPrimContactLabel.Text = "Primary Contact";
            // 
            // custType2
            // 
            this.custType2.AutoSize = true;
            this.custType2.Location = new System.Drawing.Point(291, 27);
            this.custType2.Name = "custType2";
            this.custType2.Size = new System.Drawing.Size(70, 17);
            this.custType2.TabIndex = 2;
            this.custType2.TabStop = true;
            this.custType2.Text = "Individual";
            this.custType2.UseVisualStyleBackColor = true;
            // 
            // custType1
            // 
            this.custType1.AutoSize = true;
            this.custType1.Location = new System.Drawing.Point(168, 27);
            this.custType1.Name = "custType1";
            this.custType1.Size = new System.Drawing.Size(67, 17);
            this.custType1.TabIndex = 1;
            this.custType1.TabStop = true;
            this.custType1.Text = "Business";
            this.custType1.UseVisualStyleBackColor = true;
            // 
            // customerTypeLabel
            // 
            this.customerTypeLabel.AutoSize = true;
            this.customerTypeLabel.Location = new System.Drawing.Point(18, 28);
            this.customerTypeLabel.Name = "customerTypeLabel";
            this.customerTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.customerTypeLabel.TabIndex = 0;
            this.customerTypeLabel.Text = "Customer Type";
            // 
            // custSaveBtn
            // 
            this.custSaveBtn.Location = new System.Drawing.Point(264, 406);
            this.custSaveBtn.Name = "custSaveBtn";
            this.custSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.custSaveBtn.TabIndex = 1;
            this.custSaveBtn.Text = "Save";
            this.custSaveBtn.UseVisualStyleBackColor = true;
            this.custSaveBtn.Click += new System.EventHandler(this.custSaveBtn_Click);
            // 
            // custModifyBtn
            // 
            this.custModifyBtn.Enabled = false;
            this.custModifyBtn.Location = new System.Drawing.Point(345, 406);
            this.custModifyBtn.Name = "custModifyBtn";
            this.custModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.custModifyBtn.TabIndex = 2;
            this.custModifyBtn.Text = "Modify";
            this.custModifyBtn.UseVisualStyleBackColor = true;
            this.custModifyBtn.Click += new System.EventHandler(this.custModifyBtn_Click);
            // 
            // custCancelBtn
            // 
            this.custCancelBtn.Location = new System.Drawing.Point(426, 406);
            this.custCancelBtn.Name = "custCancelBtn";
            this.custCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.custCancelBtn.TabIndex = 3;
            this.custCancelBtn.Text = "Cancel";
            this.custCancelBtn.UseVisualStyleBackColor = true;
            this.custCancelBtn.Click += new System.EventHandler(this.custCancelBtn_Click);
            // 
            // customerFormHeading
            // 
            this.customerFormHeading.AutoSize = true;
            this.customerFormHeading.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.customerFormHeading.Location = new System.Drawing.Point(12, 9);
            this.customerFormHeading.Name = "customerFormHeading";
            this.customerFormHeading.Size = new System.Drawing.Size(250, 31);
            this.customerFormHeading.TabIndex = 4;
            this.customerFormHeading.Text = "Add New Customer";
            // 
            // billingFormDataDataSet3
            // 
            this.billingFormDataDataSet3.DataSetName = "billingFormDataDataSet3";
            this.billingFormDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencymasterBindingSource
            // 
            this.currencymasterBindingSource.DataMember = "currency_master";
            this.currencymasterBindingSource.DataSource = this.billingFormDataDataSet3;
            // 
            // currency_masterTableAdapter
            // 
            this.currency_masterTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerFormHeading);
            this.Controls.Add(this.custCancelBtn);
            this.Controls.Add(this.custModifyBtn);
            this.Controls.Add(this.custSaveBtn);
            this.Controls.Add(this.customerDetailsGbox);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create / Modify Customer";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.customerDetailsGbox.ResumeLayout(false);
            this.customerDetailsGbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencymasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customerDetailsGbox;
        private System.Windows.Forms.TextBox custPrimContact;
        private System.Windows.Forms.Label custPrimContactLabel;
        private System.Windows.Forms.RadioButton custType2;
        private System.Windows.Forms.RadioButton custType1;
        private System.Windows.Forms.Label customerTypeLabel;
        private System.Windows.Forms.TextBox custCompName;
        private System.Windows.Forms.Label custCompNameLabel;
        private System.Windows.Forms.TextBox custEmail;
        private System.Windows.Forms.Label custEmailLabel;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.ComboBox custCurrency;
        private System.Windows.Forms.Label custCurrencyLabel;
        private System.Windows.Forms.RichTextBox custAddress;
        private System.Windows.Forms.Label custAddressLabel;
        private System.Windows.Forms.Button custSaveBtn;
        private System.Windows.Forms.Button custModifyBtn;
        private System.Windows.Forms.Button custCancelBtn;
        private System.Windows.Forms.Label customerFormHeading;
        private System.Windows.Forms.TextBox custCity;
        private System.Windows.Forms.Label custCityLabel;
        private System.Windows.Forms.TextBox custState;
        private System.Windows.Forms.Label custStateLabel;
        private System.Windows.Forms.TextBox custPincode;
        private System.Windows.Forms.Label custPincodeLabel;
        private billingFormDataDataSet3 billingFormDataDataSet3;
        private System.Windows.Forms.BindingSource currencymasterBindingSource;
        private billingFormDataDataSet3TableAdapters.currency_masterTableAdapter currency_masterTableAdapter;
    }
}
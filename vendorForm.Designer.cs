namespace BillingSoftware
{
    partial class vendorForm
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
            this.ItemFormHeading = new System.Windows.Forms.Label();
            this.vendorFormGroupBox = new System.Windows.Forms.GroupBox();
            this.vendorPincode = new System.Windows.Forms.TextBox();
            this.vendorPincodeLabel = new System.Windows.Forms.Label();
            this.vendorState = new System.Windows.Forms.TextBox();
            this.vendorStateLabel = new System.Windows.Forms.Label();
            this.vendorCity = new System.Windows.Forms.TextBox();
            this.vendorCityLabel = new System.Windows.Forms.Label();
            this.vendorAddress = new System.Windows.Forms.RichTextBox();
            this.vendorAddressLabel = new System.Windows.Forms.Label();
            this.vendorCurrency = new System.Windows.Forms.ComboBox();
            this.vendorCurrencyLabel = new System.Windows.Forms.Label();
            this.vendorEmail = new System.Windows.Forms.TextBox();
            this.vendorEmailLabel = new System.Windows.Forms.Label();
            this.vendor_name = new System.Windows.Forms.TextBox();
            this.item_name_label = new System.Windows.Forms.Label();
            this.vendorPhone = new System.Windows.Forms.TextBox();
            this.vendorPhoneLabel = new System.Windows.Forms.Label();
            this.vendorListGBox = new System.Windows.Forms.GroupBox();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.vendorDeleteBtn = new System.Windows.Forms.Button();
            this.vendorModifyBtn = new System.Windows.Forms.Button();
            this.vendorAddNewBtn = new System.Windows.Forms.Button();
            this.vendorSaveBtn = new System.Windows.Forms.Button();
            this.vendorFormCancelBtn = new System.Windows.Forms.Button();
            this.vendorFormExitBtn = new System.Windows.Forms.Button();
            this.billingFormDataDataSet3 = new BillingSoftware.billingFormDataDataSet3();
            this.currencymasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currency_masterTableAdapter = new BillingSoftware.billingFormDataDataSet3TableAdapters.currency_masterTableAdapter();
            this.vendorFormGroupBox.SuspendLayout();
            this.vendorListGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencymasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemFormHeading
            // 
            this.ItemFormHeading.AutoSize = true;
            this.ItemFormHeading.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ItemFormHeading.Location = new System.Drawing.Point(12, 9);
            this.ItemFormHeading.Name = "ItemFormHeading";
            this.ItemFormHeading.Size = new System.Drawing.Size(221, 31);
            this.ItemFormHeading.TabIndex = 1;
            this.ItemFormHeading.Text = "Manage Vendors";
            // 
            // vendorFormGroupBox
            // 
            this.vendorFormGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.vendorFormGroupBox.Controls.Add(this.vendorPincode);
            this.vendorFormGroupBox.Controls.Add(this.vendorPincodeLabel);
            this.vendorFormGroupBox.Controls.Add(this.vendorState);
            this.vendorFormGroupBox.Controls.Add(this.vendorStateLabel);
            this.vendorFormGroupBox.Controls.Add(this.vendorCity);
            this.vendorFormGroupBox.Controls.Add(this.vendorCityLabel);
            this.vendorFormGroupBox.Controls.Add(this.vendorAddress);
            this.vendorFormGroupBox.Controls.Add(this.vendorAddressLabel);
            this.vendorFormGroupBox.Controls.Add(this.vendorCurrency);
            this.vendorFormGroupBox.Controls.Add(this.vendorCurrencyLabel);
            this.vendorFormGroupBox.Controls.Add(this.vendorEmail);
            this.vendorFormGroupBox.Controls.Add(this.vendorEmailLabel);
            this.vendorFormGroupBox.Controls.Add(this.vendor_name);
            this.vendorFormGroupBox.Controls.Add(this.item_name_label);
            this.vendorFormGroupBox.Controls.Add(this.vendorPhone);
            this.vendorFormGroupBox.Controls.Add(this.vendorPhoneLabel);
            this.vendorFormGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorFormGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorFormGroupBox.Location = new System.Drawing.Point(18, 67);
            this.vendorFormGroupBox.Name = "vendorFormGroupBox";
            this.vendorFormGroupBox.Size = new System.Drawing.Size(648, 405);
            this.vendorFormGroupBox.TabIndex = 17;
            this.vendorFormGroupBox.TabStop = false;
            this.vendorFormGroupBox.Text = "Vendor Details";
            // 
            // vendorPincode
            // 
            this.vendorPincode.AcceptsTab = true;
            this.vendorPincode.Location = new System.Drawing.Point(428, 202);
            this.vendorPincode.Name = "vendorPincode";
            this.vendorPincode.Size = new System.Drawing.Size(193, 23);
            this.vendorPincode.TabIndex = 32;
            // 
            // vendorPincodeLabel
            // 
            this.vendorPincodeLabel.AutoSize = true;
            this.vendorPincodeLabel.Location = new System.Drawing.Point(357, 205);
            this.vendorPincodeLabel.Name = "vendorPincodeLabel";
            this.vendorPincodeLabel.Size = new System.Drawing.Size(54, 17);
            this.vendorPincodeLabel.TabIndex = 31;
            this.vendorPincodeLabel.Text = "Pincode";
            // 
            // vendorState
            // 
            this.vendorState.AcceptsTab = true;
            this.vendorState.Location = new System.Drawing.Point(428, 154);
            this.vendorState.Name = "vendorState";
            this.vendorState.Size = new System.Drawing.Size(193, 23);
            this.vendorState.TabIndex = 30;
            // 
            // vendorStateLabel
            // 
            this.vendorStateLabel.AutoSize = true;
            this.vendorStateLabel.Location = new System.Drawing.Point(357, 157);
            this.vendorStateLabel.Name = "vendorStateLabel";
            this.vendorStateLabel.Size = new System.Drawing.Size(37, 17);
            this.vendorStateLabel.TabIndex = 29;
            this.vendorStateLabel.Text = "State";
            // 
            // vendorCity
            // 
            this.vendorCity.AcceptsTab = true;
            this.vendorCity.Location = new System.Drawing.Point(428, 103);
            this.vendorCity.Name = "vendorCity";
            this.vendorCity.Size = new System.Drawing.Size(193, 23);
            this.vendorCity.TabIndex = 28;
            // 
            // vendorCityLabel
            // 
            this.vendorCityLabel.AutoSize = true;
            this.vendorCityLabel.Location = new System.Drawing.Point(357, 109);
            this.vendorCityLabel.Name = "vendorCityLabel";
            this.vendorCityLabel.Size = new System.Drawing.Size(29, 17);
            this.vendorCityLabel.TabIndex = 27;
            this.vendorCityLabel.Text = "City";
            // 
            // vendorAddress
            // 
            this.vendorAddress.AcceptsTab = true;
            this.vendorAddress.Location = new System.Drawing.Point(428, 249);
            this.vendorAddress.Name = "vendorAddress";
            this.vendorAddress.Size = new System.Drawing.Size(193, 77);
            this.vendorAddress.TabIndex = 26;
            this.vendorAddress.Text = "";
            // 
            // vendorAddressLabel
            // 
            this.vendorAddressLabel.AutoSize = true;
            this.vendorAddressLabel.Location = new System.Drawing.Point(357, 255);
            this.vendorAddressLabel.Name = "vendorAddressLabel";
            this.vendorAddressLabel.Size = new System.Drawing.Size(56, 17);
            this.vendorAddressLabel.TabIndex = 25;
            this.vendorAddressLabel.Text = "Address";
            // 
            // vendorCurrency
            // 
            this.vendorCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currencymasterBindingSource, "id", true));
            this.vendorCurrency.DataSource = this.currencymasterBindingSource;
            this.vendorCurrency.DisplayMember = "currency_name";
            this.vendorCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorCurrency.FormattingEnabled = true;
            this.vendorCurrency.Location = new System.Drawing.Point(135, 237);
            this.vendorCurrency.Name = "vendorCurrency";
            this.vendorCurrency.Size = new System.Drawing.Size(193, 25);
            this.vendorCurrency.TabIndex = 24;
            this.vendorCurrency.ValueMember = "id";
            // 
            // vendorCurrencyLabel
            // 
            this.vendorCurrencyLabel.AutoSize = true;
            this.vendorCurrencyLabel.Location = new System.Drawing.Point(15, 240);
            this.vendorCurrencyLabel.Name = "vendorCurrencyLabel";
            this.vendorCurrencyLabel.Size = new System.Drawing.Size(59, 17);
            this.vendorCurrencyLabel.TabIndex = 23;
            this.vendorCurrencyLabel.Text = "Currency";
            // 
            // vendorEmail
            // 
            this.vendorEmail.Location = new System.Drawing.Point(135, 195);
            this.vendorEmail.Name = "vendorEmail";
            this.vendorEmail.Size = new System.Drawing.Size(193, 23);
            this.vendorEmail.TabIndex = 22;
            // 
            // vendorEmailLabel
            // 
            this.vendorEmailLabel.AutoSize = true;
            this.vendorEmailLabel.Location = new System.Drawing.Point(15, 195);
            this.vendorEmailLabel.Name = "vendorEmailLabel";
            this.vendorEmailLabel.Size = new System.Drawing.Size(39, 17);
            this.vendorEmailLabel.TabIndex = 21;
            this.vendorEmailLabel.Text = "Email";
            // 
            // vendor_name
            // 
            this.vendor_name.Location = new System.Drawing.Point(135, 111);
            this.vendor_name.Name = "vendor_name";
            this.vendor_name.Size = new System.Drawing.Size(193, 23);
            this.vendor_name.TabIndex = 20;
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Location = new System.Drawing.Point(15, 111);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(43, 17);
            this.item_name_label.TabIndex = 19;
            this.item_name_label.Text = "Name";
            // 
            // vendorPhone
            // 
            this.vendorPhone.Location = new System.Drawing.Point(135, 152);
            this.vendorPhone.Name = "vendorPhone";
            this.vendorPhone.Size = new System.Drawing.Size(193, 23);
            this.vendorPhone.TabIndex = 10;
            // 
            // vendorPhoneLabel
            // 
            this.vendorPhoneLabel.AutoSize = true;
            this.vendorPhoneLabel.Location = new System.Drawing.Point(15, 152);
            this.vendorPhoneLabel.Name = "vendorPhoneLabel";
            this.vendorPhoneLabel.Size = new System.Drawing.Size(100, 17);
            this.vendorPhoneLabel.TabIndex = 9;
            this.vendorPhoneLabel.Text = "Primary Contact";
            // 
            // vendorListGBox
            // 
            this.vendorListGBox.Controls.Add(this.vendorDataGridView);
            this.vendorListGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListGBox.Location = new System.Drawing.Point(681, 67);
            this.vendorListGBox.Name = "vendorListGBox";
            this.vendorListGBox.Size = new System.Drawing.Size(723, 405);
            this.vendorListGBox.TabIndex = 31;
            this.vendorListGBox.TabStop = false;
            this.vendorListGBox.Text = "Vendor(s) List";
            // 
            // vendorDataGridView
            // 
            this.vendorDataGridView.AllowUserToAddRows = false;
            this.vendorDataGridView.AllowUserToDeleteRows = false;
            this.vendorDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.vendorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vendorDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Location = new System.Drawing.Point(12, 36);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.ReadOnly = true;
            this.vendorDataGridView.RowHeadersWidth = 70;
            this.vendorDataGridView.Size = new System.Drawing.Size(694, 360);
            this.vendorDataGridView.TabIndex = 17;
            // 
            // vendorDeleteBtn
            // 
            this.vendorDeleteBtn.Enabled = false;
            this.vendorDeleteBtn.Location = new System.Drawing.Point(821, 510);
            this.vendorDeleteBtn.Name = "vendorDeleteBtn";
            this.vendorDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.vendorDeleteBtn.TabIndex = 35;
            this.vendorDeleteBtn.Text = "Remove";
            this.vendorDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // vendorModifyBtn
            // 
            this.vendorModifyBtn.Enabled = false;
            this.vendorModifyBtn.Location = new System.Drawing.Point(659, 510);
            this.vendorModifyBtn.Name = "vendorModifyBtn";
            this.vendorModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.vendorModifyBtn.TabIndex = 34;
            this.vendorModifyBtn.Text = "Modify";
            this.vendorModifyBtn.UseVisualStyleBackColor = true;
            // 
            // vendorAddNewBtn
            // 
            this.vendorAddNewBtn.Location = new System.Drawing.Point(578, 510);
            this.vendorAddNewBtn.Name = "vendorAddNewBtn";
            this.vendorAddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.vendorAddNewBtn.TabIndex = 33;
            this.vendorAddNewBtn.Text = "Add New";
            this.vendorAddNewBtn.UseVisualStyleBackColor = true;
            this.vendorAddNewBtn.Click += new System.EventHandler(this.vendorAddNewBtn_Click);
            // 
            // vendorSaveBtn
            // 
            this.vendorSaveBtn.Enabled = false;
            this.vendorSaveBtn.Location = new System.Drawing.Point(740, 510);
            this.vendorSaveBtn.Name = "vendorSaveBtn";
            this.vendorSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.vendorSaveBtn.TabIndex = 32;
            this.vendorSaveBtn.Text = "Save";
            this.vendorSaveBtn.UseVisualStyleBackColor = true;
            // 
            // vendorFormCancelBtn
            // 
            this.vendorFormCancelBtn.Location = new System.Drawing.Point(1231, 510);
            this.vendorFormCancelBtn.Name = "vendorFormCancelBtn";
            this.vendorFormCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.vendorFormCancelBtn.TabIndex = 37;
            this.vendorFormCancelBtn.Text = "Cancel";
            this.vendorFormCancelBtn.UseVisualStyleBackColor = true;
            this.vendorFormCancelBtn.Click += new System.EventHandler(this.vendorFormCancelBtn_Click);
            // 
            // vendorFormExitBtn
            // 
            this.vendorFormExitBtn.Location = new System.Drawing.Point(1312, 510);
            this.vendorFormExitBtn.Name = "vendorFormExitBtn";
            this.vendorFormExitBtn.Size = new System.Drawing.Size(75, 23);
            this.vendorFormExitBtn.TabIndex = 36;
            this.vendorFormExitBtn.Text = "Exit";
            this.vendorFormExitBtn.UseVisualStyleBackColor = true;
            this.vendorFormExitBtn.Click += new System.EventHandler(this.vendorFormExitBtn_Click);
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
            // vendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 545);
            this.Controls.Add(this.vendorFormCancelBtn);
            this.Controls.Add(this.vendorFormExitBtn);
            this.Controls.Add(this.vendorDeleteBtn);
            this.Controls.Add(this.vendorModifyBtn);
            this.Controls.Add(this.vendorAddNewBtn);
            this.Controls.Add(this.vendorSaveBtn);
            this.Controls.Add(this.vendorListGBox);
            this.Controls.Add(this.vendorFormGroupBox);
            this.Controls.Add(this.ItemFormHeading);
            this.Name = "vendorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vendors";
            this.Load += new System.EventHandler(this.vendorForm_Load);
            this.vendorFormGroupBox.ResumeLayout(false);
            this.vendorFormGroupBox.PerformLayout();
            this.vendorListGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencymasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemFormHeading;
        private System.Windows.Forms.GroupBox vendorFormGroupBox;
        private System.Windows.Forms.TextBox vendor_name;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.TextBox vendorPhone;
        private System.Windows.Forms.Label vendorPhoneLabel;
        private System.Windows.Forms.TextBox vendorEmail;
        private System.Windows.Forms.Label vendorEmailLabel;
        private System.Windows.Forms.ComboBox vendorCurrency;
        private System.Windows.Forms.Label vendorCurrencyLabel;
        private System.Windows.Forms.TextBox vendorPincode;
        private System.Windows.Forms.Label vendorPincodeLabel;
        private System.Windows.Forms.TextBox vendorState;
        private System.Windows.Forms.Label vendorStateLabel;
        private System.Windows.Forms.TextBox vendorCity;
        private System.Windows.Forms.Label vendorCityLabel;
        private System.Windows.Forms.RichTextBox vendorAddress;
        private System.Windows.Forms.Label vendorAddressLabel;
        private System.Windows.Forms.GroupBox vendorListGBox;
        private System.Windows.Forms.DataGridView vendorDataGridView;
        private System.Windows.Forms.Button vendorDeleteBtn;
        private System.Windows.Forms.Button vendorModifyBtn;
        private System.Windows.Forms.Button vendorAddNewBtn;
        private System.Windows.Forms.Button vendorSaveBtn;
        private System.Windows.Forms.Button vendorFormCancelBtn;
        private System.Windows.Forms.Button vendorFormExitBtn;
        private billingFormDataDataSet3 billingFormDataDataSet3;
        private System.Windows.Forms.BindingSource currencymasterBindingSource;
        private billingFormDataDataSet3TableAdapters.currency_masterTableAdapter currency_masterTableAdapter;
    }
}
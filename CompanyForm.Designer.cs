namespace BillingSoftware
{
    partial class CompanyForm
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
            this.createCompanyGbox = new System.Windows.Forms.GroupBox();
            this.comFiscalYrEndDateLabel = new System.Windows.Forms.Label();
            this.comFiscalYrEndDate = new System.Windows.Forms.DateTimePicker();
            this.comFiscalYrStDateLabel = new System.Windows.Forms.Label();
            this.companyCurrency = new System.Windows.Forms.ComboBox();
            this.currencymasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingFormDataDataSet3 = new BillingSoftware.billingFormDataDataSet3();
            this.companyCurrencyLabel = new System.Windows.Forms.Label();
            this.companyIndustryType = new System.Windows.Forms.TextBox();
            this.companyIndustryTypeLabel = new System.Windows.Forms.Label();
            this.companyState = new System.Windows.Forms.TextBox();
            this.companyStateLabel = new System.Windows.Forms.Label();
            this.companyCountry = new System.Windows.Forms.TextBox();
            this.companyCountryLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.comFiscalYrStDate = new System.Windows.Forms.DateTimePicker();
            this.currency_masterTableAdapter = new BillingSoftware.billingFormDataDataSet3TableAdapters.currency_masterTableAdapter();
            this.companyCancelBtn = new System.Windows.Forms.Button();
            this.companyExitBtn = new System.Windows.Forms.Button();
            this.companyFormHeading = new System.Windows.Forms.Label();
            this.companySaveBtn = new System.Windows.Forms.Button();
            this.companyAdminUserGbox = new System.Windows.Forms.GroupBox();
            this.comUserIdLabel = new System.Windows.Forms.Label();
            this.comUserId = new System.Windows.Forms.TextBox();
            this.comUserPassword = new System.Windows.Forms.TextBox();
            this.comUserPasswordlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createCompanyGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencymasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet3)).BeginInit();
            this.companyAdminUserGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCompanyGbox
            // 
            this.createCompanyGbox.Controls.Add(this.companyAdminUserGbox);
            this.createCompanyGbox.Controls.Add(this.comFiscalYrEndDateLabel);
            this.createCompanyGbox.Controls.Add(this.comFiscalYrEndDate);
            this.createCompanyGbox.Controls.Add(this.comFiscalYrStDateLabel);
            this.createCompanyGbox.Controls.Add(this.companyCurrency);
            this.createCompanyGbox.Controls.Add(this.companyCurrencyLabel);
            this.createCompanyGbox.Controls.Add(this.companyIndustryType);
            this.createCompanyGbox.Controls.Add(this.companyIndustryTypeLabel);
            this.createCompanyGbox.Controls.Add(this.companyState);
            this.createCompanyGbox.Controls.Add(this.companyStateLabel);
            this.createCompanyGbox.Controls.Add(this.companyCountry);
            this.createCompanyGbox.Controls.Add(this.companyCountryLabel);
            this.createCompanyGbox.Controls.Add(this.companyName);
            this.createCompanyGbox.Controls.Add(this.companyNameLabel);
            this.createCompanyGbox.Controls.Add(this.comFiscalYrStDate);
            this.createCompanyGbox.Location = new System.Drawing.Point(31, 78);
            this.createCompanyGbox.Name = "createCompanyGbox";
            this.createCompanyGbox.Size = new System.Drawing.Size(754, 353);
            this.createCompanyGbox.TabIndex = 0;
            this.createCompanyGbox.TabStop = false;
            this.createCompanyGbox.Text = "Company Details";
            // 
            // comFiscalYrEndDateLabel
            // 
            this.comFiscalYrEndDateLabel.AutoSize = true;
            this.comFiscalYrEndDateLabel.Location = new System.Drawing.Point(382, 111);
            this.comFiscalYrEndDateLabel.Name = "comFiscalYrEndDateLabel";
            this.comFiscalYrEndDateLabel.Size = new System.Drawing.Size(107, 13);
            this.comFiscalYrEndDateLabel.TabIndex = 28;
            this.comFiscalYrEndDateLabel.Text = "Fiscal Year End Date";
            // 
            // comFiscalYrEndDate
            // 
            this.comFiscalYrEndDate.Location = new System.Drawing.Point(516, 105);
            this.comFiscalYrEndDate.Name = "comFiscalYrEndDate";
            this.comFiscalYrEndDate.Size = new System.Drawing.Size(198, 20);
            this.comFiscalYrEndDate.TabIndex = 27;
            // 
            // comFiscalYrStDateLabel
            // 
            this.comFiscalYrStDateLabel.AutoSize = true;
            this.comFiscalYrStDateLabel.Location = new System.Drawing.Point(382, 57);
            this.comFiscalYrStDateLabel.Name = "comFiscalYrStDateLabel";
            this.comFiscalYrStDateLabel.Size = new System.Drawing.Size(110, 13);
            this.comFiscalYrStDateLabel.TabIndex = 26;
            this.comFiscalYrStDateLabel.Text = "Fiscal Year Start Date";
            // 
            // companyCurrency
            // 
            this.companyCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currencymasterBindingSource, "id", true));
            this.companyCurrency.DataSource = this.currencymasterBindingSource;
            this.companyCurrency.DisplayMember = "currency_name";
            this.companyCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyCurrency.FormattingEnabled = true;
            this.companyCurrency.Location = new System.Drawing.Point(143, 246);
            this.companyCurrency.Name = "companyCurrency";
            this.companyCurrency.Size = new System.Drawing.Size(216, 21);
            this.companyCurrency.TabIndex = 25;
            this.companyCurrency.ValueMember = "id";
            // 
            // currencymasterBindingSource
            // 
            this.currencymasterBindingSource.DataMember = "currency_master";
            this.currencymasterBindingSource.DataSource = this.billingFormDataDataSet3;
            // 
            // billingFormDataDataSet3
            // 
            this.billingFormDataDataSet3.DataSetName = "billingFormDataDataSet3";
            this.billingFormDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyCurrencyLabel
            // 
            this.companyCurrencyLabel.AutoSize = true;
            this.companyCurrencyLabel.Location = new System.Drawing.Point(35, 246);
            this.companyCurrencyLabel.Name = "companyCurrencyLabel";
            this.companyCurrencyLabel.Size = new System.Drawing.Size(49, 13);
            this.companyCurrencyLabel.TabIndex = 8;
            this.companyCurrencyLabel.Text = "Currency";
            // 
            // companyIndustryType
            // 
            this.companyIndustryType.Location = new System.Drawing.Point(143, 197);
            this.companyIndustryType.Name = "companyIndustryType";
            this.companyIndustryType.Size = new System.Drawing.Size(216, 20);
            this.companyIndustryType.TabIndex = 6;
            // 
            // companyIndustryTypeLabel
            // 
            this.companyIndustryTypeLabel.AutoSize = true;
            this.companyIndustryTypeLabel.Location = new System.Drawing.Point(27, 198);
            this.companyIndustryTypeLabel.Name = "companyIndustryTypeLabel";
            this.companyIndustryTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.companyIndustryTypeLabel.TabIndex = 7;
            this.companyIndustryTypeLabel.Text = "Industry Type";
            // 
            // companyState
            // 
            this.companyState.Location = new System.Drawing.Point(143, 152);
            this.companyState.Name = "companyState";
            this.companyState.Size = new System.Drawing.Size(216, 20);
            this.companyState.TabIndex = 4;
            // 
            // companyStateLabel
            // 
            this.companyStateLabel.AutoSize = true;
            this.companyStateLabel.Location = new System.Drawing.Point(27, 153);
            this.companyStateLabel.Name = "companyStateLabel";
            this.companyStateLabel.Size = new System.Drawing.Size(32, 13);
            this.companyStateLabel.TabIndex = 5;
            this.companyStateLabel.Text = "State";
            // 
            // companyCountry
            // 
            this.companyCountry.Location = new System.Drawing.Point(143, 103);
            this.companyCountry.Name = "companyCountry";
            this.companyCountry.Size = new System.Drawing.Size(216, 20);
            this.companyCountry.TabIndex = 2;
            // 
            // companyCountryLabel
            // 
            this.companyCountryLabel.AutoSize = true;
            this.companyCountryLabel.Location = new System.Drawing.Point(27, 104);
            this.companyCountryLabel.Name = "companyCountryLabel";
            this.companyCountryLabel.Size = new System.Drawing.Size(43, 13);
            this.companyCountryLabel.TabIndex = 3;
            this.companyCountryLabel.Text = "Country";
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(143, 56);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(216, 20);
            this.companyName.TabIndex = 1;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(27, 57);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.companyNameLabel.TabIndex = 1;
            this.companyNameLabel.Text = "Company Name";
            // 
            // comFiscalYrStDate
            // 
            this.comFiscalYrStDate.Location = new System.Drawing.Point(516, 56);
            this.comFiscalYrStDate.Name = "comFiscalYrStDate";
            this.comFiscalYrStDate.Size = new System.Drawing.Size(198, 20);
            this.comFiscalYrStDate.TabIndex = 0;
            // 
            // currency_masterTableAdapter
            // 
            this.currency_masterTableAdapter.ClearBeforeFill = true;
            // 
            // companyCancelBtn
            // 
            this.companyCancelBtn.Location = new System.Drawing.Point(629, 437);
            this.companyCancelBtn.Name = "companyCancelBtn";
            this.companyCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.companyCancelBtn.TabIndex = 1;
            this.companyCancelBtn.Text = "Cancel";
            this.companyCancelBtn.UseVisualStyleBackColor = true;
            // 
            // companyExitBtn
            // 
            this.companyExitBtn.Location = new System.Drawing.Point(710, 437);
            this.companyExitBtn.Name = "companyExitBtn";
            this.companyExitBtn.Size = new System.Drawing.Size(75, 23);
            this.companyExitBtn.TabIndex = 2;
            this.companyExitBtn.Text = "Exit";
            this.companyExitBtn.UseVisualStyleBackColor = true;
            this.companyExitBtn.Click += new System.EventHandler(this.companyExitBtn_Click);
            // 
            // companyFormHeading
            // 
            this.companyFormHeading.AutoSize = true;
            this.companyFormHeading.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.companyFormHeading.Location = new System.Drawing.Point(31, 22);
            this.companyFormHeading.Name = "companyFormHeading";
            this.companyFormHeading.Size = new System.Drawing.Size(248, 31);
            this.companyFormHeading.TabIndex = 3;
            this.companyFormHeading.Text = "Add New Company";
            // 
            // companySaveBtn
            // 
            this.companySaveBtn.Location = new System.Drawing.Point(547, 437);
            this.companySaveBtn.Name = "companySaveBtn";
            this.companySaveBtn.Size = new System.Drawing.Size(75, 23);
            this.companySaveBtn.TabIndex = 4;
            this.companySaveBtn.Text = "Save";
            this.companySaveBtn.UseVisualStyleBackColor = true;
            this.companySaveBtn.Click += new System.EventHandler(this.companySaveBtn_Click);
            // 
            // companyAdminUserGbox
            // 
            this.companyAdminUserGbox.Controls.Add(this.label1);
            this.companyAdminUserGbox.Controls.Add(this.comUserPassword);
            this.companyAdminUserGbox.Controls.Add(this.comUserPasswordlabel);
            this.companyAdminUserGbox.Controls.Add(this.comUserId);
            this.companyAdminUserGbox.Controls.Add(this.comUserIdLabel);
            this.companyAdminUserGbox.Location = new System.Drawing.Point(385, 152);
            this.companyAdminUserGbox.Name = "companyAdminUserGbox";
            this.companyAdminUserGbox.Size = new System.Drawing.Size(329, 188);
            this.companyAdminUserGbox.TabIndex = 29;
            this.companyAdminUserGbox.TabStop = false;
            this.companyAdminUserGbox.Text = "Admin User Details";
            // 
            // comUserIdLabel
            // 
            this.comUserIdLabel.AutoSize = true;
            this.comUserIdLabel.Location = new System.Drawing.Point(36, 52);
            this.comUserIdLabel.Name = "comUserIdLabel";
            this.comUserIdLabel.Size = new System.Drawing.Size(41, 13);
            this.comUserIdLabel.TabIndex = 0;
            this.comUserIdLabel.Text = "User Id";
            // 
            // comUserId
            // 
            this.comUserId.Location = new System.Drawing.Point(125, 49);
            this.comUserId.Name = "comUserId";
            this.comUserId.Size = new System.Drawing.Size(163, 20);
            this.comUserId.TabIndex = 1;
            // 
            // comUserPassword
            // 
            this.comUserPassword.Location = new System.Drawing.Point(124, 84);
            this.comUserPassword.Name = "comUserPassword";
            this.comUserPassword.Size = new System.Drawing.Size(164, 20);
            this.comUserPassword.TabIndex = 3;
            // 
            // comUserPasswordlabel
            // 
            this.comUserPasswordlabel.AutoSize = true;
            this.comUserPasswordlabel.Location = new System.Drawing.Point(35, 87);
            this.comUserPasswordlabel.Name = "comUserPasswordlabel";
            this.comUserPasswordlabel.Size = new System.Drawing.Size(53, 13);
            this.comUserPasswordlabel.TabIndex = 2;
            this.comUserPasswordlabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Fill up the User id and Password to create the admin user for this company. Plea" +
    "se remember the user id & password to access your account later";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 489);
            this.Controls.Add(this.companySaveBtn);
            this.Controls.Add(this.companyFormHeading);
            this.Controls.Add(this.companyExitBtn);
            this.Controls.Add(this.companyCancelBtn);
            this.Controls.Add(this.createCompanyGbox);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Company";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.createCompanyGbox.ResumeLayout(false);
            this.createCompanyGbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencymasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet3)).EndInit();
            this.companyAdminUserGbox.ResumeLayout(false);
            this.companyAdminUserGbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox createCompanyGbox;
        private System.Windows.Forms.DateTimePicker comFiscalYrStDate;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.TextBox companyIndustryType;
        private System.Windows.Forms.Label companyIndustryTypeLabel;
        private System.Windows.Forms.TextBox companyState;
        private System.Windows.Forms.Label companyStateLabel;
        private System.Windows.Forms.TextBox companyCountry;
        private System.Windows.Forms.Label companyCountryLabel;
        private System.Windows.Forms.Label companyCurrencyLabel;
        private System.Windows.Forms.ComboBox companyCurrency;
        private billingFormDataDataSet3 billingFormDataDataSet3;
        private System.Windows.Forms.BindingSource currencymasterBindingSource;
        private billingFormDataDataSet3TableAdapters.currency_masterTableAdapter currency_masterTableAdapter;
        private System.Windows.Forms.Label comFiscalYrStDateLabel;
        private System.Windows.Forms.Label comFiscalYrEndDateLabel;
        private System.Windows.Forms.DateTimePicker comFiscalYrEndDate;
        private System.Windows.Forms.Button companyCancelBtn;
        private System.Windows.Forms.Button companyExitBtn;
        private System.Windows.Forms.Label companyFormHeading;
        private System.Windows.Forms.Button companySaveBtn;
        private System.Windows.Forms.GroupBox companyAdminUserGbox;
        private System.Windows.Forms.TextBox comUserPassword;
        private System.Windows.Forms.Label comUserPasswordlabel;
        private System.Windows.Forms.TextBox comUserId;
        private System.Windows.Forms.Label comUserIdLabel;
        private System.Windows.Forms.Label label1;
    }
}
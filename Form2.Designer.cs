
namespace BillingSoftware
{
    partial class Form2
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
            this.account_groupBox = new System.Windows.Forms.GroupBox();
            this.account_name = new System.Windows.Forms.TextBox();
            this.account_name_label = new System.Windows.Forms.Label();
            this.accountSaveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingFormDataAccountsDataSet = new BillingSoftware.billingFormDataAccountsDataSet();
            this.billingFormDataDataSet = new BillingSoftware.billingFormDataDataSet();
            this.billingFormDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account_masterTableAdapter = new BillingSoftware.billingFormDataAccountsDataSetTableAdapters.account_masterTableAdapter();
            this.accountModifyBtn = new System.Windows.Forms.Button();
            this.accountAddNewBtn = new System.Windows.Forms.Button();
            this.accountRemoveBtn = new System.Windows.Forms.Button();
            this.AccountFormExitBtn = new System.Windows.Forms.Button();
            this.AccountFormCancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.account_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataAccountsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // account_groupBox
            // 
            this.account_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.account_groupBox.Controls.Add(this.account_name);
            this.account_groupBox.Controls.Add(this.account_name_label);
            this.account_groupBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_groupBox.Location = new System.Drawing.Point(43, 63);
            this.account_groupBox.Name = "account_groupBox";
            this.account_groupBox.Size = new System.Drawing.Size(344, 217);
            this.account_groupBox.TabIndex = 17;
            this.account_groupBox.TabStop = false;
            this.account_groupBox.Text = "Accounts Details";
            // 
            // account_name
            // 
            this.account_name.Location = new System.Drawing.Point(106, 66);
            this.account_name.Name = "account_name";
            this.account_name.Size = new System.Drawing.Size(217, 22);
            this.account_name.TabIndex = 20;
            // 
            // account_name_label
            // 
            this.account_name_label.AutoSize = true;
            this.account_name_label.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_name_label.Location = new System.Drawing.Point(6, 69);
            this.account_name_label.Name = "account_name_label";
            this.account_name_label.Size = new System.Drawing.Size(86, 16);
            this.account_name_label.TabIndex = 19;
            this.account_name_label.Text = "Account Name";
            // 
            // accountSaveBtn
            // 
            this.accountSaveBtn.Enabled = false;
            this.accountSaveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSaveBtn.Location = new System.Drawing.Point(348, 396);
            this.accountSaveBtn.Name = "accountSaveBtn";
            this.accountSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.accountSaveBtn.TabIndex = 16;
            this.accountSaveBtn.Text = "Save";
            this.accountSaveBtn.UseVisualStyleBackColor = true;
            this.accountSaveBtn.Click += new System.EventHandler(this.accountSaveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Location = new System.Drawing.Point(32, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 110;
            this.dataGridView1.Size = new System.Drawing.Size(412, 263);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountmasterBindingSource
            // 
            this.accountmasterBindingSource.DataMember = "account_master";
            this.accountmasterBindingSource.DataSource = this.billingFormDataAccountsDataSet;
            // 
            // billingFormDataAccountsDataSet
            // 
            this.billingFormDataAccountsDataSet.DataSetName = "billingFormDataAccountsDataSet";
            this.billingFormDataAccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingFormDataDataSet
            // 
            this.billingFormDataDataSet.DataSetName = "billingFormDataDataSet";
            this.billingFormDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingFormDataDataSetBindingSource
            // 
            this.billingFormDataDataSetBindingSource.DataSource = this.billingFormDataDataSet;
            this.billingFormDataDataSetBindingSource.Position = 0;
            // 
            // account_masterTableAdapter
            // 
            this.account_masterTableAdapter.ClearBeforeFill = true;
            // 
            // accountModifyBtn
            // 
            this.accountModifyBtn.Enabled = false;
            this.accountModifyBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountModifyBtn.Location = new System.Drawing.Point(429, 396);
            this.accountModifyBtn.Name = "accountModifyBtn";
            this.accountModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.accountModifyBtn.TabIndex = 19;
            this.accountModifyBtn.Text = "Modify";
            this.accountModifyBtn.UseVisualStyleBackColor = true;
            this.accountModifyBtn.Click += new System.EventHandler(this.accountModifyBtn_Click);
            // 
            // accountAddNewBtn
            // 
            this.accountAddNewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountAddNewBtn.Location = new System.Drawing.Point(267, 396);
            this.accountAddNewBtn.Name = "accountAddNewBtn";
            this.accountAddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.accountAddNewBtn.TabIndex = 20;
            this.accountAddNewBtn.Text = "+ Add New";
            this.accountAddNewBtn.UseVisualStyleBackColor = true;
            this.accountAddNewBtn.Click += new System.EventHandler(this.accountAddNewBtn_Click);
            // 
            // accountRemoveBtn
            // 
            this.accountRemoveBtn.Enabled = false;
            this.accountRemoveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountRemoveBtn.Location = new System.Drawing.Point(510, 396);
            this.accountRemoveBtn.Name = "accountRemoveBtn";
            this.accountRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.accountRemoveBtn.TabIndex = 21;
            this.accountRemoveBtn.Text = "Remove";
            this.accountRemoveBtn.UseVisualStyleBackColor = true;
            this.accountRemoveBtn.Click += new System.EventHandler(this.accountRemoveBtn_Click);
            // 
            // AccountFormExitBtn
            // 
            this.AccountFormExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountFormExitBtn.Location = new System.Drawing.Point(790, 396);
            this.AccountFormExitBtn.Name = "AccountFormExitBtn";
            this.AccountFormExitBtn.Size = new System.Drawing.Size(75, 23);
            this.AccountFormExitBtn.TabIndex = 22;
            this.AccountFormExitBtn.Text = "Exit";
            this.AccountFormExitBtn.UseVisualStyleBackColor = true;
            this.AccountFormExitBtn.Click += new System.EventHandler(this.AccountFormExitBtn_Click);
            // 
            // AccountFormCancelBtn
            // 
            this.AccountFormCancelBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountFormCancelBtn.Location = new System.Drawing.Point(709, 396);
            this.AccountFormCancelBtn.Name = "AccountFormCancelBtn";
            this.AccountFormCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.AccountFormCancelBtn.TabIndex = 23;
            this.AccountFormCancelBtn.Text = "Cancel";
            this.AccountFormCancelBtn.UseVisualStyleBackColor = true;
            this.AccountFormCancelBtn.Click += new System.EventHandler(this.AccountFormCancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 298);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account List";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AccountFormCancelBtn);
            this.Controls.Add(this.AccountFormExitBtn);
            this.Controls.Add(this.accountRemoveBtn);
            this.Controls.Add(this.accountSaveBtn);
            this.Controls.Add(this.accountAddNewBtn);
            this.Controls.Add(this.accountModifyBtn);
            this.Controls.Add(this.account_groupBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.account_groupBox.ResumeLayout(false);
            this.account_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataAccountsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox account_groupBox;
        private System.Windows.Forms.TextBox account_name;
        private System.Windows.Forms.Label account_name_label;
        private System.Windows.Forms.Button accountSaveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private billingFormDataDataSet billingFormDataDataSet;
        private System.Windows.Forms.BindingSource billingFormDataDataSetBindingSource;
        private billingFormDataAccountsDataSet billingFormDataAccountsDataSet;
        private System.Windows.Forms.BindingSource accountmasterBindingSource;
        private billingFormDataAccountsDataSetTableAdapters.account_masterTableAdapter account_masterTableAdapter;
        private System.Windows.Forms.Button accountModifyBtn;
        private System.Windows.Forms.Button accountAddNewBtn;
        private System.Windows.Forms.Button accountRemoveBtn;
        private System.Windows.Forms.Button AccountFormExitBtn;
        private System.Windows.Forms.Button AccountFormCancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
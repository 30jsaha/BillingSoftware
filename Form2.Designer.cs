
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
            this.billingFormDataDataSet = new BillingSoftware.billingFormDataDataSet();
            this.billingFormDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingFormDataAccountsDataSet = new BillingSoftware.billingFormDataAccountsDataSet();
            this.accountmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account_masterTableAdapter = new BillingSoftware.billingFormDataAccountsDataSetTableAdapters.account_masterTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataAccountsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // account_groupBox
            // 
            this.account_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.account_groupBox.Controls.Add(this.account_name);
            this.account_groupBox.Controls.Add(this.account_name_label);
            this.account_groupBox.Controls.Add(this.accountSaveBtn);
            this.account_groupBox.Location = new System.Drawing.Point(43, 63);
            this.account_groupBox.Name = "account_groupBox";
            this.account_groupBox.Size = new System.Drawing.Size(343, 263);
            this.account_groupBox.TabIndex = 17;
            this.account_groupBox.TabStop = false;
            this.account_groupBox.Text = "Accounts Details";
            // 
            // account_name
            // 
            this.account_name.Location = new System.Drawing.Point(147, 62);
            this.account_name.Name = "account_name";
            this.account_name.Size = new System.Drawing.Size(170, 20);
            this.account_name.TabIndex = 20;
            // 
            // account_name_label
            // 
            this.account_name_label.AutoSize = true;
            this.account_name_label.Location = new System.Drawing.Point(38, 69);
            this.account_name_label.Name = "account_name_label";
            this.account_name_label.Size = new System.Drawing.Size(78, 13);
            this.account_name_label.TabIndex = 19;
            this.account_name_label.Text = "Account Name";
            // 
            // accountSaveBtn
            // 
            this.accountSaveBtn.Location = new System.Drawing.Point(242, 109);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountnameDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountmasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(412, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(407, 263);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // billingFormDataAccountsDataSet
            // 
            this.billingFormDataAccountsDataSet.DataSetName = "billingFormDataAccountsDataSet";
            this.billingFormDataAccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountmasterBindingSource
            // 
            this.accountmasterBindingSource.DataMember = "account_master";
            this.accountmasterBindingSource.DataSource = this.billingFormDataAccountsDataSet;
            // 
            // account_masterTableAdapter
            // 
            this.account_masterTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountnameDataGridViewTextBoxColumn
            // 
            this.accountnameDataGridViewTextBoxColumn.DataPropertyName = "account_name";
            this.accountnameDataGridViewTextBoxColumn.HeaderText = "account_name";
            this.accountnameDataGridViewTextBoxColumn.Name = "accountnameDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.account_groupBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.account_groupBox.ResumeLayout(false);
            this.account_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataAccountsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
    }
}
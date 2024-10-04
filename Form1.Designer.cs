
namespace BillingSoftware
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.item_unit_label = new System.Windows.Forms.Label();
            this.item_unit_select = new System.Windows.Forms.ComboBox();
            this.item_selling_price = new System.Windows.Forms.TextBox();
            this.item_selling_price_label = new System.Windows.Forms.Label();
            this.item_account_label = new System.Windows.Forms.Label();
            this.item_description_label = new System.Windows.Forms.Label();
            this.item_description = new System.Windows.Forms.RichTextBox();
            this.itemFormGroupBox = new System.Windows.Forms.GroupBox();
            this.item_account_select = new System.Windows.Forms.ComboBox();
            this.accountmasterBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemMasterListViewDataSet = new BillingSoftware.itemMasterListViewDataSet();
            this.accountmasterBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.billingFormDataAccountsDataSet = new BillingSoftware.billingFormDataAccountsDataSet();
            this.item_name = new System.Windows.Forms.TextBox();
            this.item_name_label = new System.Windows.Forms.Label();
            this.item_type_service = new System.Windows.Forms.RadioButton();
            this.item_type_goods = new System.Windows.Forms.RadioButton();
            this.itemDeleteBtn = new System.Windows.Forms.Button();
            this.itemModifyBtn = new System.Windows.Forms.Button();
            this.itemAddNewBtn = new System.Windows.Forms.Button();
            this.itemSaveBtn = new System.Windows.Forms.Button();
            this.accountmasterBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.billingFormDataDataSet2 = new BillingSoftware.billingFormDataDataSet2();
            this.accountmasterBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.accountmasterBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.itemMasterListViewDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountmasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingFormDataDataSet1 = new BillingSoftware.billingFormDataDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billingFormDataDataSet = new BillingSoftware.billingFormDataDataSet();
            this.account_masterTableAdapter = new BillingSoftware.billingFormDataDataSet1TableAdapters.account_masterTableAdapter();
            this.item_unit_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.account_masterTableAdapter1 = new BillingSoftware.billingFormDataDataSet2TableAdapters.account_masterTableAdapter();
            this.account_masterTableAdapter2 = new BillingSoftware.itemMasterListViewDataSetTableAdapters.account_masterTableAdapter();
            this.itemmasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.item_masterTableAdapter1 = new BillingSoftware.itemMasterListViewDataSetTableAdapters.item_masterTableAdapter();
            this.itemmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_masterTableAdapter = new BillingSoftware.billingFormDataDataSetTableAdapters.item_masterTableAdapter();
            this.account_masterTableAdapter3 = new BillingSoftware.billingFormDataAccountsDataSetTableAdapters.account_masterTableAdapter();
            this.itemFormExitBtn = new System.Windows.Forms.Button();
            this.itemFormCancelBtn = new System.Windows.Forms.Button();
            this.itemListGBox = new System.Windows.Forms.GroupBox();
            this.itemFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterListViewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataAccountsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterListViewDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource)).BeginInit();
            this.itemListGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemFormHeading
            // 
            this.ItemFormHeading.AutoSize = true;
            this.ItemFormHeading.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ItemFormHeading.Location = new System.Drawing.Point(24, 19);
            this.ItemFormHeading.Name = "ItemFormHeading";
            this.ItemFormHeading.Size = new System.Drawing.Size(188, 31);
            this.ItemFormHeading.TabIndex = 0;
            this.ItemFormHeading.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // item_unit_label
            // 
            this.item_unit_label.AutoSize = true;
            this.item_unit_label.Location = new System.Drawing.Point(27, 107);
            this.item_unit_label.Name = "item_unit_label";
            this.item_unit_label.Size = new System.Drawing.Size(69, 17);
            this.item_unit_label.TabIndex = 6;
            this.item_unit_label.Text = "Select Unit";
            this.item_unit_label.Click += new System.EventHandler(this.item_unit_label_Click);
            // 
            // item_unit_select
            // 
            this.item_unit_select.FormattingEnabled = true;
            this.item_unit_select.Items.AddRange(new object[] {
            "Box",
            "cm",
            "ft",
            "dz",
            "gm",
            "in"});
            this.item_unit_select.Location = new System.Drawing.Point(142, 104);
            this.item_unit_select.Name = "item_unit_select";
            this.item_unit_select.Size = new System.Drawing.Size(245, 25);
            this.item_unit_select.TabIndex = 8;
            // 
            // item_selling_price
            // 
            this.item_selling_price.Location = new System.Drawing.Point(142, 149);
            this.item_selling_price.Name = "item_selling_price";
            this.item_selling_price.Size = new System.Drawing.Size(245, 23);
            this.item_selling_price.TabIndex = 10;
            // 
            // item_selling_price_label
            // 
            this.item_selling_price_label.AutoSize = true;
            this.item_selling_price_label.Location = new System.Drawing.Point(22, 149);
            this.item_selling_price_label.Name = "item_selling_price_label";
            this.item_selling_price_label.Size = new System.Drawing.Size(78, 17);
            this.item_selling_price_label.TabIndex = 9;
            this.item_selling_price_label.Text = "Selling Price";
            // 
            // item_account_label
            // 
            this.item_account_label.AutoSize = true;
            this.item_account_label.Location = new System.Drawing.Point(22, 198);
            this.item_account_label.Name = "item_account_label";
            this.item_account_label.Size = new System.Drawing.Size(92, 17);
            this.item_account_label.TabIndex = 11;
            this.item_account_label.Text = "Select Account";
            // 
            // item_description_label
            // 
            this.item_description_label.AutoSize = true;
            this.item_description_label.Location = new System.Drawing.Point(26, 295);
            this.item_description_label.Name = "item_description_label";
            this.item_description_label.Size = new System.Drawing.Size(74, 17);
            this.item_description_label.TabIndex = 13;
            this.item_description_label.Text = "Description";
            // 
            // item_description
            // 
            this.item_description.Location = new System.Drawing.Point(142, 244);
            this.item_description.Name = "item_description";
            this.item_description.Size = new System.Drawing.Size(245, 128);
            this.item_description.TabIndex = 15;
            this.item_description.Text = "";
            // 
            // itemFormGroupBox
            // 
            this.itemFormGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.itemFormGroupBox.Controls.Add(this.item_account_select);
            this.itemFormGroupBox.Controls.Add(this.item_name);
            this.itemFormGroupBox.Controls.Add(this.item_name_label);
            this.itemFormGroupBox.Controls.Add(this.item_type_service);
            this.itemFormGroupBox.Controls.Add(this.item_type_goods);
            this.itemFormGroupBox.Controls.Add(this.item_description);
            this.itemFormGroupBox.Controls.Add(this.label2);
            this.itemFormGroupBox.Controls.Add(this.item_description_label);
            this.itemFormGroupBox.Controls.Add(this.item_account_label);
            this.itemFormGroupBox.Controls.Add(this.item_selling_price);
            this.itemFormGroupBox.Controls.Add(this.item_selling_price_label);
            this.itemFormGroupBox.Controls.Add(this.item_unit_label);
            this.itemFormGroupBox.Controls.Add(this.item_unit_select);
            this.itemFormGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemFormGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFormGroupBox.Location = new System.Drawing.Point(29, 78);
            this.itemFormGroupBox.Name = "itemFormGroupBox";
            this.itemFormGroupBox.Size = new System.Drawing.Size(433, 405);
            this.itemFormGroupBox.TabIndex = 16;
            this.itemFormGroupBox.TabStop = false;
            this.itemFormGroupBox.Text = "Item Details";
            // 
            // item_account_select
            // 
            this.item_account_select.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.accountmasterBindingSource2, "account_name", true));
            this.item_account_select.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountmasterBindingSource5, "id", true));
            this.item_account_select.DataSource = this.accountmasterBindingSource5;
            this.item_account_select.DisplayMember = "account_name";
            this.item_account_select.FormattingEnabled = true;
            this.item_account_select.Location = new System.Drawing.Point(142, 195);
            this.item_account_select.Name = "item_account_select";
            this.item_account_select.Size = new System.Drawing.Size(245, 25);
            this.item_account_select.TabIndex = 21;
            this.item_account_select.ValueMember = "id";
            // 
            // accountmasterBindingSource2
            // 
            this.accountmasterBindingSource2.DataMember = "account_master";
            this.accountmasterBindingSource2.DataSource = this.itemMasterListViewDataSet;
            // 
            // itemMasterListViewDataSet
            // 
            this.itemMasterListViewDataSet.DataSetName = "itemMasterListViewDataSet";
            this.itemMasterListViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountmasterBindingSource5
            // 
            this.accountmasterBindingSource5.DataMember = "account_master";
            this.accountmasterBindingSource5.DataSource = this.billingFormDataAccountsDataSet;
            // 
            // billingFormDataAccountsDataSet
            // 
            this.billingFormDataAccountsDataSet.DataSetName = "billingFormDataAccountsDataSet";
            this.billingFormDataAccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // item_name
            // 
            this.item_name.Location = new System.Drawing.Point(142, 69);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(245, 23);
            this.item_name.TabIndex = 20;
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Location = new System.Drawing.Point(27, 69);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(43, 17);
            this.item_name_label.TabIndex = 19;
            this.item_name_label.Text = "Name";
            // 
            // item_type_service
            // 
            this.item_type_service.AccessibleName = "";
            this.item_type_service.AutoSize = true;
            this.item_type_service.Location = new System.Drawing.Point(225, 32);
            this.item_type_service.Name = "item_type_service";
            this.item_type_service.Size = new System.Drawing.Size(67, 21);
            this.item_type_service.TabIndex = 18;
            this.item_type_service.TabStop = true;
            this.item_type_service.Text = "Service";
            this.item_type_service.UseVisualStyleBackColor = true;
            // 
            // item_type_goods
            // 
            this.item_type_goods.AccessibleName = "ItemTypeGoods";
            this.item_type_goods.AutoSize = true;
            this.item_type_goods.Location = new System.Drawing.Point(142, 34);
            this.item_type_goods.Name = "item_type_goods";
            this.item_type_goods.Size = new System.Drawing.Size(65, 21);
            this.item_type_goods.TabIndex = 17;
            this.item_type_goods.TabStop = true;
            this.item_type_goods.Text = "Goods";
            this.item_type_goods.UseVisualStyleBackColor = true;
            this.item_type_goods.CheckedChanged += new System.EventHandler(this.item_type_goods_CheckedChanged_1);
            // 
            // itemDeleteBtn
            // 
            this.itemDeleteBtn.Enabled = false;
            this.itemDeleteBtn.Location = new System.Drawing.Point(646, 541);
            this.itemDeleteBtn.Name = "itemDeleteBtn";
            this.itemDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.itemDeleteBtn.TabIndex = 24;
            this.itemDeleteBtn.Text = "Remove";
            this.itemDeleteBtn.UseVisualStyleBackColor = true;
            this.itemDeleteBtn.Click += new System.EventHandler(this.itemDeleteBtn_Click);
            // 
            // itemModifyBtn
            // 
            this.itemModifyBtn.Enabled = false;
            this.itemModifyBtn.Location = new System.Drawing.Point(484, 541);
            this.itemModifyBtn.Name = "itemModifyBtn";
            this.itemModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.itemModifyBtn.TabIndex = 23;
            this.itemModifyBtn.Text = "Modify";
            this.itemModifyBtn.UseVisualStyleBackColor = true;
            this.itemModifyBtn.Click += new System.EventHandler(this.itemModifyBtn_Click);
            // 
            // itemAddNewBtn
            // 
            this.itemAddNewBtn.Location = new System.Drawing.Point(403, 541);
            this.itemAddNewBtn.Name = "itemAddNewBtn";
            this.itemAddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.itemAddNewBtn.TabIndex = 22;
            this.itemAddNewBtn.Text = "Add New";
            this.itemAddNewBtn.UseVisualStyleBackColor = true;
            this.itemAddNewBtn.Click += new System.EventHandler(this.itemAddNewBtn_Click);
            // 
            // itemSaveBtn
            // 
            this.itemSaveBtn.Enabled = false;
            this.itemSaveBtn.Location = new System.Drawing.Point(565, 541);
            this.itemSaveBtn.Name = "itemSaveBtn";
            this.itemSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.itemSaveBtn.TabIndex = 16;
            this.itemSaveBtn.Text = "Save";
            this.itemSaveBtn.UseVisualStyleBackColor = true;
            this.itemSaveBtn.Click += new System.EventHandler(this.itemSaveBtn_Click);
            // 
            // accountmasterBindingSource6
            // 
            this.accountmasterBindingSource6.DataMember = "account_master";
            this.accountmasterBindingSource6.DataSource = this.billingFormDataDataSet2;
            // 
            // billingFormDataDataSet2
            // 
            this.billingFormDataDataSet2.DataSetName = "billingFormDataDataSet2";
            this.billingFormDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountmasterBindingSource4
            // 
            this.accountmasterBindingSource4.DataMember = "account_master";
            this.accountmasterBindingSource4.DataSource = this.billingFormDataAccountsDataSet;
            // 
            // accountmasterBindingSource3
            // 
            this.accountmasterBindingSource3.DataMember = "account_master";
            this.accountmasterBindingSource3.DataSource = this.itemMasterListViewDataSetBindingSource;
            // 
            // itemMasterListViewDataSetBindingSource
            // 
            this.itemMasterListViewDataSetBindingSource.DataSource = this.itemMasterListViewDataSet;
            this.itemMasterListViewDataSetBindingSource.Position = 0;
            // 
            // accountmasterBindingSource1
            // 
            this.accountmasterBindingSource1.DataMember = "account_master";
            this.accountmasterBindingSource1.DataSource = this.billingFormDataDataSet2;
            // 
            // accountmasterBindingSource
            // 
            this.accountmasterBindingSource.DataMember = "account_master";
            this.accountmasterBindingSource.DataSource = this.billingFormDataDataSet1;
            // 
            // billingFormDataDataSet1
            // 
            this.billingFormDataDataSet1.DataSetName = "billingFormDataDataSet1";
            this.billingFormDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.Size = new System.Drawing.Size(765, 360);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // billingFormDataDataSet
            // 
            this.billingFormDataDataSet.DataSetName = "billingFormDataDataSet";
            this.billingFormDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // account_masterTableAdapter
            // 
            this.account_masterTableAdapter.ClearBeforeFill = true;
            // 
            // item_unit_tooltip
            // 
            this.item_unit_tooltip.ToolTipTitle = "The item will be measured in terms of this unit (e.g.: kg, dozen)";
            // 
            // account_masterTableAdapter1
            // 
            this.account_masterTableAdapter1.ClearBeforeFill = true;
            // 
            // account_masterTableAdapter2
            // 
            this.account_masterTableAdapter2.ClearBeforeFill = true;
            // 
            // itemmasterBindingSource1
            // 
            this.itemmasterBindingSource1.DataMember = "item_master";
            this.itemmasterBindingSource1.DataSource = this.itemMasterListViewDataSetBindingSource;
            // 
            // item_masterTableAdapter1
            // 
            this.item_masterTableAdapter1.ClearBeforeFill = true;
            // 
            // itemmasterBindingSource
            // 
            this.itemmasterBindingSource.DataMember = "item_master";
            this.itemmasterBindingSource.DataSource = this.billingFormDataDataSet;
            // 
            // item_masterTableAdapter
            // 
            this.item_masterTableAdapter.ClearBeforeFill = true;
            // 
            // account_masterTableAdapter3
            // 
            this.account_masterTableAdapter3.ClearBeforeFill = true;
            // 
            // itemFormExitBtn
            // 
            this.itemFormExitBtn.Location = new System.Drawing.Point(1143, 541);
            this.itemFormExitBtn.Name = "itemFormExitBtn";
            this.itemFormExitBtn.Size = new System.Drawing.Size(75, 23);
            this.itemFormExitBtn.TabIndex = 20;
            this.itemFormExitBtn.Text = "Exit";
            this.itemFormExitBtn.UseVisualStyleBackColor = true;
            this.itemFormExitBtn.Click += new System.EventHandler(this.itemFormExitBtn_Click);
            // 
            // itemFormCancelBtn
            // 
            this.itemFormCancelBtn.Location = new System.Drawing.Point(1062, 541);
            this.itemFormCancelBtn.Name = "itemFormCancelBtn";
            this.itemFormCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.itemFormCancelBtn.TabIndex = 21;
            this.itemFormCancelBtn.Text = "Cancel";
            this.itemFormCancelBtn.UseVisualStyleBackColor = true;
            this.itemFormCancelBtn.Click += new System.EventHandler(this.itemFormCancelBtn_Click);
            // 
            // itemListGBox
            // 
            this.itemListGBox.Controls.Add(this.dataGridView1);
            this.itemListGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListGBox.Location = new System.Drawing.Point(484, 78);
            this.itemListGBox.Name = "itemListGBox";
            this.itemListGBox.Size = new System.Drawing.Size(789, 405);
            this.itemListGBox.TabIndex = 30;
            this.itemListGBox.TabStop = false;
            this.itemListGBox.Text = "Item(s) List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 618);
            this.Controls.Add(this.itemListGBox);
            this.Controls.Add(this.itemDeleteBtn);
            this.Controls.Add(this.itemModifyBtn);
            this.Controls.Add(this.itemFormCancelBtn);
            this.Controls.Add(this.itemAddNewBtn);
            this.Controls.Add(this.itemFormExitBtn);
            this.Controls.Add(this.itemFormGroupBox);
            this.Controls.Add(this.ItemFormHeading);
            this.Controls.Add(this.itemSaveBtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.itemFormGroupBox.ResumeLayout(false);
            this.itemFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterListViewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataAccountsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterListViewDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource)).EndInit();
            this.itemListGBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemFormHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label item_unit_label;
        private System.Windows.Forms.ComboBox item_unit_select;
        private System.Windows.Forms.TextBox item_selling_price;
        private System.Windows.Forms.Label item_selling_price_label;
        private System.Windows.Forms.Label item_account_label;
        private System.Windows.Forms.Label item_description_label;
        private System.Windows.Forms.RichTextBox item_description;
        private System.Windows.Forms.GroupBox itemFormGroupBox;
        private System.Windows.Forms.Button itemSaveBtn;
        private System.Windows.Forms.RadioButton item_type_goods;
        private System.Windows.Forms.RadioButton item_type_service;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.ComboBox item_account_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private billingFormDataDataSet billingFormDataDataSet;
        private System.Windows.Forms.BindingSource itemmasterBindingSource;
        private billingFormDataDataSetTableAdapters.item_masterTableAdapter item_masterTableAdapter;
        private billingFormDataDataSet1 billingFormDataDataSet1;
        private System.Windows.Forms.BindingSource accountmasterBindingSource;
        private billingFormDataDataSet1TableAdapters.account_masterTableAdapter account_masterTableAdapter;
        private System.Windows.Forms.ToolTip item_unit_tooltip;
        private billingFormDataDataSet2 billingFormDataDataSet2;
        private System.Windows.Forms.BindingSource accountmasterBindingSource1;
        private billingFormDataDataSet2TableAdapters.account_masterTableAdapter account_masterTableAdapter1;
        private itemMasterListViewDataSet itemMasterListViewDataSet;
        private System.Windows.Forms.BindingSource itemMasterListViewDataSetBindingSource;
        private System.Windows.Forms.BindingSource accountmasterBindingSource2;
        private itemMasterListViewDataSetTableAdapters.account_masterTableAdapter account_masterTableAdapter2;
        private System.Windows.Forms.BindingSource itemmasterBindingSource1;
        private itemMasterListViewDataSetTableAdapters.item_masterTableAdapter item_masterTableAdapter1;
        private System.Windows.Forms.BindingSource accountmasterBindingSource3;
        private billingFormDataAccountsDataSet billingFormDataAccountsDataSet;
        private System.Windows.Forms.BindingSource accountmasterBindingSource4;
        private billingFormDataAccountsDataSetTableAdapters.account_masterTableAdapter account_masterTableAdapter3;
        private System.Windows.Forms.Button itemAddNewBtn;
        private System.Windows.Forms.Button itemModifyBtn;
        private System.Windows.Forms.Button itemDeleteBtn;
        private System.Windows.Forms.BindingSource accountmasterBindingSource5;
        private System.Windows.Forms.BindingSource accountmasterBindingSource6;
        private System.Windows.Forms.Button itemFormExitBtn;
        private System.Windows.Forms.Button itemFormCancelBtn;
        private System.Windows.Forms.GroupBox itemListGBox;
    }
}


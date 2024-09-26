
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.item_unit_label = new System.Windows.Forms.Label();
            this.item_unit_select = new System.Windows.Forms.ComboBox();
            this.item_selling_price = new System.Windows.Forms.TextBox();
            this.item_selling_price_label = new System.Windows.Forms.Label();
            this.item_account_label = new System.Windows.Forms.Label();
            this.item_description_label = new System.Windows.Forms.Label();
            this.item_description = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.item_account_select = new System.Windows.Forms.ComboBox();
            this.item_name = new System.Windows.Forms.TextBox();
            this.item_name_label = new System.Windows.Forms.Label();
            this.item_type_service = new System.Windows.Forms.RadioButton();
            this.item_type_goods = new System.Windows.Forms.RadioButton();
            this.itemSaveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingFormDataDataSet = new BillingSoftware.billingFormDataDataSet();
            this.item_masterTableAdapter = new BillingSoftware.billingFormDataDataSetTableAdapters.item_masterTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsellingpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingFormDataDataSet1 = new BillingSoftware.billingFormDataDataSet1();
            this.accountmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account_masterTableAdapter = new BillingSoftware.billingFormDataDataSet1TableAdapters.account_masterTableAdapter();
            this.item_unit_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // item_unit_label
            // 
            this.item_unit_label.AutoSize = true;
            this.item_unit_label.Location = new System.Drawing.Point(38, 107);
            this.item_unit_label.Name = "item_unit_label";
            this.item_unit_label.Size = new System.Drawing.Size(26, 13);
            this.item_unit_label.TabIndex = 6;
            this.item_unit_label.Text = "Unit";
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
            this.item_unit_select.Location = new System.Drawing.Point(102, 104);
            this.item_unit_select.Name = "item_unit_select";
            this.item_unit_select.Size = new System.Drawing.Size(170, 21);
            this.item_unit_select.TabIndex = 8;
            // 
            // item_selling_price
            // 
            this.item_selling_price.Location = new System.Drawing.Point(102, 149);
            this.item_selling_price.Name = "item_selling_price";
            this.item_selling_price.Size = new System.Drawing.Size(170, 20);
            this.item_selling_price.TabIndex = 10;
            // 
            // item_selling_price_label
            // 
            this.item_selling_price_label.AutoSize = true;
            this.item_selling_price_label.Location = new System.Drawing.Point(26, 149);
            this.item_selling_price_label.Name = "item_selling_price_label";
            this.item_selling_price_label.Size = new System.Drawing.Size(65, 13);
            this.item_selling_price_label.TabIndex = 9;
            this.item_selling_price_label.Text = "Selling Price";
            // 
            // item_account_label
            // 
            this.item_account_label.AutoSize = true;
            this.item_account_label.Location = new System.Drawing.Point(31, 198);
            this.item_account_label.Name = "item_account_label";
            this.item_account_label.Size = new System.Drawing.Size(47, 13);
            this.item_account_label.TabIndex = 11;
            this.item_account_label.Text = "Account";
            // 
            // item_description_label
            // 
            this.item_description_label.AutoSize = true;
            this.item_description_label.Location = new System.Drawing.Point(31, 244);
            this.item_description_label.Name = "item_description_label";
            this.item_description_label.Size = new System.Drawing.Size(60, 13);
            this.item_description_label.TabIndex = 13;
            this.item_description_label.Text = "Description";
            // 
            // item_description
            // 
            this.item_description.Location = new System.Drawing.Point(102, 244);
            this.item_description.Name = "item_description";
            this.item_description.Size = new System.Drawing.Size(223, 96);
            this.item_description.TabIndex = 15;
            this.item_description.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.item_account_select);
            this.groupBox1.Controls.Add(this.item_name);
            this.groupBox1.Controls.Add(this.item_name_label);
            this.groupBox1.Controls.Add(this.item_type_service);
            this.groupBox1.Controls.Add(this.item_type_goods);
            this.groupBox1.Controls.Add(this.itemSaveBtn);
            this.groupBox1.Controls.Add(this.item_description);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.item_description_label);
            this.groupBox1.Controls.Add(this.item_account_label);
            this.groupBox1.Controls.Add(this.item_selling_price);
            this.groupBox1.Controls.Add(this.item_selling_price_label);
            this.groupBox1.Controls.Add(this.item_unit_label);
            this.groupBox1.Controls.Add(this.item_unit_select);
            this.groupBox1.Location = new System.Drawing.Point(29, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 387);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // item_account_select
            // 
            this.item_account_select.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountmasterBindingSource, "account_name", true));
            this.item_account_select.DataSource = this.accountmasterBindingSource;
            this.item_account_select.DisplayMember = "account_name";
            this.item_account_select.FormattingEnabled = true;
            this.item_account_select.Location = new System.Drawing.Point(102, 195);
            this.item_account_select.Name = "item_account_select";
            this.item_account_select.Size = new System.Drawing.Size(170, 21);
            this.item_account_select.TabIndex = 21;
            this.item_account_select.ValueMember = "account_name";
            // 
            // item_name
            // 
            this.item_name.Location = new System.Drawing.Point(102, 69);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(170, 20);
            this.item_name.TabIndex = 20;
            // 
            // item_name_label
            // 
            this.item_name_label.AutoSize = true;
            this.item_name_label.Location = new System.Drawing.Point(38, 69);
            this.item_name_label.Name = "item_name_label";
            this.item_name_label.Size = new System.Drawing.Size(35, 13);
            this.item_name_label.TabIndex = 19;
            this.item_name_label.Text = "Name";
            // 
            // item_type_service
            // 
            this.item_type_service.AccessibleName = "";
            this.item_type_service.AutoSize = true;
            this.item_type_service.Location = new System.Drawing.Point(216, 34);
            this.item_type_service.Name = "item_type_service";
            this.item_type_service.Size = new System.Drawing.Size(61, 17);
            this.item_type_service.TabIndex = 18;
            this.item_type_service.TabStop = true;
            this.item_type_service.Text = "Service";
            this.item_type_service.UseVisualStyleBackColor = true;
            // 
            // item_type_goods
            // 
            this.item_type_goods.AccessibleName = "ItemTypeGoods";
            this.item_type_goods.AutoSize = true;
            this.item_type_goods.Location = new System.Drawing.Point(102, 34);
            this.item_type_goods.Name = "item_type_goods";
            this.item_type_goods.Size = new System.Drawing.Size(56, 17);
            this.item_type_goods.TabIndex = 17;
            this.item_type_goods.TabStop = true;
            this.item_type_goods.Text = "Goods";
            this.item_type_goods.UseVisualStyleBackColor = true;
            this.item_type_goods.CheckedChanged += new System.EventHandler(this.item_type_goods_CheckedChanged_1);
            // 
            // itemSaveBtn
            // 
            this.itemSaveBtn.Location = new System.Drawing.Point(338, 356);
            this.itemSaveBtn.Name = "itemSaveBtn";
            this.itemSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.itemSaveBtn.TabIndex = 16;
            this.itemSaveBtn.Text = "Save";
            this.itemSaveBtn.UseVisualStyleBackColor = true;
            this.itemSaveBtn.Click += new System.EventHandler(this.itemSaveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemtypeDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.itemunitDataGridViewTextBoxColumn,
            this.itemsellingpriceDataGridViewTextBoxColumn,
            this.itemaccountDataGridViewTextBoxColumn,
            this.itemdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemmasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(475, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 387);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // itemmasterBindingSource
            // 
            this.itemmasterBindingSource.DataMember = "item_master";
            this.itemmasterBindingSource.DataSource = this.billingFormDataDataSet;
            // 
            // billingFormDataDataSet
            // 
            this.billingFormDataDataSet.DataSetName = "billingFormDataDataSet";
            this.billingFormDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // item_masterTableAdapter
            // 
            this.item_masterTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Sl. No";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemtypeDataGridViewTextBoxColumn
            // 
            this.itemtypeDataGridViewTextBoxColumn.DataPropertyName = "item_type";
            this.itemtypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.itemtypeDataGridViewTextBoxColumn.Name = "itemtypeDataGridViewTextBoxColumn";
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // itemunitDataGridViewTextBoxColumn
            // 
            this.itemunitDataGridViewTextBoxColumn.DataPropertyName = "item_unit";
            this.itemunitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.itemunitDataGridViewTextBoxColumn.Name = "itemunitDataGridViewTextBoxColumn";
            // 
            // itemsellingpriceDataGridViewTextBoxColumn
            // 
            this.itemsellingpriceDataGridViewTextBoxColumn.DataPropertyName = "item_selling_price";
            this.itemsellingpriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.itemsellingpriceDataGridViewTextBoxColumn.Name = "itemsellingpriceDataGridViewTextBoxColumn";
            // 
            // itemaccountDataGridViewTextBoxColumn
            // 
            this.itemaccountDataGridViewTextBoxColumn.DataPropertyName = "item_account";
            this.itemaccountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.itemaccountDataGridViewTextBoxColumn.Name = "itemaccountDataGridViewTextBoxColumn";
            // 
            // itemdescriptionDataGridViewTextBoxColumn
            // 
            this.itemdescriptionDataGridViewTextBoxColumn.DataPropertyName = "item_description";
            this.itemdescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.itemdescriptionDataGridViewTextBoxColumn.Name = "itemdescriptionDataGridViewTextBoxColumn";
            // 
            // billingFormDataDataSet1
            // 
            this.billingFormDataDataSet1.DataSetName = "billingFormDataDataSet1";
            this.billingFormDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountmasterBindingSource
            // 
            this.accountmasterBindingSource.DataMember = "account_master";
            this.accountmasterBindingSource.DataSource = this.billingFormDataDataSet1;
            // 
            // account_masterTableAdapter
            // 
            this.account_masterTableAdapter.ClearBeforeFill = true;
            // 
            // item_unit_tooltip
            // 
            this.item_unit_tooltip.ToolTipTitle = "The item will be measured in terms of this unit (e.g.: kg, dozen)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingFormDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountmasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label item_unit_label;
        private System.Windows.Forms.ComboBox item_unit_select;
        private System.Windows.Forms.TextBox item_selling_price;
        private System.Windows.Forms.Label item_selling_price_label;
        private System.Windows.Forms.Label item_account_label;
        private System.Windows.Forms.Label item_description_label;
        private System.Windows.Forms.RichTextBox item_description;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsellingpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescriptionDataGridViewTextBoxColumn;
        private billingFormDataDataSet1 billingFormDataDataSet1;
        private System.Windows.Forms.BindingSource accountmasterBindingSource;
        private billingFormDataDataSet1TableAdapters.account_masterTableAdapter account_masterTableAdapter;
        private System.Windows.Forms.ToolTip item_unit_tooltip;
    }
}


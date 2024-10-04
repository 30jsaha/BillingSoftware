namespace BillingSoftware
{
    partial class currencyForm
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
            this.currency_groupBox = new System.Windows.Forms.GroupBox();
            this.currency_details = new System.Windows.Forms.TextBox();
            this.currency_details_label = new System.Windows.Forms.Label();
            this.currency_name = new System.Windows.Forms.TextBox();
            this.currency_name_label = new System.Windows.Forms.Label();
            this.currencyGbox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currencyFormCancelBtn = new System.Windows.Forms.Button();
            this.currencyFormExitBtn = new System.Windows.Forms.Button();
            this.currencyRemoveBtn = new System.Windows.Forms.Button();
            this.currencySaveBtn = new System.Windows.Forms.Button();
            this.currencyAddNewBtn = new System.Windows.Forms.Button();
            this.currencyModifyBtn = new System.Windows.Forms.Button();
            this.currency_groupBox.SuspendLayout();
            this.currencyGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // currency_groupBox
            // 
            this.currency_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.currency_groupBox.Controls.Add(this.currency_details);
            this.currency_groupBox.Controls.Add(this.currency_details_label);
            this.currency_groupBox.Controls.Add(this.currency_name);
            this.currency_groupBox.Controls.Add(this.currency_name_label);
            this.currency_groupBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_groupBox.Location = new System.Drawing.Point(41, 124);
            this.currency_groupBox.Name = "currency_groupBox";
            this.currency_groupBox.Size = new System.Drawing.Size(344, 217);
            this.currency_groupBox.TabIndex = 18;
            this.currency_groupBox.TabStop = false;
            this.currency_groupBox.Text = "Currency Details";
            // 
            // currency_details
            // 
            this.currency_details.Location = new System.Drawing.Point(106, 112);
            this.currency_details.Name = "currency_details";
            this.currency_details.Size = new System.Drawing.Size(217, 22);
            this.currency_details.TabIndex = 22;
            // 
            // currency_details_label
            // 
            this.currency_details_label.AutoSize = true;
            this.currency_details_label.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_details_label.Location = new System.Drawing.Point(6, 112);
            this.currency_details_label.Name = "currency_details_label";
            this.currency_details_label.Size = new System.Drawing.Size(92, 16);
            this.currency_details_label.TabIndex = 21;
            this.currency_details_label.Text = "Currency Details";
            // 
            // currency_name
            // 
            this.currency_name.Location = new System.Drawing.Point(106, 66);
            this.currency_name.Name = "currency_name";
            this.currency_name.Size = new System.Drawing.Size(217, 22);
            this.currency_name.TabIndex = 20;
            // 
            // currency_name_label
            // 
            this.currency_name_label.AutoSize = true;
            this.currency_name_label.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_name_label.Location = new System.Drawing.Point(6, 69);
            this.currency_name_label.Name = "currency_name_label";
            this.currency_name_label.Size = new System.Drawing.Size(88, 16);
            this.currency_name_label.TabIndex = 19;
            this.currency_name_label.Text = "Currency Name";
            // 
            // currencyGbox
            // 
            this.currencyGbox.Controls.Add(this.dataGridView1);
            this.currencyGbox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyGbox.Location = new System.Drawing.Point(428, 76);
            this.currencyGbox.Name = "currencyGbox";
            this.currencyGbox.Size = new System.Drawing.Size(503, 298);
            this.currencyGbox.TabIndex = 25;
            this.currencyGbox.TabStop = false;
            this.currencyGbox.Text = "Currency List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Location = new System.Drawing.Point(13, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 150;
            this.dataGridView1.Size = new System.Drawing.Size(478, 263);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // currencyFormCancelBtn
            // 
            this.currencyFormCancelBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyFormCancelBtn.Location = new System.Drawing.Point(775, 403);
            this.currencyFormCancelBtn.Name = "currencyFormCancelBtn";
            this.currencyFormCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.currencyFormCancelBtn.TabIndex = 31;
            this.currencyFormCancelBtn.Text = "Cancel";
            this.currencyFormCancelBtn.UseVisualStyleBackColor = true;
            this.currencyFormCancelBtn.Click += new System.EventHandler(this.currencyFormCancelBtn_Click);
            // 
            // currencyFormExitBtn
            // 
            this.currencyFormExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyFormExitBtn.Location = new System.Drawing.Point(856, 403);
            this.currencyFormExitBtn.Name = "currencyFormExitBtn";
            this.currencyFormExitBtn.Size = new System.Drawing.Size(75, 23);
            this.currencyFormExitBtn.TabIndex = 30;
            this.currencyFormExitBtn.Text = "Exit";
            this.currencyFormExitBtn.UseVisualStyleBackColor = true;
            this.currencyFormExitBtn.Click += new System.EventHandler(this.currencyFormExitBtn_Click);
            // 
            // currencyRemoveBtn
            // 
            this.currencyRemoveBtn.Enabled = false;
            this.currencyRemoveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyRemoveBtn.Location = new System.Drawing.Point(509, 403);
            this.currencyRemoveBtn.Name = "currencyRemoveBtn";
            this.currencyRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.currencyRemoveBtn.TabIndex = 29;
            this.currencyRemoveBtn.Text = "Remove";
            this.currencyRemoveBtn.UseVisualStyleBackColor = true;
            this.currencyRemoveBtn.Click += new System.EventHandler(this.currencyRemoveBtn_Click);
            // 
            // currencySaveBtn
            // 
            this.currencySaveBtn.Enabled = false;
            this.currencySaveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencySaveBtn.Location = new System.Drawing.Point(347, 403);
            this.currencySaveBtn.Name = "currencySaveBtn";
            this.currencySaveBtn.Size = new System.Drawing.Size(75, 23);
            this.currencySaveBtn.TabIndex = 26;
            this.currencySaveBtn.Text = "Save";
            this.currencySaveBtn.UseVisualStyleBackColor = true;
            this.currencySaveBtn.Click += new System.EventHandler(this.currencySaveBtn_Click);
            // 
            // currencyAddNewBtn
            // 
            this.currencyAddNewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyAddNewBtn.Location = new System.Drawing.Point(266, 403);
            this.currencyAddNewBtn.Name = "currencyAddNewBtn";
            this.currencyAddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.currencyAddNewBtn.TabIndex = 28;
            this.currencyAddNewBtn.Text = "+ Add New";
            this.currencyAddNewBtn.UseVisualStyleBackColor = true;
            this.currencyAddNewBtn.Click += new System.EventHandler(this.currencyAddNewBtn_Click);
            // 
            // currencyModifyBtn
            // 
            this.currencyModifyBtn.Enabled = false;
            this.currencyModifyBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyModifyBtn.Location = new System.Drawing.Point(428, 403);
            this.currencyModifyBtn.Name = "currencyModifyBtn";
            this.currencyModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.currencyModifyBtn.TabIndex = 27;
            this.currencyModifyBtn.Text = "Modify";
            this.currencyModifyBtn.UseVisualStyleBackColor = true;
            this.currencyModifyBtn.Click += new System.EventHandler(this.currencyModifyBtn_Click);
            // 
            // currencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.currencyFormCancelBtn);
            this.Controls.Add(this.currencyFormExitBtn);
            this.Controls.Add(this.currencyRemoveBtn);
            this.Controls.Add(this.currencySaveBtn);
            this.Controls.Add(this.currencyAddNewBtn);
            this.Controls.Add(this.currencyModifyBtn);
            this.Controls.Add(this.currencyGbox);
            this.Controls.Add(this.currency_groupBox);
            this.Name = "currencyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Currency";
            this.Load += new System.EventHandler(this.currencyForm_Load);
            this.currency_groupBox.ResumeLayout(false);
            this.currency_groupBox.PerformLayout();
            this.currencyGbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox currency_groupBox;
        private System.Windows.Forms.TextBox currency_name;
        private System.Windows.Forms.Label currency_name_label;
        private System.Windows.Forms.GroupBox currencyGbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox currency_details;
        private System.Windows.Forms.Label currency_details_label;
        private System.Windows.Forms.Button currencyFormCancelBtn;
        private System.Windows.Forms.Button currencyFormExitBtn;
        private System.Windows.Forms.Button currencyRemoveBtn;
        private System.Windows.Forms.Button currencySaveBtn;
        private System.Windows.Forms.Button currencyAddNewBtn;
        private System.Windows.Forms.Button currencyModifyBtn;
    }
}
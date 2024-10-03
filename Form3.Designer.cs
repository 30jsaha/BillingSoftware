namespace BillingSoftware
{
    partial class Form3
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
            this.customerAddNewBtn = new System.Windows.Forms.Button();
            this.customerListGBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerCancelBtn = new System.Windows.Forms.Button();
            this.customerModifyBtn = new System.Windows.Forms.Button();
            this.custRemoveBtn = new System.Windows.Forms.Button();
            this.customerListGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerAddNewBtn
            // 
            this.customerAddNewBtn.Location = new System.Drawing.Point(586, 462);
            this.customerAddNewBtn.Name = "customerAddNewBtn";
            this.customerAddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.customerAddNewBtn.TabIndex = 0;
            this.customerAddNewBtn.Text = "Add New";
            this.customerAddNewBtn.UseVisualStyleBackColor = true;
            this.customerAddNewBtn.Click += new System.EventHandler(this.customerAddNewBtn_Click);
            // 
            // customerListGBox
            // 
            this.customerListGBox.Controls.Add(this.dataGridView1);
            this.customerListGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListGBox.Location = new System.Drawing.Point(24, 28);
            this.customerListGBox.Name = "customerListGBox";
            this.customerListGBox.Size = new System.Drawing.Size(1388, 405);
            this.customerListGBox.TabIndex = 31;
            this.customerListGBox.TabStop = false;
            this.customerListGBox.Text = "Customer(s) List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 150;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 360);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // customerCancelBtn
            // 
            this.customerCancelBtn.Location = new System.Drawing.Point(829, 462);
            this.customerCancelBtn.Name = "customerCancelBtn";
            this.customerCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.customerCancelBtn.TabIndex = 32;
            this.customerCancelBtn.Text = "Cancel";
            this.customerCancelBtn.UseVisualStyleBackColor = true;
            this.customerCancelBtn.Click += new System.EventHandler(this.customerCancelBtn_Click);
            // 
            // customerModifyBtn
            // 
            this.customerModifyBtn.Enabled = false;
            this.customerModifyBtn.Location = new System.Drawing.Point(667, 462);
            this.customerModifyBtn.Name = "customerModifyBtn";
            this.customerModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.customerModifyBtn.TabIndex = 33;
            this.customerModifyBtn.Text = "Modify";
            this.customerModifyBtn.UseVisualStyleBackColor = true;
            this.customerModifyBtn.Click += new System.EventHandler(this.customerModifyBtn_Click);
            // 
            // custRemoveBtn
            // 
            this.custRemoveBtn.Enabled = false;
            this.custRemoveBtn.Location = new System.Drawing.Point(748, 462);
            this.custRemoveBtn.Name = "custRemoveBtn";
            this.custRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.custRemoveBtn.TabIndex = 34;
            this.custRemoveBtn.Text = "Remove";
            this.custRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 497);
            this.Controls.Add(this.custRemoveBtn);
            this.Controls.Add(this.customerModifyBtn);
            this.Controls.Add(this.customerCancelBtn);
            this.Controls.Add(this.customerListGBox);
            this.Controls.Add(this.customerAddNewBtn);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.customerListGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerAddNewBtn;
        private System.Windows.Forms.GroupBox customerListGBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button customerCancelBtn;
        private System.Windows.Forms.Button customerModifyBtn;
        private System.Windows.Forms.Button custRemoveBtn;
    }
}
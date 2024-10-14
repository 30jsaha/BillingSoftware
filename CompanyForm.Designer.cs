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
            this.createCompanyGbox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.createCompanyGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCompanyGbox
            // 
            this.createCompanyGbox.Controls.Add(this.dateTimePicker1);
            this.createCompanyGbox.Location = new System.Drawing.Point(31, 23);
            this.createCompanyGbox.Name = "createCompanyGbox";
            this.createCompanyGbox.Size = new System.Drawing.Size(609, 415);
            this.createCompanyGbox.TabIndex = 0;
            this.createCompanyGbox.TabStop = false;
            this.createCompanyGbox.Text = "Company Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 489);
            this.Controls.Add(this.createCompanyGbox);
            this.Name = "CompanyForm";
            this.Text = "Manage Company";
            this.createCompanyGbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createCompanyGbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
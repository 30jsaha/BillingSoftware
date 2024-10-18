namespace BillingSoftware
{
    partial class beginningForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appLoginBtn = new System.Windows.Forms.Button();
            this.appCompRegisterBtn = new System.Windows.Forms.Button();
            this.appExitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select an option to begin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.appCompRegisterBtn);
            this.groupBox1.Controls.Add(this.appLoginBtn);
            this.groupBox1.Location = new System.Drawing.Point(73, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options to start";
            // 
            // appLoginBtn
            // 
            this.appLoginBtn.Location = new System.Drawing.Point(137, 46);
            this.appLoginBtn.Name = "appLoginBtn";
            this.appLoginBtn.Size = new System.Drawing.Size(103, 40);
            this.appLoginBtn.TabIndex = 0;
            this.appLoginBtn.Text = "Login to account";
            this.appLoginBtn.UseVisualStyleBackColor = true;
            this.appLoginBtn.Click += new System.EventHandler(this.appLoginBtn_Click);
            // 
            // appCompRegisterBtn
            // 
            this.appCompRegisterBtn.Location = new System.Drawing.Point(137, 129);
            this.appCompRegisterBtn.Name = "appCompRegisterBtn";
            this.appCompRegisterBtn.Size = new System.Drawing.Size(103, 40);
            this.appCompRegisterBtn.TabIndex = 1;
            this.appCompRegisterBtn.Text = "Register Company";
            this.appCompRegisterBtn.UseVisualStyleBackColor = true;
            this.appCompRegisterBtn.Click += new System.EventHandler(this.appCompRegisterBtn_Click);
            // 
            // appExitBtn
            // 
            this.appExitBtn.Location = new System.Drawing.Point(426, 319);
            this.appExitBtn.Name = "appExitBtn";
            this.appExitBtn.Size = new System.Drawing.Size(75, 23);
            this.appExitBtn.TabIndex = 2;
            this.appExitBtn.Text = "Exit";
            this.appExitBtn.UseVisualStyleBackColor = true;
            this.appExitBtn.Click += new System.EventHandler(this.appExitBtn_Click);
            // 
            // beginningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 354);
            this.Controls.Add(this.appExitBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "beginningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please select an option to begin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button appLoginBtn;
        private System.Windows.Forms.Button appCompRegisterBtn;
        private System.Windows.Forms.Button appExitBtn;
    }
}
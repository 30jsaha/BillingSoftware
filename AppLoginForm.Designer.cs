namespace BillingSoftware
{
    partial class AppLoginForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginCompanySelect = new System.Windows.Forms.ComboBox();
            this.appLoginCancelBtn = new System.Windows.Forms.Button();
            this.appLoginBtn = new System.Windows.Forms.Button();
            this.appLoginPwdInpt = new System.Windows.Forms.TextBox();
            this.appLoginUserIdInpt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appLoginExitBtn = new System.Windows.Forms.Button();
            this.appCompRegisterBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.loginCompanySelect);
            this.groupBox1.Controls.Add(this.appLoginCancelBtn);
            this.groupBox1.Controls.Add(this.appLoginBtn);
            this.groupBox1.Controls.Add(this.appLoginPwdInpt);
            this.groupBox1.Controls.Add(this.appLoginUserIdInpt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Credential";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Select Company";
            // 
            // loginCompanySelect
            // 
            this.loginCompanySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginCompanySelect.FormattingEnabled = true;
            this.loginCompanySelect.Location = new System.Drawing.Point(158, 145);
            this.loginCompanySelect.Name = "loginCompanySelect";
            this.loginCompanySelect.Size = new System.Drawing.Size(212, 21);
            this.loginCompanySelect.TabIndex = 26;
            // 
            // appLoginCancelBtn
            // 
            this.appLoginCancelBtn.Location = new System.Drawing.Point(230, 199);
            this.appLoginCancelBtn.Name = "appLoginCancelBtn";
            this.appLoginCancelBtn.Size = new System.Drawing.Size(94, 35);
            this.appLoginCancelBtn.TabIndex = 5;
            this.appLoginCancelBtn.Text = "Cancel";
            this.appLoginCancelBtn.UseVisualStyleBackColor = true;
            this.appLoginCancelBtn.Click += new System.EventHandler(this.appLoginCancelBtn_Click);
            // 
            // appLoginBtn
            // 
            this.appLoginBtn.Location = new System.Drawing.Point(115, 199);
            this.appLoginBtn.Name = "appLoginBtn";
            this.appLoginBtn.Size = new System.Drawing.Size(94, 35);
            this.appLoginBtn.TabIndex = 4;
            this.appLoginBtn.Text = "Log in";
            this.appLoginBtn.UseVisualStyleBackColor = true;
            this.appLoginBtn.Click += new System.EventHandler(this.appLoginBtn_Click);
            // 
            // appLoginPwdInpt
            // 
            this.appLoginPwdInpt.Location = new System.Drawing.Point(158, 95);
            this.appLoginPwdInpt.Name = "appLoginPwdInpt";
            this.appLoginPwdInpt.Size = new System.Drawing.Size(212, 20);
            this.appLoginPwdInpt.TabIndex = 3;
            // 
            // appLoginUserIdInpt
            // 
            this.appLoginUserIdInpt.Location = new System.Drawing.Point(157, 42);
            this.appLoginUserIdInpt.Name = "appLoginUserIdInpt";
            this.appLoginUserIdInpt.Size = new System.Drawing.Size(213, 20);
            this.appLoginUserIdInpt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the correct user id, and password to login your account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login to your Account";
            // 
            // appLoginExitBtn
            // 
            this.appLoginExitBtn.Location = new System.Drawing.Point(408, 356);
            this.appLoginExitBtn.Name = "appLoginExitBtn";
            this.appLoginExitBtn.Size = new System.Drawing.Size(75, 23);
            this.appLoginExitBtn.TabIndex = 3;
            this.appLoginExitBtn.Text = "Exit";
            this.appLoginExitBtn.UseVisualStyleBackColor = true;
            this.appLoginExitBtn.Click += new System.EventHandler(this.appLoginExitBtn_Click);
            // 
            // appCompRegisterBtn
            // 
            this.appCompRegisterBtn.Location = new System.Drawing.Point(297, 356);
            this.appCompRegisterBtn.Name = "appCompRegisterBtn";
            this.appCompRegisterBtn.Size = new System.Drawing.Size(105, 23);
            this.appCompRegisterBtn.TabIndex = 4;
            this.appCompRegisterBtn.Text = "Create Company";
            this.appCompRegisterBtn.UseVisualStyleBackColor = true;
            this.appCompRegisterBtn.Click += new System.EventHandler(this.appCompRegisterBtn_Click);
            // 
            // AppLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 390);
            this.Controls.Add(this.appCompRegisterBtn);
            this.Controls.Add(this.appLoginExitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppLoginForm";
            this.Load += new System.EventHandler(this.AppLoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button appLoginCancelBtn;
        private System.Windows.Forms.Button appLoginBtn;
        private System.Windows.Forms.TextBox appLoginPwdInpt;
        private System.Windows.Forms.TextBox appLoginUserIdInpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button appLoginExitBtn;
        private System.Windows.Forms.Button appCompRegisterBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox loginCompanySelect;
    }
}
namespace Vehicle_Number_Plate_Detection
{
    partial class RegisterUser
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
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.btnCancel);
            this.grpRegister.Controls.Add(this.btnSubmit);
            this.grpRegister.Controls.Add(this.txtEmail);
            this.grpRegister.Controls.Add(this.lblEmail);
            this.grpRegister.Controls.Add(this.txtPassword);
            this.grpRegister.Controls.Add(this.lblPassword);
            this.grpRegister.Controls.Add(this.txtUsername);
            this.grpRegister.Controls.Add(this.lblUserName);
            this.grpRegister.Location = new System.Drawing.Point(43, 25);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(330, 365);
            this.grpRegister.TabIndex = 0;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Register";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(19, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(86, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Enter Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(135, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(126, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(126, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Create Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(104, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Enter Email Address:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(47, 294);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 43);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 425);
            this.Controls.Add(this.grpRegister);
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUserName;
    }
}
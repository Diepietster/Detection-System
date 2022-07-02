namespace Vehicle_Number_Plate_Detection
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detectNumberPlateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblLoginAttempt = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.addVehicleToolStripMenuItem1,
            this.detectNumberPlateToolStripMenuItem,
            this.deleteVehicleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addVehicleToolStripMenuItem.Text = "Search Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // addVehicleToolStripMenuItem1
            // 
            this.addVehicleToolStripMenuItem1.Name = "addVehicleToolStripMenuItem1";
            this.addVehicleToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.addVehicleToolStripMenuItem1.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem1.Click += new System.EventHandler(this.addVehicleToolStripMenuItem1_Click);
            // 
            // detectNumberPlateToolStripMenuItem
            // 
            this.detectNumberPlateToolStripMenuItem.Name = "detectNumberPlateToolStripMenuItem";
            this.detectNumberPlateToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.detectNumberPlateToolStripMenuItem.Text = "Detect Number Plate";
            this.detectNumberPlateToolStripMenuItem.Click += new System.EventHandler(this.detectNumberPlateToolStripMenuItem_Click);
            // 
            // deleteVehicleToolStripMenuItem
            // 
            this.deleteVehicleToolStripMenuItem.Name = "deleteVehicleToolStripMenuItem";
            this.deleteVehicleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteVehicleToolStripMenuItem.Text = "Delete Vehicle";
            this.deleteVehicleToolStripMenuItem.Click += new System.EventHandler(this.deleteVehicleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(20, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(206, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lblLoginAttempt);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Location = new System.Drawing.Point(306, 111);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(428, 339);
            this.grpLogin.TabIndex = 7;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // lblLoginAttempt
            // 
            this.lblLoginAttempt.AutoSize = true;
            this.lblLoginAttempt.Location = new System.Drawing.Point(23, 168);
            this.lblLoginAttempt.Name = "lblLoginAttempt";
            this.lblLoginAttempt.Size = new System.Drawing.Size(0, 13);
            this.lblLoginAttempt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 555);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detectNumberPlateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginAttempt;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
    }
}


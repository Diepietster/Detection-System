namespace Vehicle_Number_Plate_Detection
{
    partial class AddVehicle
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
            this.grpAddVehicle = new System.Windows.Forms.GroupBox();
            this.lblAddVehicle = new System.Windows.Forms.Label();
            this.txtAddVehicle = new System.Windows.Forms.TextBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.grpAddVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddVehicle
            // 
            this.grpAddVehicle.Controls.Add(this.btnAddVehicle);
            this.grpAddVehicle.Controls.Add(this.txtAddVehicle);
            this.grpAddVehicle.Controls.Add(this.lblAddVehicle);
            this.grpAddVehicle.Location = new System.Drawing.Point(12, 12);
            this.grpAddVehicle.Name = "grpAddVehicle";
            this.grpAddVehicle.Size = new System.Drawing.Size(317, 244);
            this.grpAddVehicle.TabIndex = 0;
            this.grpAddVehicle.TabStop = false;
            this.grpAddVehicle.Text = "Add Vehicle:";
            // 
            // lblAddVehicle
            // 
            this.lblAddVehicle.AutoSize = true;
            this.lblAddVehicle.Location = new System.Drawing.Point(7, 67);
            this.lblAddVehicle.Name = "lblAddVehicle";
            this.lblAddVehicle.Size = new System.Drawing.Size(140, 13);
            this.lblAddVehicle.TabIndex = 0;
            this.lblAddVehicle.Text = "Enter Vehicle Number Plate:";
            // 
            // txtAddVehicle
            // 
            this.txtAddVehicle.Location = new System.Drawing.Point(51, 103);
            this.txtAddVehicle.Name = "txtAddVehicle";
            this.txtAddVehicle.Size = new System.Drawing.Size(195, 20);
            this.txtAddVehicle.TabIndex = 1;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(62, 171);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(172, 43);
            this.btnAddVehicle.TabIndex = 2;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 268);
            this.Controls.Add(this.grpAddVehicle);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.grpAddVehicle.ResumeLayout(false);
            this.grpAddVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TextBox txtAddVehicle;
        private System.Windows.Forms.Label lblAddVehicle;
    }
}
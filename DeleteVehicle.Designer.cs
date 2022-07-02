namespace Vehicle_Number_Plate_Detection
{
    partial class DeleteVehicle
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.grpDeleteVehicle = new System.Windows.Forms.GroupBox();
            this.lblDeleteVehcle = new System.Windows.Forms.Label();
            this.txtDeletevehicle = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.grpDeleteVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(255, 281);
            this.dataGrid.TabIndex = 0;
            // 
            // grpDeleteVehicle
            // 
            this.grpDeleteVehicle.Controls.Add(this.btnDelete);
            this.grpDeleteVehicle.Controls.Add(this.txtDeletevehicle);
            this.grpDeleteVehicle.Controls.Add(this.lblDeleteVehcle);
            this.grpDeleteVehicle.Location = new System.Drawing.Point(288, 12);
            this.grpDeleteVehicle.Name = "grpDeleteVehicle";
            this.grpDeleteVehicle.Size = new System.Drawing.Size(231, 204);
            this.grpDeleteVehicle.TabIndex = 1;
            this.grpDeleteVehicle.TabStop = false;
            this.grpDeleteVehicle.Text = "Delete Vehicle:";
            // 
            // lblDeleteVehcle
            // 
            this.lblDeleteVehcle.AutoSize = true;
            this.lblDeleteVehcle.Location = new System.Drawing.Point(16, 34);
            this.lblDeleteVehcle.Name = "lblDeleteVehcle";
            this.lblDeleteVehcle.Size = new System.Drawing.Size(152, 13);
            this.lblDeleteVehcle.TabIndex = 0;
            this.lblDeleteVehcle.Text = "Enter Number Plate of Vehicle:";
            // 
            // txtDeletevehicle
            // 
            this.txtDeletevehicle.Location = new System.Drawing.Point(45, 65);
            this.txtDeletevehicle.Name = "txtDeletevehicle";
            this.txtDeletevehicle.Size = new System.Drawing.Size(137, 20);
            this.txtDeletevehicle.TabIndex = 1;
            this.txtDeletevehicle.TextChanged += new System.EventHandler(this.txtDeletevehicle_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(45, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Vehicle";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DeleteVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 326);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDeleteVehicle);
            this.Controls.Add(this.dataGrid);
            this.Name = "DeleteVehicle";
            this.Text = "DeleteVehicle";
            this.Load += new System.EventHandler(this.DeleteVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.grpDeleteVehicle.ResumeLayout(false);
            this.grpDeleteVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox grpDeleteVehicle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeletevehicle;
        private System.Windows.Forms.Label lblDeleteVehcle;
        private System.Windows.Forms.Button btnExit;
    }
}
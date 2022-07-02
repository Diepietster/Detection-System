namespace Vehicle_Number_Plate_Detection
{
    partial class SearchVehicle
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
            this.dataGridSearch = new System.Windows.Forms.DataGridView();
            this.grpSearchVehicle = new System.Windows.Forms.GroupBox();
            this.chckStolen = new System.Windows.Forms.CheckBox();
            this.chckAllowed = new System.Windows.Forms.CheckBox();
            this.lblSearchVehicle = new System.Windows.Forms.Label();
            this.txtSearchVehicle = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            this.grpSearchVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Location = new System.Drawing.Point(12, 12);
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.Size = new System.Drawing.Size(397, 273);
            this.dataGridSearch.TabIndex = 0;
            // 
            // grpSearchVehicle
            // 
            this.grpSearchVehicle.Controls.Add(this.btnSearch);
            this.grpSearchVehicle.Controls.Add(this.btnExit);
            this.grpSearchVehicle.Controls.Add(this.label1);
            this.grpSearchVehicle.Controls.Add(this.chckStolen);
            this.grpSearchVehicle.Controls.Add(this.chckAllowed);
            this.grpSearchVehicle.Controls.Add(this.lblSearchVehicle);
            this.grpSearchVehicle.Controls.Add(this.txtSearchVehicle);
            this.grpSearchVehicle.Location = new System.Drawing.Point(436, 12);
            this.grpSearchVehicle.Name = "grpSearchVehicle";
            this.grpSearchVehicle.Size = new System.Drawing.Size(252, 273);
            this.grpSearchVehicle.TabIndex = 1;
            this.grpSearchVehicle.TabStop = false;
            this.grpSearchVehicle.Text = "Search Vehicle:";
            // 
            // chckStolen
            // 
            this.chckStolen.AutoSize = true;
            this.chckStolen.Location = new System.Drawing.Point(62, 179);
            this.chckStolen.Name = "chckStolen";
            this.chckStolen.Size = new System.Drawing.Size(69, 17);
            this.chckStolen.TabIndex = 5;
            this.chckStolen.Text = "STOLEN";
            this.chckStolen.UseVisualStyleBackColor = true;
            // 
            // chckAllowed
            // 
            this.chckAllowed.AutoSize = true;
            this.chckAllowed.Location = new System.Drawing.Point(62, 147);
            this.chckAllowed.Name = "chckAllowed";
            this.chckAllowed.Size = new System.Drawing.Size(79, 17);
            this.chckAllowed.TabIndex = 4;
            this.chckAllowed.Text = "ALLOWED";
            this.chckAllowed.UseVisualStyleBackColor = true;
            // 
            // lblSearchVehicle
            // 
            this.lblSearchVehicle.AutoSize = true;
            this.lblSearchVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchVehicle.Location = new System.Drawing.Point(14, 29);
            this.lblSearchVehicle.Name = "lblSearchVehicle";
            this.lblSearchVehicle.Size = new System.Drawing.Size(175, 13);
            this.lblSearchVehicle.TabIndex = 1;
            this.lblSearchVehicle.Text = "Type in vehicle number plate:";
            // 
            // txtSearchVehicle
            // 
            this.txtSearchVehicle.Location = new System.Drawing.Point(17, 56);
            this.txtSearchVehicle.Name = "txtSearchVehicle";
            this.txtSearchVehicle.Size = new System.Drawing.Size(163, 20);
            this.txtSearchVehicle.TabIndex = 0;
            this.txtSearchVehicle.TextChanged += new System.EventHandler(this.txtSearchVehicle_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(134, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Vehicle by Security Clearance:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 31);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 297);
            this.Controls.Add(this.grpSearchVehicle);
            this.Controls.Add(this.dataGridSearch);
            this.Name = "SearchVehicle";
            this.Text = "SearchVehicle";
            this.Load += new System.EventHandler(this.SearchVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
            this.grpSearchVehicle.ResumeLayout(false);
            this.grpSearchVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearch;
        private System.Windows.Forms.GroupBox grpSearchVehicle;
        private System.Windows.Forms.Label lblSearchVehicle;
        private System.Windows.Forms.TextBox txtSearchVehicle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chckStolen;
        private System.Windows.Forms.CheckBox chckAllowed;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}
namespace Vehicle_Number_Plate_Detection
{
    partial class Detection
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
            this.grpAuthenticate = new System.Windows.Forms.GroupBox();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.txtAuthenticate = new System.Windows.Forms.TextBox();
            this.lblAuthenticate = new System.Windows.Forms.Label();
            this.grpUploadImage = new System.Windows.Forms.GroupBox();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.lblUploadImage = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridAuthenticate = new System.Windows.Forms.DataGridView();
            this.grpAuthenticate.SuspendLayout();
            this.grpUploadImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthenticate)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAuthenticate
            // 
            this.grpAuthenticate.Controls.Add(this.btnAuthenticate);
            this.grpAuthenticate.Controls.Add(this.txtAuthenticate);
            this.grpAuthenticate.Controls.Add(this.lblAuthenticate);
            this.grpAuthenticate.Location = new System.Drawing.Point(12, 12);
            this.grpAuthenticate.Name = "grpAuthenticate";
            this.grpAuthenticate.Size = new System.Drawing.Size(297, 141);
            this.grpAuthenticate.TabIndex = 1;
            this.grpAuthenticate.TabStop = false;
            this.grpAuthenticate.Text = "Authenticate Vehicle";
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(71, 79);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(112, 35);
            this.btnAuthenticate.TabIndex = 2;
            this.btnAuthenticate.Text = "Authenticate Vehicle";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // txtAuthenticate
            // 
            this.txtAuthenticate.Location = new System.Drawing.Point(182, 42);
            this.txtAuthenticate.Name = "txtAuthenticate";
            this.txtAuthenticate.Size = new System.Drawing.Size(100, 20);
            this.txtAuthenticate.TabIndex = 1;
            // 
            // lblAuthenticate
            // 
            this.lblAuthenticate.AutoSize = true;
            this.lblAuthenticate.Location = new System.Drawing.Point(17, 42);
            this.lblAuthenticate.Name = "lblAuthenticate";
            this.lblAuthenticate.Size = new System.Drawing.Size(136, 13);
            this.lblAuthenticate.TabIndex = 0;
            this.lblAuthenticate.Text = "Enter vehicle number plate:";
            // 
            // grpUploadImage
            // 
            this.grpUploadImage.Controls.Add(this.picUpload);
            this.grpUploadImage.Controls.Add(this.btnCancel);
            this.grpUploadImage.Controls.Add(this.btnUploadImage);
            this.grpUploadImage.Controls.Add(this.lblUploadImage);
            this.grpUploadImage.Location = new System.Drawing.Point(328, 12);
            this.grpUploadImage.Name = "grpUploadImage";
            this.grpUploadImage.Size = new System.Drawing.Size(460, 426);
            this.grpUploadImage.TabIndex = 2;
            this.grpUploadImage.TabStop = false;
            this.grpUploadImage.Text = "Upload Image";
            // 
            // picUpload
            // 
            this.picUpload.Location = new System.Drawing.Point(20, 59);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(420, 305);
            this.picUpload.TabIndex = 5;
            this.picUpload.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(20, 385);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(112, 35);
            this.btnUploadImage.TabIndex = 3;
            this.btnUploadImage.Text = "Upload Image ";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // lblUploadImage
            // 
            this.lblUploadImage.AutoSize = true;
            this.lblUploadImage.Location = new System.Drawing.Point(17, 27);
            this.lblUploadImage.Name = "lblUploadImage";
            this.lblUploadImage.Size = new System.Drawing.Size(265, 13);
            this.lblUploadImage.TabIndex = 0;
            this.lblUploadImage.Text = "Upload an image to authenticate vehicle number plate.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridAuthenticate
            // 
            this.dataGridAuthenticate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthenticate.Location = new System.Drawing.Point(12, 173);
            this.dataGridAuthenticate.Name = "dataGridAuthenticate";
            this.dataGridAuthenticate.Size = new System.Drawing.Size(297, 259);
            this.dataGridAuthenticate.TabIndex = 6;
            // 
            // Detection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridAuthenticate);
            this.Controls.Add(this.grpUploadImage);
            this.Controls.Add(this.grpAuthenticate);
            this.Name = "Detection";
            this.Text = "Detection";
            this.Load += new System.EventHandler(this.Detection_Load);
            this.grpAuthenticate.ResumeLayout(false);
            this.grpAuthenticate.PerformLayout();
            this.grpUploadImage.ResumeLayout(false);
            this.grpUploadImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthenticate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAuthenticate;
        private System.Windows.Forms.TextBox txtAuthenticate;
        private System.Windows.Forms.Label lblAuthenticate;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.GroupBox grpUploadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Label lblUploadImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridAuthenticate;
    }
}
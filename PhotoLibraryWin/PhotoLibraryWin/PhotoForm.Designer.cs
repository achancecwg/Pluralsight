namespace PhotoLibraryWin
{
    partial class PhotoForm
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
            this.lblInsertPhoto = new System.Windows.Forms.Label();
            this.lblPhotoID = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhotoID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblSelectPhoto = new System.Windows.Forms.Label();
            this.lblPhotoID2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPhotoID2 = new System.Windows.Forms.TextBox();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInsertPhoto
            // 
            this.lblInsertPhoto.AutoSize = true;
            this.lblInsertPhoto.Location = new System.Drawing.Point(13, 13);
            this.lblInsertPhoto.Name = "lblInsertPhoto";
            this.lblInsertPhoto.Size = new System.Drawing.Size(64, 13);
            this.lblInsertPhoto.TabIndex = 0;
            this.lblInsertPhoto.Text = "Insert Photo";
            // 
            // lblPhotoID
            // 
            this.lblPhotoID.AutoSize = true;
            this.lblPhotoID.Location = new System.Drawing.Point(25, 33);
            this.lblPhotoID.Name = "lblPhotoID";
            this.lblPhotoID.Size = new System.Drawing.Size(52, 13);
            this.lblPhotoID.TabIndex = 1;
            this.lblPhotoID.Text = "Photo ID:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(25, 86);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(52, 13);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "Filename:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhotoID
            // 
            this.txtPhotoID.Location = new System.Drawing.Point(105, 30);
            this.txtPhotoID.Name = "txtPhotoID";
            this.txtPhotoID.Size = new System.Drawing.Size(35, 20);
            this.txtPhotoID.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 57);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(105, 83);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(202, 20);
            this.txtFilename.TabIndex = 7;
            // 
            // lblSelectPhoto
            // 
            this.lblSelectPhoto.AutoSize = true;
            this.lblSelectPhoto.Location = new System.Drawing.Point(16, 146);
            this.lblSelectPhoto.Name = "lblSelectPhoto";
            this.lblSelectPhoto.Size = new System.Drawing.Size(68, 13);
            this.lblSelectPhoto.TabIndex = 8;
            this.lblSelectPhoto.Text = "Select Photo";
            // 
            // lblPhotoID2
            // 
            this.lblPhotoID2.AutoSize = true;
            this.lblPhotoID2.Location = new System.Drawing.Point(28, 172);
            this.lblPhotoID2.Name = "lblPhotoID2";
            this.lblPhotoID2.Size = new System.Drawing.Size(52, 13);
            this.lblPhotoID2.TabIndex = 9;
            this.lblPhotoID2.Text = "Photo ID:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(31, 200);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(46, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPhotoID2
            // 
            this.txtPhotoID2.Location = new System.Drawing.Point(105, 164);
            this.txtPhotoID2.Name = "txtPhotoID2";
            this.txtPhotoID2.Size = new System.Drawing.Size(35, 20);
            this.txtPhotoID2.TabIndex = 11;
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(31, 252);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(0, 13);
            this.lblDescription2.TabIndex = 12;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(34, 323);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(257, 158);
            this.pbxPhoto.TabIndex = 13;
            this.pbxPhoto.TabStop = false;
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 551);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.txtPhotoID2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblPhotoID2);
            this.Controls.Add(this.lblSelectPhoto);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPhotoID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblPhotoID);
            this.Controls.Add(this.lblInsertPhoto);
            this.Name = "PhotoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PhotoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsertPhoto;
        private System.Windows.Forms.Label lblPhotoID;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhotoID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblSelectPhoto;
        private System.Windows.Forms.Label lblPhotoID2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtPhotoID2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.PictureBox pbxPhoto;
    }
}


namespace AcmeCustomerForms
{
    partial class OrderWin
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
            this.OrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(214, 106);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(75, 23);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OrderButton);
            this.Name = "OrderWin";
            this.Text = "OrderWin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrderButton;
    }
}
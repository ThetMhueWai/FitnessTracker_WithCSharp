namespace FitnessTracker
{
    partial class AdminStart
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
            this.btnCurrentAdmin = new System.Windows.Forms.Button();
            this.btnnewAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCurrentAdmin
            // 
            this.btnCurrentAdmin.Location = new System.Drawing.Point(105, 158);
            this.btnCurrentAdmin.Name = "btnCurrentAdmin";
            this.btnCurrentAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentAdmin.TabIndex = 3;
            this.btnCurrentAdmin.Text = "Current Admin";
            this.btnCurrentAdmin.UseVisualStyleBackColor = true;
            this.btnCurrentAdmin.Click += new System.EventHandler(this.btnCurrentAdmin_Click);
            // 
            // btnnewAdmin
            // 
            this.btnnewAdmin.Location = new System.Drawing.Point(105, 80);
            this.btnnewAdmin.Name = "btnnewAdmin";
            this.btnnewAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnnewAdmin.TabIndex = 2;
            this.btnnewAdmin.Text = "New Admin";
            this.btnnewAdmin.UseVisualStyleBackColor = true;
            this.btnnewAdmin.Click += new System.EventHandler(this.btnnewAdmin_Click);
            // 
            // AdminStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCurrentAdmin);
            this.Controls.Add(this.btnnewAdmin);
            this.Name = "AdminStart";
            this.Text = "AdminStart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCurrentAdmin;
        private System.Windows.Forms.Button btnnewAdmin;
    }
}
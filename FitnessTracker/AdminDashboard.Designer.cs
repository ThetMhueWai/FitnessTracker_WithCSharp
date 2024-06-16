namespace FitnessTracker
{
    partial class AdminDashboard
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
            this.txtadminuName = new System.Windows.Forms.TextBox();
            this.txtadminuID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtadminuName
            // 
            this.txtadminuName.Location = new System.Drawing.Point(158, 184);
            this.txtadminuName.Name = "txtadminuName";
            this.txtadminuName.Size = new System.Drawing.Size(206, 20);
            this.txtadminuName.TabIndex = 0;
            // 
            // txtadminuID
            // 
            this.txtadminuID.Location = new System.Drawing.Point(158, 141);
            this.txtadminuID.Name = "txtadminuID";
            this.txtadminuID.Size = new System.Drawing.Size(206, 20);
            this.txtadminuID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Dashboard";
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(22, 317);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(75, 23);
            this.btnAddActivity.TabIndex = 3;
            this.btnAddActivity.Text = "Add Activity";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 358);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadminuID);
            this.Controls.Add(this.txtadminuName);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadminuName;
        private System.Windows.Forms.TextBox txtadminuID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddActivity;
    }
}
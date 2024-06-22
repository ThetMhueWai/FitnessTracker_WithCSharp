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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.txtadminuID = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tssbtnAName = new System.Windows.Forms.ToolStripSplitButton();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnAddActivity = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtadminuID
            // 
            this.txtadminuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadminuID.Location = new System.Drawing.Point(361, 48);
            this.txtadminuID.Name = "txtadminuID";
            this.txtadminuID.ReadOnly = true;
            this.txtadminuID.Size = new System.Drawing.Size(162, 20);
            this.txtadminuID.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbtnAName,
            this.tsbtnAddActivity});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(548, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tssbtnAName
            // 
            this.tssbtnAName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssbtnAName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.tssbtnAName.Image = ((System.Drawing.Image)(resources.GetObject("tssbtnAName.Image")));
            this.tssbtnAName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtnAName.Name = "tssbtnAName";
            this.tssbtnAName.Size = new System.Drawing.Size(68, 22);
            this.tssbtnAName.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // tsbtnAddActivity
            // 
            this.tsbtnAddActivity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnAddActivity.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddActivity.Image")));
            this.tsbtnAddActivity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddActivity.Name = "tsbtnAddActivity";
            this.tsbtnAddActivity.Size = new System.Drawing.Size(51, 22);
            this.tsbtnAddActivity.Text = "Activity";
            this.tsbtnAddActivity.Click += new System.EventHandler(this.tsbtnAddActivity_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 295);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtadminuID);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadminuID;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSplitButton tssbtnAName;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnAddActivity;
    }
}
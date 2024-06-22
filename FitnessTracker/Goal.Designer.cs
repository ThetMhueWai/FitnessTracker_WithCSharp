namespace FitnessTracker
{
    partial class Goal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmName = new System.Windows.Forms.TextBox();
            this.txtmID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTrackID = new System.Windows.Forms.TextBox();
            this.txtactID = new System.Windows.Forms.TextBox();
            this.txtmetricthree = new System.Windows.Forms.TextBox();
            this.txtmetrictwo = new System.Windows.Forms.TextBox();
            this.txtmetricone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboactivity = new System.Windows.Forms.ComboBox();
            this.activitytbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet = new FitnessTracker.FitnessDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.goalDate = new System.Windows.Forms.DateTimePicker();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activitytbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitytbTableAdapter = new FitnessTracker.FitnessDataSetTableAdapters.ActivitytbTableAdapter();
            this.activitytbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activitytbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmName);
            this.groupBox1.Controls.Add(this.txtmID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MemberInfo";
            // 
            // txtmName
            // 
            this.txtmName.Location = new System.Drawing.Point(120, 75);
            this.txtmName.Name = "txtmName";
            this.txtmName.Size = new System.Drawing.Size(100, 20);
            this.txtmName.TabIndex = 3;
            // 
            // txtmID
            // 
            this.txtmID.Location = new System.Drawing.Point(120, 43);
            this.txtmID.Name = "txtmID";
            this.txtmID.Size = new System.Drawing.Size(100, 20);
            this.txtmID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtTrackID);
            this.groupBox2.Controls.Add(this.txtactID);
            this.groupBox2.Controls.Add(this.txtmetricthree);
            this.groupBox2.Controls.Add(this.txtmetrictwo);
            this.groupBox2.Controls.Add(this.txtmetricone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboactivity);
            this.groupBox2.Location = new System.Drawing.Point(17, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ChooseActivity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Track ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Activity ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Choose Activity";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTrackID
            // 
            this.txtTrackID.Location = new System.Drawing.Point(131, 81);
            this.txtTrackID.Name = "txtTrackID";
            this.txtTrackID.Size = new System.Drawing.Size(100, 20);
            this.txtTrackID.TabIndex = 8;
            // 
            // txtactID
            // 
            this.txtactID.Location = new System.Drawing.Point(8, 81);
            this.txtactID.Name = "txtactID";
            this.txtactID.Size = new System.Drawing.Size(100, 20);
            this.txtactID.TabIndex = 7;
            // 
            // txtmetricthree
            // 
            this.txtmetricthree.Location = new System.Drawing.Point(338, 102);
            this.txtmetricthree.Name = "txtmetricthree";
            this.txtmetricthree.Size = new System.Drawing.Size(100, 20);
            this.txtmetricthree.TabIndex = 6;
            // 
            // txtmetrictwo
            // 
            this.txtmetrictwo.Location = new System.Drawing.Point(338, 72);
            this.txtmetrictwo.Name = "txtmetrictwo";
            this.txtmetrictwo.Size = new System.Drawing.Size(100, 20);
            this.txtmetrictwo.TabIndex = 5;
            // 
            // txtmetricone
            // 
            this.txtmetricone.Location = new System.Drawing.Point(338, 41);
            this.txtmetricone.Name = "txtmetricone";
            this.txtmetricone.Size = new System.Drawing.Size(100, 20);
            this.txtmetricone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "MetricThree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "MetricTwo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "MetricOne";
            // 
            // cboactivity
            // 
            this.cboactivity.DataSource = this.activitytbBindingSource3;
            this.cboactivity.DisplayMember = "ActivityName";
            this.cboactivity.FormattingEnabled = true;
            this.cboactivity.Location = new System.Drawing.Point(95, 33);
            this.cboactivity.Name = "cboactivity";
            this.cboactivity.Size = new System.Drawing.Size(136, 21);
            this.cboactivity.TabIndex = 0;
            this.cboactivity.ValueMember = "ActivityID";
            this.cboactivity.SelectedIndexChanged += new System.EventHandler(this.cboactivity_SelectedIndexChanged);
            // 
            // activitytbBindingSource3
            // 
            this.activitytbBindingSource3.DataMember = "Activitytb";
            this.activitytbBindingSource3.DataSource = this.fitnessDataSet;
            // 
            // fitnessDataSet
            // 
            this.fitnessDataSet.DataSetName = "FitnessDataSet";
            this.fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.goalDate);
            this.groupBox3.Controls.Add(this.txtGoal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(268, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SetGoal";
            // 
            // goalDate
            // 
            this.goalDate.Location = new System.Drawing.Point(22, 39);
            this.goalDate.Name = "goalDate";
            this.goalDate.Size = new System.Drawing.Size(200, 20);
            this.goalDate.TabIndex = 2;
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(112, 74);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(100, 20);
            this.txtGoal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your Goal";
            // 
            // activitytbBindingSource
            // 
            this.activitytbBindingSource.DataMember = "Activitytb";
            this.activitytbBindingSource.DataSource = this.fitnessDataSet;
            // 
            // activitytbTableAdapter
            // 
            this.activitytbTableAdapter.ClearBeforeFill = true;
            // 
            // activitytbBindingSource1
            // 
            this.activitytbBindingSource1.DataMember = "Activitytb";
            this.activitytbBindingSource1.DataSource = this.fitnessDataSet;
            // 
            // activitytbBindingSource2
            // 
            this.activitytbBindingSource2.DataMember = "Activitytb";
            this.activitytbBindingSource2.DataSource = this.fitnessDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.setGoalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walkingToolStripMenuItem,
            this.swimmingToolStripMenuItem});
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // walkingToolStripMenuItem
            // 
            this.walkingToolStripMenuItem.Name = "walkingToolStripMenuItem";
            this.walkingToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.walkingToolStripMenuItem.Text = "Walking";
            // 
            // swimmingToolStripMenuItem
            // 
            this.swimmingToolStripMenuItem.Name = "swimmingToolStripMenuItem";
            this.swimmingToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.swimmingToolStripMenuItem.Text = "Swimming";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // setGoalToolStripMenuItem
            // 
            this.setGoalToolStripMenuItem.Name = "setGoalToolStripMenuItem";
            this.setGoalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.setGoalToolStripMenuItem.Text = "SetGoal";
            // 
            // Goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 382);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Goal";
            this.Text = "Goal";
            this.Load += new System.EventHandler(this.Goal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmName;
        private System.Windows.Forms.TextBox txtmID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboactivity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmetricthree;
        private System.Windows.Forms.TextBox txtmetrictwo;
        private System.Windows.Forms.TextBox txtmetricone;
        private System.Windows.Forms.TextBox txtTrackID;
        private System.Windows.Forms.TextBox txtactID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker goalDate;
        private FitnessDataSet fitnessDataSet;
        private System.Windows.Forms.BindingSource activitytbBindingSource;
        private FitnessDataSetTableAdapters.ActivitytbTableAdapter activitytbTableAdapter;
        private System.Windows.Forms.BindingSource activitytbBindingSource2;
        private System.Windows.Forms.BindingSource activitytbBindingSource1;
        private System.Windows.Forms.BindingSource activitytbBindingSource3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swimmingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGoalToolStripMenuItem;
    }
}
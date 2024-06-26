﻿namespace FitnessTracker
{
    partial class Track
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
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalcal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgoal = new System.Windows.Forms.TextBox();
            this.txtTimetaken = new System.Windows.Forms.TextBox();
            this.txtbodyWeight = new System.Windows.Forms.TextBox();
            this.txtMet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmet = new System.Windows.Forms.Label();
            this.txtTrackID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCalBurnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracktbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet = new FitnessTracker.FitnessDataSet();
            this.tracktbTableAdapter = new FitnessTracker.FitnessDataSetTableAdapters.TracktbTableAdapter();
            this.tracktbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracktbBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrack
            // 
            this.dgvTrack.AutoGenerateColumns = false;
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackIDDataGridViewTextBoxColumn,
            this.activityNameDataGridViewTextBoxColumn,
            this.totalCalBurnDataGridViewTextBoxColumn,
            this.trackStatusDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.activityIDDataGridViewTextBoxColumn,
            this.trackDateDataGridViewTextBoxColumn,
            this.goalDataGridViewTextBoxColumn});
            this.dgvTrack.DataSource = this.tracktbBindingSource;
            this.dgvTrack.Location = new System.Drawing.Point(12, 53);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.Size = new System.Drawing.Size(773, 164);
            this.dgvTrack.TabIndex = 0;
            this.dgvTrack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrack_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtgoal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotalcal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTimetaken);
            this.groupBox1.Controls.Add(this.txtbodyWeight);
            this.groupBox1.Controls.Add(this.txtMet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblmet);
            this.groupBox1.Controls.Add(this.txtTrackID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 151);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotalcal
            // 
            this.txtTotalcal.Location = new System.Drawing.Point(86, 115);
            this.txtTotalcal.Name = "txtTotalcal";
            this.txtTotalcal.Size = new System.Drawing.Size(100, 20);
            this.txtTotalcal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Primary Goal";
            // 
            // txtgoal
            // 
            this.txtgoal.Location = new System.Drawing.Point(86, 72);
            this.txtgoal.Name = "txtgoal";
            this.txtgoal.Size = new System.Drawing.Size(100, 20);
            this.txtgoal.TabIndex = 8;
            // 
            // txtTimetaken
            // 
            this.txtTimetaken.Location = new System.Drawing.Point(275, 72);
            this.txtTimetaken.Name = "txtTimetaken";
            this.txtTimetaken.Size = new System.Drawing.Size(100, 20);
            this.txtTimetaken.TabIndex = 7;
            // 
            // txtbodyWeight
            // 
            this.txtbodyWeight.Location = new System.Drawing.Point(275, 32);
            this.txtbodyWeight.Name = "txtbodyWeight";
            this.txtbodyWeight.Size = new System.Drawing.Size(100, 20);
            this.txtbodyWeight.TabIndex = 6;
            // 
            // txtMet
            // 
            this.txtMet.Location = new System.Drawing.Point(275, 112);
            this.txtMet.Name = "txtMet";
            this.txtMet.Size = new System.Drawing.Size(100, 20);
            this.txtMet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time Taken";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Body Weight";
            // 
            // lblmet
            // 
            this.lblmet.AutoSize = true;
            this.lblmet.Location = new System.Drawing.Point(201, 115);
            this.lblmet.Name = "lblmet";
            this.lblmet.Size = new System.Drawing.Size(30, 13);
            this.lblmet.TabIndex = 2;
            this.lblmet.Text = "MET";
            // 
            // txtTrackID
            // 
            this.txtTrackID.Location = new System.Drawing.Point(86, 32);
            this.txtTrackID.Name = "txtTrackID";
            this.txtTrackID.Size = new System.Drawing.Size(100, 20);
            this.txtTrackID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(408, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "MET ka br lal body weight ka br lal time taken ka br lal";
            // 
            // trackIDDataGridViewTextBoxColumn
            // 
            this.trackIDDataGridViewTextBoxColumn.DataPropertyName = "TrackID";
            this.trackIDDataGridViewTextBoxColumn.HeaderText = "TrackID";
            this.trackIDDataGridViewTextBoxColumn.Name = "trackIDDataGridViewTextBoxColumn";
            // 
            // activityNameDataGridViewTextBoxColumn
            // 
            this.activityNameDataGridViewTextBoxColumn.DataPropertyName = "ActivityName";
            this.activityNameDataGridViewTextBoxColumn.HeaderText = "ActivityName";
            this.activityNameDataGridViewTextBoxColumn.Name = "activityNameDataGridViewTextBoxColumn";
            // 
            // totalCalBurnDataGridViewTextBoxColumn
            // 
            this.totalCalBurnDataGridViewTextBoxColumn.DataPropertyName = "TotalCalBurn";
            this.totalCalBurnDataGridViewTextBoxColumn.HeaderText = "TotalCalBurn";
            this.totalCalBurnDataGridViewTextBoxColumn.Name = "totalCalBurnDataGridViewTextBoxColumn";
            // 
            // trackStatusDataGridViewTextBoxColumn
            // 
            this.trackStatusDataGridViewTextBoxColumn.DataPropertyName = "TrackStatus";
            this.trackStatusDataGridViewTextBoxColumn.HeaderText = "TrackStatus";
            this.trackStatusDataGridViewTextBoxColumn.Name = "trackStatusDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            // 
            // trackDateDataGridViewTextBoxColumn
            // 
            this.trackDateDataGridViewTextBoxColumn.DataPropertyName = "TrackDate";
            this.trackDateDataGridViewTextBoxColumn.HeaderText = "TrackDate";
            this.trackDateDataGridViewTextBoxColumn.Name = "trackDateDataGridViewTextBoxColumn";
            // 
            // goalDataGridViewTextBoxColumn
            // 
            this.goalDataGridViewTextBoxColumn.DataPropertyName = "Goal";
            this.goalDataGridViewTextBoxColumn.HeaderText = "Goal";
            this.goalDataGridViewTextBoxColumn.Name = "goalDataGridViewTextBoxColumn";
            // 
            // tracktbBindingSource
            // 
            this.tracktbBindingSource.DataMember = "Tracktb";
            this.tracktbBindingSource.DataSource = this.fitnessDataSet;
            // 
            // fitnessDataSet
            // 
            this.fitnessDataSet.DataSetName = "FitnessDataSet";
            this.fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tracktbTableAdapter
            // 
            this.tracktbTableAdapter.ClearBeforeFill = true;
            // 
            // tracktbBindingSource1
            // 
            this.tracktbBindingSource1.DataMember = "Tracktb";
            this.tracktbBindingSource1.DataSource = this.fitnessDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.setGoalToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 22;
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
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 445);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTrack);
            this.Name = "Track";
            this.Text = "Track";
            this.Load += new System.EventHandler(this.Track_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracktbBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimetaken;
        private System.Windows.Forms.TextBox txtbodyWeight;
        private System.Windows.Forms.TextBox txtMet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmet;
        private System.Windows.Forms.TextBox txtTrackID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgoal;
        private System.Windows.Forms.TextBox txtTotalcal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private FitnessDataSet fitnessDataSet;
        private System.Windows.Forms.BindingSource tracktbBindingSource;
        private FitnessDataSetTableAdapters.TracktbTableAdapter tracktbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tracktbBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCalBurnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swimmingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}
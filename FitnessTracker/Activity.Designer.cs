namespace FitnessTracker
{
    partial class Activity
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
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricThreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitytbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet = new FitnessTracker.FitnessDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtActivityID = new System.Windows.Forms.TextBox();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.txtMetricOne = new System.Windows.Forms.TextBox();
            this.txtMetricThree = new System.Windows.Forms.TextBox();
            this.txtMetricTwo = new System.Windows.Forms.TextBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnactDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.activitytbTableAdapter = new FitnessTracker.FitnessDataSetTableAdapters.ActivitytbTableAdapter();
            this.fKTracktbActivit3D5E1FD2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tracktbTableAdapter = new FitnessTracker.FitnessDataSetTableAdapters.TracktbTableAdapter();
            this.fKTracktbActivit3D5E1FD2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTracktbActivit3D5E1FD2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.activitytbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTracktbActivit3D5E1FD2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTracktbActivit3D5E1FD2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTracktbActivit3D5E1FD2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivity
            // 
            this.dgvActivity.AutoGenerateColumns = false;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activityIDDataGridViewTextBoxColumn,
            this.activityNameDataGridViewTextBoxColumn,
            this.metricOneDataGridViewTextBoxColumn,
            this.metricTwoDataGridViewTextBoxColumn,
            this.metricThreeDataGridViewTextBoxColumn});
            this.dgvActivity.DataSource = this.activitytbBindingSource1;
            this.dgvActivity.Location = new System.Drawing.Point(12, 176);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.Size = new System.Drawing.Size(613, 175);
            this.dgvActivity.TabIndex = 0;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            // 
            // activityNameDataGridViewTextBoxColumn
            // 
            this.activityNameDataGridViewTextBoxColumn.DataPropertyName = "ActivityName";
            this.activityNameDataGridViewTextBoxColumn.HeaderText = "ActivityName";
            this.activityNameDataGridViewTextBoxColumn.Name = "activityNameDataGridViewTextBoxColumn";
            // 
            // metricOneDataGridViewTextBoxColumn
            // 
            this.metricOneDataGridViewTextBoxColumn.DataPropertyName = "MetricOne";
            this.metricOneDataGridViewTextBoxColumn.HeaderText = "MetricOne";
            this.metricOneDataGridViewTextBoxColumn.Name = "metricOneDataGridViewTextBoxColumn";
            // 
            // metricTwoDataGridViewTextBoxColumn
            // 
            this.metricTwoDataGridViewTextBoxColumn.DataPropertyName = "MetricTwo";
            this.metricTwoDataGridViewTextBoxColumn.HeaderText = "MetricTwo";
            this.metricTwoDataGridViewTextBoxColumn.Name = "metricTwoDataGridViewTextBoxColumn";
            // 
            // metricThreeDataGridViewTextBoxColumn
            // 
            this.metricThreeDataGridViewTextBoxColumn.DataPropertyName = "MetricThree";
            this.metricThreeDataGridViewTextBoxColumn.HeaderText = "MetricThree";
            this.metricThreeDataGridViewTextBoxColumn.Name = "metricThreeDataGridViewTextBoxColumn";
            // 
            // activitytbBindingSource
            // 
            this.activitytbBindingSource.DataMember = "Activitytb";
            this.activitytbBindingSource.DataSource = this.fitnessDataSet;
            // 
            // fitnessDataSet
            // 
            this.fitnessDataSet.DataSetName = "FitnessDataSet";
            this.fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activity ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Activity Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Metric One";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Metric Two";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Metric Three";
            // 
            // txtActivityID
            // 
            this.txtActivityID.Location = new System.Drawing.Point(249, 11);
            this.txtActivityID.Name = "txtActivityID";
            this.txtActivityID.Size = new System.Drawing.Size(100, 20);
            this.txtActivityID.TabIndex = 7;
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(525, 11);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(100, 20);
            this.txtActivityName.TabIndex = 8;
            // 
            // txtMetricOne
            // 
            this.txtMetricOne.Location = new System.Drawing.Point(249, 59);
            this.txtMetricOne.Name = "txtMetricOne";
            this.txtMetricOne.Size = new System.Drawing.Size(100, 20);
            this.txtMetricOne.TabIndex = 9;
            // 
            // txtMetricThree
            // 
            this.txtMetricThree.Location = new System.Drawing.Point(525, 58);
            this.txtMetricThree.Name = "txtMetricThree";
            this.txtMetricThree.Size = new System.Drawing.Size(100, 20);
            this.txtMetricThree.TabIndex = 10;
            // 
            // txtMetricTwo
            // 
            this.txtMetricTwo.Location = new System.Drawing.Point(249, 105);
            this.txtMetricTwo.Name = "txtMetricTwo";
            this.txtMetricTwo.Size = new System.Drawing.Size(100, 20);
            this.txtMetricTwo.TabIndex = 11;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(417, 108);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(75, 23);
            this.btnAddActivity.TabIndex = 12;
            this.btnAddActivity.Text = "Add Activity";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 8);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(129, 23);
            this.btnDashboard.TabIndex = 13;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnactDelete
            // 
            this.btnactDelete.Location = new System.Drawing.Point(525, 147);
            this.btnactDelete.Name = "btnactDelete";
            this.btnactDelete.Size = new System.Drawing.Size(87, 23);
            this.btnactDelete.TabIndex = 14;
            this.btnactDelete.Text = "Delete Activity";
            this.btnactDelete.UseVisualStyleBackColor = true;
            this.btnactDelete.Click += new System.EventHandler(this.btnactDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(515, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update Activity";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // activitytbTableAdapter
            // 
            this.activitytbTableAdapter.ClearBeforeFill = true;
            // 
            // fKTracktbActivit3D5E1FD2BindingSource
            // 
            this.fKTracktbActivit3D5E1FD2BindingSource.DataMember = "FK__Tracktb__Activit__3D5E1FD2";
            this.fKTracktbActivit3D5E1FD2BindingSource.DataSource = this.activitytbBindingSource;
            // 
            // tracktbTableAdapter
            // 
            this.tracktbTableAdapter.ClearBeforeFill = true;
            // 
            // fKTracktbActivit3D5E1FD2BindingSource1
            // 
            this.fKTracktbActivit3D5E1FD2BindingSource1.DataMember = "FK__Tracktb__Activit__3D5E1FD2";
            this.fKTracktbActivit3D5E1FD2BindingSource1.DataSource = this.activitytbBindingSource;
            // 
            // fitnessDataSetBindingSource
            // 
            this.fitnessDataSetBindingSource.DataSource = this.fitnessDataSet;
            // 
            // fKTracktbActivit3D5E1FD2BindingSource2
            // 
            this.fKTracktbActivit3D5E1FD2BindingSource2.DataMember = "FK__Tracktb__Activit__3D5E1FD2";
            this.fKTracktbActivit3D5E1FD2BindingSource2.DataSource = this.activitytbBindingSource;
            // 
            // activitytbBindingSource1
            // 
            this.activitytbBindingSource1.DataMember = "Activitytb";
            this.activitytbBindingSource1.DataSource = this.fitnessDataSet;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 363);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnactDelete);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.txtMetricTwo);
            this.Controls.Add(this.txtMetricThree);
            this.Controls.Add(this.txtMetricOne);
            this.Controls.Add(this.txtActivityName);
            this.Controls.Add(this.txtActivityID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvActivity);
            this.Name = "Activity";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.fKTracktbActivit3D5E1FD2BindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.fKTracktbActivit3D5E1FD2BindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.fKTracktbActivit3D5E1FD2BindingSource2)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtActivityID;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.TextBox txtMetricOne;
        private System.Windows.Forms.TextBox txtMetricThree;
        private System.Windows.Forms.TextBox txtMetricTwo;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Button btnDashboard;
        private FitnessDataSet fitnessDataSet;
        private System.Windows.Forms.BindingSource activitytbBindingSource;
        private FitnessDataSetTableAdapters.ActivitytbTableAdapter activitytbTableAdapter;
        private System.Windows.Forms.Button btnactDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource fKTracktbActivit3D5E1FD2BindingSource;
        private FitnessDataSetTableAdapters.TracktbTableAdapter tracktbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calburnPerhrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKTracktbActivit3D5E1FD2BindingSource1;
        private System.Windows.Forms.BindingSource fitnessDataSetBindingSource;
        private System.Windows.Forms.BindingSource fKTracktbActivit3D5E1FD2BindingSource2;
        private System.Windows.Forms.BindingSource activitytbBindingSource1;
    }
}
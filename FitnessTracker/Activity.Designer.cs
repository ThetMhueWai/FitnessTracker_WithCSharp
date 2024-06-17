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
            this.label1 = new System.Windows.Forms.Label();
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
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricThreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitytbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet = new FitnessTracker.FitnessDataSet();
            this.activitytbTableAdapter = new FitnessTracker.FitnessDataSetTableAdapters.ActivitytbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
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
            this.dgvActivity.DataSource = this.activitytbBindingSource;
            this.dgvActivity.Location = new System.Drawing.Point(70, 176);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.Size = new System.Drawing.Size(542, 175);
            this.dgvActivity.TabIndex = 0;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activity ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Activity Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Metric One";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Metric Two";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Metric Three";
            // 
            // txtActivityID
            // 
            this.txtActivityID.Location = new System.Drawing.Point(227, 46);
            this.txtActivityID.Name = "txtActivityID";
            this.txtActivityID.Size = new System.Drawing.Size(100, 20);
            this.txtActivityID.TabIndex = 7;
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(503, 46);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(100, 20);
            this.txtActivityName.TabIndex = 8;
            // 
            // txtMetricOne
            // 
            this.txtMetricOne.Location = new System.Drawing.Point(227, 94);
            this.txtMetricOne.Name = "txtMetricOne";
            this.txtMetricOne.Size = new System.Drawing.Size(100, 20);
            this.txtMetricOne.TabIndex = 9;
            // 
            // txtMetricThree
            // 
            this.txtMetricThree.Location = new System.Drawing.Point(503, 93);
            this.txtMetricThree.Name = "txtMetricThree";
            this.txtMetricThree.Size = new System.Drawing.Size(100, 20);
            this.txtMetricThree.TabIndex = 10;
            // 
            // txtMetricTwo
            // 
            this.txtMetricTwo.Location = new System.Drawing.Point(227, 140);
            this.txtMetricTwo.Name = "txtMetricTwo";
            this.txtMetricTwo.Size = new System.Drawing.Size(100, 20);
            this.txtMetricTwo.TabIndex = 11;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(417, 138);
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
            this.btnactDelete.Location = new System.Drawing.Point(503, 138);
            this.btnactDelete.Name = "btnactDelete";
            this.btnactDelete.Size = new System.Drawing.Size(87, 23);
            this.btnactDelete.TabIndex = 14;
            this.btnactDelete.Text = "Delete Activity";
            this.btnactDelete.UseVisualStyleBackColor = true;
            this.btnactDelete.Click += new System.EventHandler(this.btnactDelete_Click);
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
            // activitytbTableAdapter
            // 
            this.activitytbTableAdapter.ClearBeforeFill = true;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 363);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActivity);
            this.Name = "Activity";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitytbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnactDelete;
    }
}
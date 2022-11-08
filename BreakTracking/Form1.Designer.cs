
namespace BreakTracking
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSaveMsg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFilterResultMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtEmployeeNameFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_EmployeeSrc = new System.Windows.Forms.Label();
            this.grbWeekSelection = new System.Windows.Forms.GroupBox();
            this.cbWeekSelection = new System.Windows.Forms.ComboBox();
            this.lblWeekSelection = new System.Windows.Forms.Label();
            this.grpEmployeeInf = new System.Windows.Forms.GroupBox();
            this.lblEmployeeInfShiftS = new System.Windows.Forms.Label();
            this.lblEmployeeInfIdS = new System.Windows.Forms.Label();
            this.lblEmployeeInfDtpS = new System.Windows.Forms.Label();
            this.lblEmployeeInfNameS = new System.Windows.Forms.Label();
            this.lblEmployeeInfShift = new System.Windows.Forms.Label();
            this.lblEmployeeInfDtp = new System.Windows.Forms.Label();
            this.lblEmployeeInfId = new System.Windows.Forms.Label();
            this.lblEmployeeInfName = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.weekC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.breakTrackingContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbWeekSelection.SuspendLayout();
            this.grpEmployeeInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTrackingContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_EmployeeSrc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbWeekSelection);
            this.splitContainer1.Panel2.Controls.Add(this.grpEmployeeInf);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 552);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblSaveMsg);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtStartTime);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEndTime);
            this.groupBox2.Location = new System.Drawing.Point(16, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 175);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Time format is HH:mm";
            // 
            // lblSaveMsg
            // 
            this.lblSaveMsg.AutoSize = true;
            this.lblSaveMsg.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblSaveMsg.Location = new System.Drawing.Point(11, 159);
            this.lblSaveMsg.Name = "lblSaveMsg";
            this.lblSaveMsg.Size = new System.Drawing.Size(55, 13);
            this.lblSaveMsg.TabIndex = 12;
            this.lblSaveMsg.Text = "save msg ";
            this.lblSaveMsg.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Day of work";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(14, 82);
            this.txtStartTime.MaxLength = 5;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(49, 20);
            this.txtStartTime.TabIndex = 5;
            this.txtStartTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartTime_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "End Time";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(105, 82);
            this.txtEndTime.MaxLength = 5;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(49, 20);
            this.txtEndTime.TabIndex = 7;
            this.txtEndTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndTime_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(16, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(389, 158);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Department";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Shift";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFilterResultMsg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.txtEmployeeNameFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // lblFilterResultMsg
            // 
            this.lblFilterResultMsg.AutoSize = true;
            this.lblFilterResultMsg.Location = new System.Drawing.Point(45, 54);
            this.lblFilterResultMsg.Name = "lblFilterResultMsg";
            this.lblFilterResultMsg.Size = new System.Drawing.Size(35, 13);
            this.lblFilterResultMsg.TabIndex = 6;
            this.lblFilterResultMsg.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 54);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // txtEmployeeNameFilter
            // 
            this.txtEmployeeNameFilter.Location = new System.Drawing.Point(38, 19);
            this.txtEmployeeNameFilter.Name = "txtEmployeeNameFilter";
            this.txtEmployeeNameFilter.Size = new System.Drawing.Size(175, 20);
            this.txtEmployeeNameFilter.TabIndex = 2;
            this.txtEmployeeNameFilter.TextChanged += new System.EventHandler(this.txtEmployeeNameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lbl_EmployeeSrc
            // 
            this.lbl_EmployeeSrc.AutoSize = true;
            this.lbl_EmployeeSrc.Location = new System.Drawing.Point(3, 9);
            this.lbl_EmployeeSrc.Name = "lbl_EmployeeSrc";
            this.lbl_EmployeeSrc.Size = new System.Drawing.Size(108, 13);
            this.lbl_EmployeeSrc.TabIndex = 1;
            this.lbl_EmployeeSrc.Text = "Employee work Time ";
            this.lbl_EmployeeSrc.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbWeekSelection
            // 
            this.grbWeekSelection.Controls.Add(this.cbWeekSelection);
            this.grbWeekSelection.Controls.Add(this.lblWeekSelection);
            this.grbWeekSelection.Location = new System.Drawing.Point(16, 147);
            this.grbWeekSelection.Name = "grbWeekSelection";
            this.grbWeekSelection.Size = new System.Drawing.Size(451, 76);
            this.grbWeekSelection.TabIndex = 3;
            this.grbWeekSelection.TabStop = false;
            this.grbWeekSelection.Text = "Week Selection";
            // 
            // cbWeekSelection
            // 
            this.cbWeekSelection.FormattingEnabled = true;
            this.cbWeekSelection.Location = new System.Drawing.Point(50, 32);
            this.cbWeekSelection.Name = "cbWeekSelection";
            this.cbWeekSelection.Size = new System.Drawing.Size(210, 21);
            this.cbWeekSelection.TabIndex = 1;
            this.cbWeekSelection.SelectedIndexChanged += new System.EventHandler(this.cbWeekSelection_SelectedIndexChanged);
            // 
            // lblWeekSelection
            // 
            this.lblWeekSelection.AutoSize = true;
            this.lblWeekSelection.Location = new System.Drawing.Point(8, 35);
            this.lblWeekSelection.Name = "lblWeekSelection";
            this.lblWeekSelection.Size = new System.Drawing.Size(36, 13);
            this.lblWeekSelection.TabIndex = 0;
            this.lblWeekSelection.Text = "Week";
            // 
            // grpEmployeeInf
            // 
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfShiftS);
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfIdS);
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfDtpS);
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfNameS);
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfShift);
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfDtp);
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfId);
            this.grpEmployeeInf.Controls.Add(this.lblEmployeeInfName);
            this.grpEmployeeInf.Location = new System.Drawing.Point(16, 45);
            this.grpEmployeeInf.Name = "grpEmployeeInf";
            this.grpEmployeeInf.Size = new System.Drawing.Size(453, 83);
            this.grpEmployeeInf.TabIndex = 2;
            this.grpEmployeeInf.TabStop = false;
            this.grpEmployeeInf.Text = "Employee Information";
            // 
            // lblEmployeeInfShiftS
            // 
            this.lblEmployeeInfShiftS.AutoSize = true;
            this.lblEmployeeInfShiftS.Location = new System.Drawing.Point(377, 53);
            this.lblEmployeeInfShiftS.Name = "lblEmployeeInfShiftS";
            this.lblEmployeeInfShiftS.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeInfShiftS.TabIndex = 7;
            this.lblEmployeeInfShiftS.Text = "employee shift";
            this.lblEmployeeInfShiftS.Visible = false;
            // 
            // lblEmployeeInfIdS
            // 
            this.lblEmployeeInfIdS.AutoSize = true;
            this.lblEmployeeInfIdS.Location = new System.Drawing.Point(377, 25);
            this.lblEmployeeInfIdS.Name = "lblEmployeeInfIdS";
            this.lblEmployeeInfIdS.Size = new System.Drawing.Size(63, 13);
            this.lblEmployeeInfIdS.TabIndex = 6;
            this.lblEmployeeInfIdS.Text = "employee id";
            this.lblEmployeeInfIdS.Visible = false;
            // 
            // lblEmployeeInfDtpS
            // 
            this.lblEmployeeInfDtpS.AutoSize = true;
            this.lblEmployeeInfDtpS.Location = new System.Drawing.Point(47, 53);
            this.lblEmployeeInfDtpS.Name = "lblEmployeeInfDtpS";
            this.lblEmployeeInfDtpS.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeInfDtpS.TabIndex = 5;
            this.lblEmployeeInfDtpS.Text = "employee dtp";
            this.lblEmployeeInfDtpS.Visible = false;
            // 
            // lblEmployeeInfNameS
            // 
            this.lblEmployeeInfNameS.AutoSize = true;
            this.lblEmployeeInfNameS.Location = new System.Drawing.Point(47, 25);
            this.lblEmployeeInfNameS.Name = "lblEmployeeInfNameS";
            this.lblEmployeeInfNameS.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeInfNameS.TabIndex = 4;
            this.lblEmployeeInfNameS.Text = "employee name";
            this.lblEmployeeInfNameS.Visible = false;
            // 
            // lblEmployeeInfShift
            // 
            this.lblEmployeeInfShift.AutoSize = true;
            this.lblEmployeeInfShift.Location = new System.Drawing.Point(338, 53);
            this.lblEmployeeInfShift.Name = "lblEmployeeInfShift";
            this.lblEmployeeInfShift.Size = new System.Drawing.Size(28, 13);
            this.lblEmployeeInfShift.TabIndex = 3;
            this.lblEmployeeInfShift.Text = "Shift";
            // 
            // lblEmployeeInfDtp
            // 
            this.lblEmployeeInfDtp.AutoSize = true;
            this.lblEmployeeInfDtp.Location = new System.Drawing.Point(8, 53);
            this.lblEmployeeInfDtp.Name = "lblEmployeeInfDtp";
            this.lblEmployeeInfDtp.Size = new System.Drawing.Size(27, 13);
            this.lblEmployeeInfDtp.TabIndex = 2;
            this.lblEmployeeInfDtp.Text = "Dpt.";
            // 
            // lblEmployeeInfId
            // 
            this.lblEmployeeInfId.AutoSize = true;
            this.lblEmployeeInfId.Location = new System.Drawing.Point(338, 25);
            this.lblEmployeeInfId.Name = "lblEmployeeInfId";
            this.lblEmployeeInfId.Size = new System.Drawing.Size(21, 13);
            this.lblEmployeeInfId.TabIndex = 1;
            this.lblEmployeeInfId.Text = "ID:";
            // 
            // lblEmployeeInfName
            // 
            this.lblEmployeeInfName.AutoSize = true;
            this.lblEmployeeInfName.Location = new System.Drawing.Point(6, 25);
            this.lblEmployeeInfName.Name = "lblEmployeeInfName";
            this.lblEmployeeInfName.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeInfName.TabIndex = 0;
            this.lblEmployeeInfName.Text = "Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weekC,
            this.startTime,
            this.EndTime,
            this.TotalHours,
            this.BreakTime});
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(16, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(533, 221);
            this.dataGridView2.TabIndex = 1;
            // 
            // weekC
            // 
            this.weekC.HeaderText = "";
            this.weekC.Name = "weekC";
            this.weekC.Width = 50;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start Time";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 120;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 120;
            // 
            // TotalHours
            // 
            this.TotalHours.HeaderText = "Total Hours";
            this.TotalHours.Name = "TotalHours";
            // 
            // BreakTime
            // 
            this.BreakTime.HeaderText = "Break Time";
            this.BreakTime.Name = "BreakTime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Weekly report";
            // 
            // breakTrackingContextBindingSource
            // 
            this.breakTrackingContextBindingSource.DataSource = typeof(BreakTracking.Context.BreakTrackingContext);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 552);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Break Tracking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbWeekSelection.ResumeLayout(false);
            this.grbWeekSelection.PerformLayout();
            this.grpEmployeeInf.ResumeLayout(false);
            this.grpEmployeeInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTrackingContextBindingSource)).EndInit();
            this.ResumeLayout(false);


        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_EmployeeSrc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtEmployeeNameFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource breakTrackingContextBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblFilterResultMsg;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpEmployeeInf;
        private System.Windows.Forms.Label lblEmployeeInfShiftS;
        private System.Windows.Forms.Label lblEmployeeInfIdS;
        private System.Windows.Forms.Label lblEmployeeInfDtpS;
        private System.Windows.Forms.Label lblEmployeeInfNameS;
        private System.Windows.Forms.Label lblEmployeeInfShift;
        private System.Windows.Forms.Label lblEmployeeInfDtp;
        private System.Windows.Forms.Label lblEmployeeInfId;
        private System.Windows.Forms.Label lblEmployeeInfName;
        private System.Windows.Forms.GroupBox grbWeekSelection;
        private System.Windows.Forms.ComboBox cbWeekSelection;
        private System.Windows.Forms.Label lblWeekSelection;
        private System.Windows.Forms.Label lblSaveMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekC;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakTime;
    }
}


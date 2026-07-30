namespace School_Management_System
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherid = new System.Windows.Forms.TextBox();
            this.AttendanceBS = new System.Windows.Forms.BindingSource(this.components);
            this.ist2lkDataSetAttendance1 = new School_Management_System.ist2lkDataSetAttendance();
            this.dateTxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentTxt = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.saveAllBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attendenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAttendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceTableAdapter = new School_Management_System.ist2lkDataSetAttendanceTableAdapters.AttendanceTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSetAttendance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendence Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher ID:";
            // 
            // teacherid
            // 
            this.teacherid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AttendanceBS, "TeacherNumber", true));
            this.teacherid.Location = new System.Drawing.Point(130, 184);
            this.teacherid.Name = "teacherid";
            this.teacherid.Size = new System.Drawing.Size(191, 22);
            this.teacherid.TabIndex = 4;
            // 
            // AttendanceBS
            // 
            this.AttendanceBS.DataMember = "Attendance";
            this.AttendanceBS.DataSource = this.ist2lkDataSetAttendance1;
            // 
            // ist2lkDataSetAttendance1
            // 
            this.ist2lkDataSetAttendance1.DataSetName = "ist2lkDataSetAttendance";
            this.ist2lkDataSetAttendance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTxt
            // 
            this.dateTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AttendanceBS, "DateAttend", true));
            this.dateTxt.Location = new System.Drawing.Point(130, 131);
            this.dateTxt.Mask = "0000/00/00";
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(191, 22);
            this.dateTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // statusTxt
            // 
            this.statusTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AttendanceBS, "Status", true));
            this.statusTxt.FormattingEnabled = true;
            this.statusTxt.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.statusTxt.Location = new System.Drawing.Point(464, 128);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(121, 24);
            this.statusTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Student Number:";
            // 
            // StudentTxt
            // 
            this.StudentTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AttendanceBS, "StudentNumber", true));
            this.StudentTxt.Location = new System.Drawing.Point(464, 181);
            this.StudentTxt.Name = "StudentTxt";
            this.StudentTxt.Size = new System.Drawing.Size(121, 22);
            this.StudentTxt.TabIndex = 11;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.Blue;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(3, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(128, 41);
            this.viewBtn.TabIndex = 12;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Blue;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(137, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 41);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // saveAllBtn
            // 
            this.saveAllBtn.BackColor = System.Drawing.Color.Blue;
            this.saveAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAllBtn.Location = new System.Drawing.Point(271, 3);
            this.saveAllBtn.Name = "saveAllBtn";
            this.saveAllBtn.Size = new System.Drawing.Size(128, 41);
            this.saveAllBtn.TabIndex = 14;
            this.saveAllBtn.Text = "Save All";
            this.saveAllBtn.UseVisualStyleBackColor = false;
            this.saveAllBtn.Click += new System.EventHandler(this.saveAllBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendenceNoDataGridViewTextBoxColumn,
            this.dateAttendDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.teacherNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.AttendanceBS;
            this.dataGridView1.Location = new System.Drawing.Point(19, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 247);
            this.dataGridView1.TabIndex = 16;
            // 
            // attendenceNoDataGridViewTextBoxColumn
            // 
            this.attendenceNoDataGridViewTextBoxColumn.DataPropertyName = "AttendenceNo";
            this.attendenceNoDataGridViewTextBoxColumn.HeaderText = "AttendenceNo";
            this.attendenceNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendenceNoDataGridViewTextBoxColumn.Name = "attendenceNoDataGridViewTextBoxColumn";
            this.attendenceNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAttendDataGridViewTextBoxColumn
            // 
            this.dateAttendDataGridViewTextBoxColumn.DataPropertyName = "DateAttend";
            this.dateAttendDataGridViewTextBoxColumn.HeaderText = "DateAttend";
            this.dateAttendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAttendDataGridViewTextBoxColumn.Name = "dateAttendDataGridViewTextBoxColumn";
            this.dateAttendDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            this.studentNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherNumberDataGridViewTextBoxColumn
            // 
            this.teacherNumberDataGridViewTextBoxColumn.DataPropertyName = "TeacherNumber";
            this.teacherNumberDataGridViewTextBoxColumn.HeaderText = "TeacherNumber";
            this.teacherNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherNumberDataGridViewTextBoxColumn.Name = "teacherNumberDataGridViewTextBoxColumn";
            this.teacherNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(600, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveAllBtn, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 259);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 50);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.teacherid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSetAttendance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacherid;
        private System.Windows.Forms.BindingSource AttendanceBS;
        private ist2lkDataSetAttendance ist2lkDataSetAttendance1;
        private ist2lkDataSetAttendanceTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.MaskedTextBox dateTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentTxt;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button saveAllBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAttendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}
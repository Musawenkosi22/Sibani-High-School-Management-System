namespace School_Management_System
{
    partial class FormSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubject));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectCodeTxt = new System.Windows.Forms.TextBox();
            this.SubjectBS = new System.Windows.Forms.BindingSource(this.components);
            this.ist2lkDataSetSubject1 = new School_Management_System.ist2lkDataSetSubject();
            this.subjectNameTxt = new System.Windows.Forms.TextBox();
            this.passRequirementTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.newSubjectBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.subjectTableAdapter = new School_Management_System.ist2lkDataSetSubjectTableAdapters.SubjectTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passRequirementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSetSubject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 92);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pass Requirement:";
            // 
            // subjectCodeTxt
            // 
            this.subjectCodeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SubjectBS, "SubjectCode", true));
            this.subjectCodeTxt.Location = new System.Drawing.Point(167, 144);
            this.subjectCodeTxt.Name = "subjectCodeTxt";
            this.subjectCodeTxt.Size = new System.Drawing.Size(280, 22);
            this.subjectCodeTxt.TabIndex = 5;
            // 
            // SubjectBS
            // 
            this.SubjectBS.DataMember = "Subject";
            this.SubjectBS.DataSource = this.ist2lkDataSetSubject1;
            // 
            // ist2lkDataSetSubject1
            // 
            this.ist2lkDataSetSubject1.DataSetName = "ist2lkDataSetSubject";
            this.ist2lkDataSetSubject1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectNameTxt
            // 
            this.subjectNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SubjectBS, "SubjectName", true));
            this.subjectNameTxt.Location = new System.Drawing.Point(167, 181);
            this.subjectNameTxt.Name = "subjectNameTxt";
            this.subjectNameTxt.Size = new System.Drawing.Size(280, 22);
            this.subjectNameTxt.TabIndex = 6;
            // 
            // passRequirementTxt
            // 
            this.passRequirementTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SubjectBS, "PassRequirement", true));
            this.passRequirementTxt.Location = new System.Drawing.Point(626, 143);
            this.passRequirementTxt.Name = "passRequirementTxt";
            this.passRequirementTxt.Size = new System.Drawing.Size(100, 22);
            this.passRequirementTxt.TabIndex = 7;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SubjectBS, "Description", true));
            this.descriptionTxt.Location = new System.Drawing.Point(167, 223);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(280, 69);
            this.descriptionTxt.TabIndex = 8;
            this.descriptionTxt.Text = "";
            // 
            // newSubjectBtn
            // 
            this.newSubjectBtn.BackColor = System.Drawing.Color.Blue;
            this.newSubjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSubjectBtn.Location = new System.Drawing.Point(3, 3);
            this.newSubjectBtn.Name = "newSubjectBtn";
            this.newSubjectBtn.Size = new System.Drawing.Size(141, 49);
            this.newSubjectBtn.TabIndex = 10;
            this.newSubjectBtn.Text = "New Subject";
            this.newSubjectBtn.UseVisualStyleBackColor = false;
            this.newSubjectBtn.Click += new System.EventHandler(this.newSubjectBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.Blue;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(297, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(141, 52);
            this.viewBtn.TabIndex = 11;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(444, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(141, 52);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectCodeDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.passRequirementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.SubjectBS;
            this.dataGridView1.Location = new System.Drawing.Point(12, 427);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
            this.subjectCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // passRequirementDataGridViewTextBoxColumn
            // 
            this.passRequirementDataGridViewTextBoxColumn.DataPropertyName = "PassRequirement";
            this.passRequirementDataGridViewTextBoxColumn.HeaderText = "PassRequirement";
            this.passRequirementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passRequirementDataGridViewTextBoxColumn.Name = "passRequirementDataGridViewTextBoxColumn";
            this.passRequirementDataGridViewTextBoxColumn.Width = 125;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Blue;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(150, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(136, 48);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.newSubjectBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteBtn, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 338);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 58);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(591, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(606, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 589);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.passRequirementTxt);
            this.Controls.Add(this.subjectNameTxt);
            this.Controls.Add(this.subjectCodeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSubject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.FormSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSetSubject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subjectCodeTxt;
        private System.Windows.Forms.TextBox subjectNameTxt;
        private System.Windows.Forms.TextBox passRequirementTxt;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.Button newSubjectBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.BindingSource SubjectBS;
        private ist2lkDataSetSubject ist2lkDataSetSubject1;
        private ist2lkDataSetSubjectTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passRequirementDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
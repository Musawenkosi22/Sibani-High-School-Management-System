namespace School_Management_System
{
    partial class School_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(School_Info));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leveltxt = new System.Windows.Forms.ComboBox();
            this.schoolInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2lkDataSet2 = new School_Management_System.ist2lkDataSet2();
            this.endtimetxt = new System.Windows.Forms.TextBox();
            this.schooltypetxt = new System.Windows.Forms.ComboBox();
            this.starttimetxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.schoolnametxt = new System.Windows.Forms.TextBox();
            this.schoolidtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sdisricttxt = new System.Windows.Forms.TextBox();
            this.spostaltxt = new System.Windows.Forms.TextBox();
            this.scitytxt = new System.Windows.Forms.TextBox();
            this.sstreetnametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.principaltxt = new System.Windows.Forms.TextBox();
            this.semailtxt = new System.Windows.Forms.TextBox();
            this.stelephonenotxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.snumberofclasses = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ist2lkDataSet1 = new School_Management_System.ist2lkDataSet1();
            this.schoolbs = new System.Windows.Forms.BindingSource(this.components);
            this.schoolinformationTableAdapter = new School_Management_System.ist2lkDataSet1TableAdapters.SchoolinformationTableAdapter();
            this.schoolInfoTableAdapter = new School_Management_System.ist2lkDataSet2TableAdapters.SchoolInfoTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolbs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leveltxt);
            this.groupBox1.Controls.Add(this.endtimetxt);
            this.groupBox1.Controls.Add(this.schooltypetxt);
            this.groupBox1.Controls.Add(this.starttimetxt);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.schoolnametxt);
            this.groupBox1.Controls.Add(this.schoolidtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic School Details";
            // 
            // leveltxt
            // 
            this.leveltxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "GradeLevel", true));
            this.leveltxt.FormattingEnabled = true;
            this.leveltxt.Items.AddRange(new object[] {
            "Grade 08 - 10",
            "Grade 10-12"});
            this.leveltxt.Location = new System.Drawing.Point(121, 145);
            this.leveltxt.Name = "leveltxt";
            this.leveltxt.Size = new System.Drawing.Size(180, 26);
            this.leveltxt.TabIndex = 7;
            // 
            // schoolInfoBindingSource
            // 
            this.schoolInfoBindingSource.DataMember = "SchoolInfo";
            this.schoolInfoBindingSource.DataSource = this.ist2lkDataSet2;
            // 
            // ist2lkDataSet2
            // 
            this.ist2lkDataSet2.DataSetName = "ist2lkDataSet2";
            this.ist2lkDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // endtimetxt
            // 
            this.endtimetxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "EndTime", true));
            this.endtimetxt.Location = new System.Drawing.Point(320, 182);
            this.endtimetxt.Name = "endtimetxt";
            this.endtimetxt.Size = new System.Drawing.Size(100, 24);
            this.endtimetxt.TabIndex = 27;
            // 
            // schooltypetxt
            // 
            this.schooltypetxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "SchoolType", true));
            this.schooltypetxt.FormattingEnabled = true;
            this.schooltypetxt.Items.AddRange(new object[] {
            "Public High School",
            "Private High School"});
            this.schooltypetxt.Location = new System.Drawing.Point(119, 99);
            this.schooltypetxt.Name = "schooltypetxt";
            this.schooltypetxt.Size = new System.Drawing.Size(180, 26);
            this.schooltypetxt.TabIndex = 6;
            // 
            // starttimetxt
            // 
            this.starttimetxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "StartTime", true));
            this.starttimetxt.Location = new System.Drawing.Point(121, 179);
            this.starttimetxt.Name = "starttimetxt";
            this.starttimetxt.Size = new System.Drawing.Size(100, 24);
            this.starttimetxt.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(227, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 18);
            this.label18.TabIndex = 24;
            this.label18.Text = "School end:";
            // 
            // schoolnametxt
            // 
            this.schoolnametxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "SchoolName", true));
            this.schoolnametxt.Location = new System.Drawing.Point(119, 62);
            this.schoolnametxt.Name = "schoolnametxt";
            this.schoolnametxt.Size = new System.Drawing.Size(276, 24);
            this.schoolnametxt.TabIndex = 5;
            // 
            // schoolidtxt
            // 
            this.schoolidtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "SchoolCode", true));
            this.schoolidtxt.Location = new System.Drawing.Point(121, 23);
            this.schoolidtxt.Name = "schoolidtxt";
            this.schoolidtxt.Size = new System.Drawing.Size(276, 24);
            this.schoolidtxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Level:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 18);
            this.label17.TabIndex = 23;
            this.label17.Text = "School Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "School Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "School Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 85);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "School Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sdisricttxt);
            this.groupBox2.Controls.Add(this.spostaltxt);
            this.groupBox2.Controls.Add(this.scitytxt);
            this.groupBox2.Controls.Add(this.sstreetnametxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 176);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address & Location";
            // 
            // sdisricttxt
            // 
            this.sdisricttxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "District", true));
            this.sdisricttxt.Location = new System.Drawing.Point(114, 136);
            this.sdisricttxt.Name = "sdisricttxt";
            this.sdisricttxt.Size = new System.Drawing.Size(276, 24);
            this.sdisricttxt.TabIndex = 15;
            // 
            // spostaltxt
            // 
            this.spostaltxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "PostalCode", true));
            this.spostaltxt.Location = new System.Drawing.Point(108, 103);
            this.spostaltxt.Name = "spostaltxt";
            this.spostaltxt.Size = new System.Drawing.Size(282, 24);
            this.spostaltxt.TabIndex = 14;
            // 
            // scitytxt
            // 
            this.scitytxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "City", true));
            this.scitytxt.Location = new System.Drawing.Point(108, 64);
            this.scitytxt.Name = "scitytxt";
            this.scitytxt.Size = new System.Drawing.Size(284, 24);
            this.scitytxt.TabIndex = 13;
            // 
            // sstreetnametxt
            // 
            this.sstreetnametxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "StreetName", true));
            this.sstreetnametxt.Location = new System.Drawing.Point(108, 27);
            this.sstreetnametxt.Name = "sstreetnametxt";
            this.sstreetnametxt.Size = new System.Drawing.Size(282, 24);
            this.sstreetnametxt.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "District:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Postal Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Street Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.principaltxt);
            this.groupBox3.Controls.Add(this.semailtxt);
            this.groupBox3.Controls.Add(this.stelephonenotxt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 580);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 152);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Information";
            // 
            // principaltxt
            // 
            this.principaltxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "PrincipalName", true));
            this.principaltxt.Location = new System.Drawing.Point(151, 104);
            this.principaltxt.Name = "principaltxt";
            this.principaltxt.Size = new System.Drawing.Size(223, 24);
            this.principaltxt.TabIndex = 21;
            // 
            // semailtxt
            // 
            this.semailtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "EmailAddress", true));
            this.semailtxt.Location = new System.Drawing.Point(151, 68);
            this.semailtxt.Name = "semailtxt";
            this.semailtxt.Size = new System.Drawing.Size(223, 24);
            this.semailtxt.TabIndex = 20;
            // 
            // stelephonenotxt
            // 
            this.stelephonenotxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "TelephoneNo", true));
            this.stelephonenotxt.Location = new System.Drawing.Point(151, 31);
            this.stelephonenotxt.Name = "stelephonenotxt";
            this.stelephonenotxt.Size = new System.Drawing.Size(223, 24);
            this.stelephonenotxt.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Principal Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Email Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telephone Number:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.snumberofclasses);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(465, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 65);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "School Statistics";
            // 
            // snumberofclasses
            // 
            this.snumberofclasses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolInfoBindingSource, "NumberOfClasses", true));
            this.snumberofclasses.Location = new System.Drawing.Point(161, 29);
            this.snumberofclasses.Name = "snumberofclasses";
            this.snumberofclasses.Size = new System.Drawing.Size(220, 24);
            this.snumberofclasses.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 18);
            this.label16.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 18);
            this.label14.TabIndex = 17;
            this.label14.Text = "Number of Classes:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 66);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 66);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 66);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 66);
            this.button5.TabIndex = 15;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(590, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(590, 298);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(590, 369);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(587, 438);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(3, 291);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(129, 66);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // ist2lkDataSet1
            // 
            this.ist2lkDataSet1.DataSetName = "ist2lkDataSet1";
            this.ist2lkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolbs
            // 
            this.schoolbs.DataMember = "Schoolinformation";
            this.schoolbs.DataSource = this.ist2lkDataSet1;
            // 
            // schoolinformationTableAdapter
            // 
            this.schoolinformationTableAdapter.ClearBeforeFill = true;
            // 
            // schoolInfoTableAdapter
            // 
            this.schoolInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(449, 212);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(135, 360);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // School_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 775);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "School_Info";
            this.Text = "School_Info";
            this.Load += new System.EventHandler(this.School_Info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2lkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolbs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox leveltxt;
        private System.Windows.Forms.ComboBox schooltypetxt;
        private System.Windows.Forms.TextBox schoolnametxt;
        private System.Windows.Forms.TextBox schoolidtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sdisricttxt;
        private System.Windows.Forms.TextBox spostaltxt;
        private System.Windows.Forms.TextBox scitytxt;
        private System.Windows.Forms.TextBox sstreetnametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox principaltxt;
        private System.Windows.Forms.TextBox semailtxt;
        private System.Windows.Forms.TextBox stelephonenotxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox endtimetxt;
        private System.Windows.Forms.TextBox starttimetxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox snumberofclasses;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private ist2lkDataSet1 ist2lkDataSet1;
        private System.Windows.Forms.BindingSource schoolbs;
        private ist2lkDataSet1TableAdapters.SchoolinformationTableAdapter schoolinformationTableAdapter;
        private ist2lkDataSet2 ist2lkDataSet2;
        private System.Windows.Forms.BindingSource schoolInfoBindingSource;
        private ist2lkDataSet2TableAdapters.SchoolInfoTableAdapter schoolInfoTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
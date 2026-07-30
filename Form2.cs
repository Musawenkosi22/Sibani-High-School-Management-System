using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace School_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void BtnClassRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void BtnSubject_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSubject form = new FormSubject();
            form.ShowDialog();
        }

        private void BtnAttendence_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void BtnEducation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.education.gov.za/",
                UseShellExecute = true
            });
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Exit aborted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher teacher = new Teacher();
            teacher.ShowDialog();
        }

        private void BtnSchool_Click(object sender, EventArgs e)
        {

            this.Hide();
            School_Info school_Info = new School_Info();
            school_Info.ShowDialog();
        }
    }
}

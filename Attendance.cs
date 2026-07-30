using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2lkDataSetAttendance1.Attendance' table. You can move, or remove it, as needed.
            //this.attendanceTableAdapter.Fill(this.ist2lkDataSetAttendance1.Attendance);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.attendanceTableAdapter.FillBy(this.ist2lkDataSetAttendance1.Attendance);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void saveAllBtn_Click(object sender, EventArgs e)
        {
            AttendanceBS.EndEdit();
            attendanceTableAdapter.Update(ist2lkDataSetAttendance1);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.attendanceTableAdapter.Fill(this.ist2lkDataSetAttendance1.Attendance);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AttendanceBS.AddNew();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTxt.Text = "";
            teacherid.Text = "";
            statusTxt.Text = "";
            StudentTxt.Text = "";

        }
    }
}

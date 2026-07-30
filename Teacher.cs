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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2lkDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.ist2lkDataSet1.Teachers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherBs.EndEdit();
            teachersTableAdapter.Update(ist2lkDataSet1);
            string firstname = tfirstnametxt.Text;
            string lastname = tlastnametxt.Text;

            string fullname = firstname + " " + lastname;

            MessageBox.Show(fullname + " is successfully saved to the system.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            staffnumbertxt.Text = "";
            tfirstnametxt.Text = "";
            tlastnametxt.Text = "";
            tstreettxt.Text = "";
            tcitytxt.Text = "";
            tdobtxt.Text = "";
            tphonetxt.Text = "";
            temailtxt.Text = "";
            tsearchtxt.Text = "";
            tgendertxt.Text = "";
            tracetxt.Text = "";
            tpostaltxt.Text = "";
            tdjtxt.Text = "";
            tidtxt.Text = "";
            tsurbubtxt.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            teacherBs.Filter = "TeacherNumber = '" + tsearchtxt.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teacherBs.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherBs.MoveLast();
            int currentteacherNo = int.Parse(staffnumbertxt.Text);
            teacherBs.AddNew();
            staffnumbertxt.Text = (currentteacherNo + 1).ToString("D5");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Fill(this.ist2lkDataSet1.Teachers);
        }
    }
}

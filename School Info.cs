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
    public partial class School_Info : Form
    {
        public School_Info()
        {
            InitializeComponent();
        }

        private void School_Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2lkDataSet2.SchoolInfo' table. You can move, or remove it, as needed.
            this.schoolInfoTableAdapter.Fill(this.ist2lkDataSet2.SchoolInfo);
            // TODO: This line of code loads data into the 'ist2lkDataSet1.Schoolinformation' table. You can move, or remove it, as needed.
         // this.schoolinformationTableAdapter.Fill(this.ist2lkDataSet1.Schoolinformation);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
                form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
         schoolidtxt.Text = "";
            schoolnametxt.Text = "";
            schooltypetxt.Text = "";
            stelephonenotxt.Text = "";
            scitytxt.Text = "";
            sdisricttxt.Text = "";
            sstreetnametxt.Text = "";
            spostaltxt.Text = "";
            snumberofclasses.Text = "";
           principaltxt.Text = "";
            semailtxt.Text = "";
            leveltxt.Text = "";
            starttimetxt.Text = "";
            endtimetxt.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

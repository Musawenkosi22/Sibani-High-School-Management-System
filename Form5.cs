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
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2lkDataSetSubject1.Subject' table. You can move, or remove it, as needed.
            //this.subjectTableAdapter.Fill(this.ist2lkDataSetSubject1.Subject);

        }

        private void newSubjectBtn_Click(object sender, EventArgs e)
        {
            SubjectBS.AddNew();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SubjectBS.EndEdit();
            subjectTableAdapter.Update(ist2lkDataSetSubject1);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.subjectTableAdapter.Fill(this.ist2lkDataSetSubject1.Subject);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subjectCodeTxt.Text = "";
            subjectNameTxt.Text = "";   
            descriptionTxt.Text = "";
            passRequirementTxt.Text = "";
        }
    }
}

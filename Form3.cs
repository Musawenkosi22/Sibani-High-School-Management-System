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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.dataSet11.Student);

        }

        private void moveLastBtn_Click(object sender, EventArgs e)
        {
            StudentBS.MoveLast();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            StudentBS.Filter = "StudentNumber = '" + textBox1.Text + "'";
        }

        private void date_JoinTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void newStudentBtn_Click(object sender, EventArgs e)
        {
            StudentBS.MoveLast();
            int currentStudentNo = int.Parse(studentNumberTxt.Text);
            StudentBS.AddNew();
            studentNumberTxt.Text = (currentStudentNo + 1).ToString();  
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StudentBS.EndEdit();
            studentTableAdapter.Update(dataSet11);
            string firstname = firstNameTxt.Text;
            string lastname = lastNameTxt.Text;

            string fullname = firstname + " " + lastname;

            MessageBox.Show(fullname + " is successfully saved to the system.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dataSet11.Student);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();  
           form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentNumberTxt.Text = "";
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            date_JoinTxt.Text = "";
            genderTxt.Text = "";
            streetTxt.Text = "";
            cityTxt.Text = "";
            postCodeTxt.Text = "";
            phoneNoTxt.Text = "";
            emailTxt.Text = "";
            dobTxt.Text = "";
            textBox1.Text = "";
            StudentBS.Filter = "";
            IDTxt.Text = "";
            surbubTxt.Text = "";
            parentNameTxt.Text = "";
            racetxt.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dataSet11.Student);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dataSet11.Student);
        }
    }
}

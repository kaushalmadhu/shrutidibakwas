using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrades
{
    public partial class Addstudent : Form
    {
        private ClassGrades addListItem;
        private string first;

        private Student student;

        public string First
        {
            get { return first; }
            set { first = value; }
        }


        internal Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public Addstudent()
        {
            InitializeComponent();
            addListItem = new ClassGrades();
        }

        private void submitMarksBtn_Click(object sender, EventArgs e)
        {
            
        }

       


        public void getItem(string a)
        {
            nametxt.Text = a.ToString();
        }







        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExamFinal_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submitMarksBtn_Click_1(object sender, EventArgs e)
        {
            string[] fullName = nametxt.Text.Split(',');

            student = new Student(fullName[1],fullName[0],  int.Parse(exam1txt.Text), int.Parse(exam2txt.Text), int.Parse(exam3txt.Text), int.Parse(fnltxt.Text));

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentGrades
{
    public partial class ClassGrades : Form
    {
        Addstudent addStudentDialog;

        public Addstudent AddDialog
        {
            get { return addStudentDialog; }
            set { addStudentDialog = value; }
        }
        private Student student;

        private StudentList _list;
        public ClassGrades()
        {
            InitializeComponent();
            _list = new StudentList();
            student = new Student();
        }

        private void OnSave(object sender, EventArgs e)
        {

            saveFileDialogClassGrades.Filter = "txt files (*.txt)|*.txt";
            saveFileDialogClassGrades.InitialDirectory =
                 Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory())); ;
            DialogResult result = openFileDialogClassGrades.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialogClassGrades.FileName;
                _list.WriteToFile(fileName);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {

            openFileDialogClassGrades.Filter = "txt files (*.txt)|*.txt";
            openFileDialogClassGrades.InitialDirectory =
                 Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory())); ;
            DialogResult result = openFileDialogClassGrades.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialogClassGrades.FileName;
                _list.ReadFromFile(fileName);
            }
        }
        private void onShow(object sender, EventArgs e)
        {
            foreach (Student student in _list)
            {
                classGradeListBox.Items.Add(student.ToString());
            }
        }

    
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialogClassGrades.Filter = "txt files (*.txt)|*.txt";
            openFileDialogClassGrades.InitialDirectory =
                 Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory())); ;
            DialogResult result = openFileDialogClassGrades.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialogClassGrades.FileName;
                _list.ReadFromFile(fileName);
            }
            foreach (Student student in _list.classList)// Reading student list.
            {
                classGradeListBox.Items.Add(student.ToString());
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogClassGrades.Filter = "txt files (*.txt)|*.txt";
            saveFileDialogClassGrades.InitialDirectory =
                 Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory())); ;
            DialogResult result = openFileDialogClassGrades.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialogClassGrades.FileName;
                _list.WriteToFile(fileName);
            }
        }
        private void addStudentMenuItem_Click(object sender, EventArgs e)
        {

           addStudentDialog = new Addstudent();
           DialogResult result = addStudentDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _list.classList.Add(addStudentDialog.Student);
               
            }
            classGradeListBox.Items.Add(addStudentDialog.Student.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classGradeListBox.Items.Clear();

            foreach (Student student in _list.classList)
            {
                student.CalcAverage();
                student.CalculateLetAverage();
                classGradeListBox.Items.Add(student.ToString());

            }
        }

        private void OnListBoxClick(object sender, MouseEventArgs e)
        {

          

            Addstudent addStudentDialog = new Addstudent();

           

          

            
            DialogResult result = addStudentDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _list.classList.Add(addStudentDialog.Student);

            }
            classGradeListBox.Items.Add(addStudentDialog.Student.ToString());



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void classGradeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

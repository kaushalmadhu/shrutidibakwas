using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    class Student
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private int _exam1;

        public int Exam1
        {
            get { return _exam1; }
            set { _exam1 = value; }
        }
        private int _exam2;

        public int Exam2
        {
            get { return _exam2; }
            set { _exam2 = value; }
        }
        private int _exam3;

        public int Exam3
        {
            get { return _exam3; }
            set { _exam3 = value; }
        }
        private int _finalExam;

        public int FinalExam
        {
            get { return _finalExam; }
            set { _finalExam = value; }
        }

        // for calculate grades button in the 'ClassGrades' form
        private double marksAverage;
        private char letterGrade;

        

        public Student() { }

        public Student(string firstname ,string lastname ,int exam1, int exam2, int exam3, int finalexam) {

            _firstName = firstname;
            _lastName = lastname;
            _exam1 = exam1;
            _exam2 = exam2;
            _exam3 = exam3;
            _finalExam = finalexam;

        }

        public double CalcAverage()
        {
            marksAverage = (_exam1 + _exam2 + _exam3 + _finalExam)/4;

            return marksAverage;
        }
        public override string ToString()
        {
            return _lastName + "," + _firstName  + "\t\t" + _exam1 + "\t " + _exam2 + "\t" + _exam3 + "\t" + _finalExam + "\t" + marksAverage + "\t" + letterGrade + "\n";
        }

        public char CalculateLetAverage()
        {

            marksAverage = CalcAverage();

            if (marksAverage >= 90)
            {
                letterGrade = 'A';
            }
            else if (marksAverage >= 80 && marksAverage < 90)
            {
                letterGrade = 'B';
            }
            else if (marksAverage >= 70 && marksAverage < 80)
            {
                letterGrade = 'C';
            }
            else if (marksAverage >= 60 && marksAverage < 70)
            {
                letterGrade = 'D';
            }
            else if (marksAverage >= 50 && marksAverage < 60)
            {
                letterGrade = 'E';
            }
            else
            {
                letterGrade = 'F';
            }
            return letterGrade;
        }
    }
}

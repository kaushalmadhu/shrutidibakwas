using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWriteFormsApplication
{
    class Write
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
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
        public Write(string first, int exam1, int exam2, int exam3, int finalexam)
        {
            _firstName = first;
            _finalExam = finalexam;
            _exam1 = exam1;
            _exam2 = exam2;
            _exam3 = exam3;
        }





        public override string ToString()
        {
            return _firstName + " " + " " + " " + " " + " " + "  " + " " + " " + _exam1 + "  " + " " + " " + " " + " " + " " + " " + " " + _exam2 + " " + " " + " " + " " + " " + " " + _exam3 + " " + " " + " " + " " + " " + " " + _finalExam;
        }


    }
}

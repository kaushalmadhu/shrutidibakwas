using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StudentGrades
{

    class StudentList : IEnumerable<Student>
    {
        //Dynamic Array
        private List<Student> _StudentList;

        public List<Student> classList
        {
            get { return _StudentList; }
            set { _StudentList = value; }
        }

        
        

        public StudentList()
        {
            _StudentList = new List<Student>();
        }


        //indexer
        public Student this[int idx]
        {
            get
            {// Return desired data.
                return _StudentList.ElementAt(idx);
            }
            set
            {// Set desired data using the “value”parameter}

                _StudentList.Add(value);
            }
        }

        //this method reads from the file
        public void ReadFromFile(string path)
        {

            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

                StreamReader streamReader = new StreamReader(fileStream);

                while (streamReader.Peek() != -1)
                {

                    string record = streamReader.ReadLine();
                    string[] fields = record.Split(',');
                    _StudentList.Add(new Student(fields[0], fields[1], int.Parse(fields[2]), int.Parse(fields[3]), int.Parse(fields[4]), int.Parse(fields[5])));



                }




                // Console.WriteLine("The Read operation has ended");

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");

            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }


        }

        // this method writes the records to the file
        public void WriteToFile(string path)
        {

            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);

                streamWriter = new StreamWriter(fileStream);


                foreach (Student student in _StudentList)
                {
                    streamWriter.WriteLine(student.FirstName + "," + student.LastName + "," + student.Exam1 + "," + student.Exam2 + "," + student.Exam3 + "," + student.FinalExam);
                }

                // Console.WriteLine("Write is done");

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");

            }
            finally
            {
                if (streamWriter != null)
                {

                    streamWriter.Close(); // closing the writer
                }
            }

        }




        public IEnumerator<Student> GetEnumerator()
        {
            return _StudentList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
}

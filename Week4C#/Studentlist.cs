using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4C_
{
    public class Studentlist
    {
        List<Student> studentList;

        public Studentlist()
        {
            studentList = new List<Student>();
        }

        public void Add(Student student)
        {
            studentList.Add(student);
        }


        public List<Student> GetStudents()
        {
            return studentList;
        }

        public Student[] ToArray()
        {
            //converting linked list to array
            return studentList.ToArray();

        }
    }
}

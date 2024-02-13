using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4C_
{
    public class Student
    {
        //defining student properties
        public string Name { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }

        //non arg constructer
        public Student() { }

        //parameterized constructer
        public Student(string name, int score1, int score2, int score3)
        {
            Name = name;
            Score1 = score1;
            Score2 = score2;    
            Score3 = score3;
        }

        //overriding the Tostring method to display acoordingly
        override
        public string ToString()
        {
            string s = $"{Name}|{Score1}|{Score2}|{Score3}";
            return s;
        }

    }
}

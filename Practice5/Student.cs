using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class Student
    {
        public string Name { get; private set; }
        public int English { get; private set; }
        public int Japanese { get; private set; }

        public Student(string name, int english, int japanese)
        {
            Name = name;
            English = english;
            Japanese = japanese;
        }
    }
}

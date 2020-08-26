using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public string Name { get;  set; }
        public int BirthMonth { get; set; }
        public int Birthday { get; set; }

        public Student(string name, int birthMonth, int birthday)
        {
            name = Name;
            birthMonth = BirthMonth;
            birthday = Birthday;
        }


    }
}

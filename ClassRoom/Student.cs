using System;

namespace ClassRoom
{
    public class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int Birthday { get; set; }

        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"Name: {Name} , Month: {BirthMonth}, day: {Birthday}";
        }

    }
}

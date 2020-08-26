using System;

namespace ClassRoom
{
    public class Student
    {
        private int _birthMonth;
        public string Name { get; }

        public int BirthMonth
        {
            get { return _birthMonth;}
        
            set
            {
                if(_birthMonth >= 1 && _birthMonth <= 12)
                    _birthMonth = value;
                else
                    throw new ArgumentException($"The value should be between 1-12, you wrote {value}");
            }
        }

        public int Birthday { get; }

        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"Name: {Name} , Month: {BirthMonth}, day: {Birthday}, Season: {Season()}";
        }

        //There must now be implemented a method "season" the returntype is a string. The methods returns what season for the student's birthday.
        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2) return "Winter"; 
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5) return "Spring";
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8) return "Summer"; 
            return "Autumn";
        }

    }
}

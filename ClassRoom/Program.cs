using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassRoom;

namespace ClassRoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create an new instance of the ClassRoom class

            ClassRoom classRoom = new ClassRoom();
            
            classRoom.ClassName = "Programming";
            
            //Add yourself and those you sit next to in the list of students
            classRoom.classList.Add(new Student("Josh",12, 24 ));
            classRoom.classList.Add(new Student("Ani",11, 17 ));
            classRoom.classList.Add(new Student("Elvis",04, 13 ));

             foreach (var student in classRoom.classList)
             {
                 Console.WriteLine(student);
             }

             classRoom.WhichSeason();


             Console.ReadKey();
        }



        
    }
}

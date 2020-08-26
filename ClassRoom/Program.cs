using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
             ClassRoom classRoom= new ClassRoom();
             classRoom.ClassName = "Programming";
             classRoom.classList.Add(new Student("Josh",12, 24 ));
             classRoom.classList.Add(new Student("Ani",11, 17 ));
             classRoom.classList.Add(new Student("Elvis",04, 13 ));
        }
    }
}

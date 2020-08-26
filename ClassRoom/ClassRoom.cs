using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> classList { get; set; } = new List<Student>();//or here in the constructor 

        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            //classList = new List<Student>();
        }

        //There must now be implemented a method which counts up to the class how many have birthday in each season. This method does not return anything, but just write the result out in the console

        //Where should this method lie?

        //hint. see if you can code it via a Linq statement
        public void WhichSeason()
        {
            var resultliste =
                classList.GroupBy(x => x.Season()).Select(aarstidGroup => new
                    {
                        aarstid = aarstidGroup.Key,
                        countAarstid = aarstidGroup.Count()
                    });

            foreach (var item in resultliste)
            {
                Console.WriteLine($"Season: {item.aarstid} Count: {item.countAarstid} ");

            }
        }
    }
}

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
        public List<Student> classList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            classList = new List<Student>();
        }
        
    }
}

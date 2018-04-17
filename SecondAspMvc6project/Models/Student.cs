using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondAspMvc6project.Models
{
    public class Student
    {
        // Byte[] poto { get; set; }

        public int id { get; set; }
        public string name { get; set; }
        public string subject   { get; set; }
        public string course { get; set; }
        public string institute{ get; set; }
        public DateTime time { get; set; }
        public DayOfWeek Dweek { get; }
        public DateTimeOffset dtoffset { get; }
     

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTW_Buoi2.Models
{
    public class Sudent
    {
        public int ID { get; set; }
        public String name { get; set; }
        public DateTime Birhday { get; set; }
        public int addressID { get; set; }
        public String addressFull { get; set; }

    }
}

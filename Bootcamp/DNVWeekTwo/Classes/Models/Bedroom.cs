using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Bedroom : Room
    {
        public int Bedcount { get; set; }
        public bool HasDesk { get; set; }
        public bool HasAttachedBathroom { get; set; }
        public int WindowCount { get; set; }

    }
}

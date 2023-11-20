using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Kitchen : Room
    {
        public bool HasIsland { get; set; }
        public string SinkType { get; set; }
        public string CounterMaterial { get; set; }
        public string StoveType { get; set; }
        public bool HasDishwasher { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class DiningRoom : Room
    {
        public bool HasBuffet { get; set; }
        public bool HasFrenchDoors { get; set; }
        public string TableType { get; set; }
        public int TableOccupancyCount { get; set; }

    }
}

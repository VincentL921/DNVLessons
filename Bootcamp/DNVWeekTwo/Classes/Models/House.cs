using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class House
    {
        public bool HasFoyer { get; set; }
        public int Stories { get; set; }
        public List<Room> Rooms { get; set; }
        public Yard Yard { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }


    }
}

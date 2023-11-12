using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Room
    {
        public string RoomType { get; set; }
        public int SquareFootage { get; set; }
        public bool HasCloset { get; set; }
        public string FlooringType { get; set; }

    }
}

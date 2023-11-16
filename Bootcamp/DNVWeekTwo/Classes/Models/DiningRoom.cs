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

        public void DisplayDiningRoomInfo()
        {
            var displayDiningRoom = this.RoomType;
            Console.WriteLine($"- {displayDiningRoom}");
            Console.WriteLine($"Table Occupancy: {this.TableOccupancyCount}");
            if (this.HasFrenchDoors == true && this.HasBuffet == true)
            {
                Console.WriteLine($"Buffet Section");
                Console.WriteLine($"French Doors Entry");
            }
            else if ((this.HasFrenchDoors == true) && (this.HasBuffet == false))
            {
                Console.WriteLine($"Buffet Section");
            }
            else if ((this.HasFrenchDoors == false) && (this.HasBuffet == true))
            {
                Console.WriteLine($"French Doors Entry");
            }
            else
            {
                Console.WriteLine($"");
            }
            Console.WriteLine("");
        }

    }
}

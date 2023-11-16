using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class LivingRoom : Room
    {
        public int WindowCount { get; set; }

        public void DisplayLivingRoomInfo()
        {
            var displayLivingRoom = this.RoomType;
            Console.WriteLine($"- {displayLivingRoom}");
            Console.WriteLine($"Square Footage: {this.SquareFootage}");
            Console.WriteLine($"Window Count: {this.WindowCount}");
            Console.WriteLine($"Flooring Type: {this.FlooringType}");
            Console.WriteLine("");
        }
    }
}

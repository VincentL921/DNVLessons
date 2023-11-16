using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Basement : Room
    {
        public void DisplayBasementInfo()
        {
            var displayBasement = this.RoomType;
            Console.WriteLine($"- {displayBasement}");
            Console.WriteLine($"Square Footage: {this.SquareFootage}");
            Console.WriteLine($"Flooring Type: {this.FlooringType}");
        }

    }
}

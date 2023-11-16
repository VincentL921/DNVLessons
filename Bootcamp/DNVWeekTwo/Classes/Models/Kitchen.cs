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

        public void DisplayKitchenInfo()
        {
            var kitchenNameDisplay = this.RoomType;
            Console.WriteLine($"- {kitchenNameDisplay}");
            Console.WriteLine("Features:");
            if (this.HasIsland == true && this.HasDishwasher == true)
            {
                Console.WriteLine($"Kitchen Island");
                Console.WriteLine($"Dishwasher");
            }
            else if ((this.HasIsland == true) && (this.HasDishwasher == false))
            {
                Console.WriteLine($"Kitchen Island");
            }
            else if ((this.HasIsland == false) && (this.HasDishwasher == true))
            {
                Console.WriteLine($"Dishwasher");
            }
            else
            {
                Console.WriteLine($"");
            }
            Console.WriteLine("");
        }
    }
}

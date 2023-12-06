using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderHomework.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }


        //trying to display the invoice while being able to show each product seperately
        //i think i went too far into the rabbit hole lol
        public void DisplayPlaystation(Product playstation)
        {
            var displayPlaystation = playstation.Name;
            Console.WriteLine($"- {displayPlaystation}");
            Console.WriteLine($"{playstation.Price}");
        }
        public void DisplayTracksuit(Product tracksuit)
        {
            var displayTracksuit = tracksuit.Name;
            Console.WriteLine($"- {displayTracksuit}");
            Console.WriteLine($"{tracksuit.Price}");
        }
        public void DisplayAirForceOnes(Product airForceOnes)
        {
            var displayAirForceOnes = airForceOnes.Name;
            Console.WriteLine($"- {displayAirForceOnes}");
            Console.WriteLine($"{airForceOnes.Price}");
        }
        public void DisplayVitamixBlender(Product vitamixBlender)
        {
            var displayvitamixBlender = vitamixBlender.Name;
            Console.WriteLine($"- {displayvitamixBlender}");
            Console.WriteLine($"{vitamixBlender.Price}");
        }

        public void DisplayInvoice()
        {
            Console.WriteLine("BIG DAVE'S VARIETY STORE");
            Console.WriteLine("");
            Console.WriteLine("INVOICE");
            Console.WriteLine("");

            foreach (var item in )
            {
                switch (item)
                {
                    case "Playstation":
                        var kitchenPrivate = (Product)item;
                        DisplayPlaystation(kitchenPrivate);
                        break;
                    case "Dining Room":
                        var diningRoomPrivate = (DiningRoom)item;
                        DisplayDiningRoom(diningRoomPrivate);
                        break;
                    case "Living Room":
                        var livingRoomPrivate = (LivingRoom)item;
                        DisplayLivingRoom(livingRoomPrivate);
                        break;
                    case "Basement":
                        var basementPrivate = (Basement)item;
                        DisplayBasement(basementPrivate);
                        break;

                }

            }
        }
    }
}

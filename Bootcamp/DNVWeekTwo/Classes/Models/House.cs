using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class House
    {
        public House()
        {
            Rooms = new List<Room>();
            Yard = new Yard();
        }
        public bool HasFoyer { get; set; }
        public int Stories { get; set; }
        public List<Room> Rooms { get; set; }
        public Yard Yard { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }

        private void DisplayKitchen(Kitchen kitchen)
        {
            var kitchenNameDisplay = kitchen.RoomType;
            Console.WriteLine($"- {kitchenNameDisplay}");
            Console.WriteLine("Features:");
            if (kitchen.HasIsland == true && kitchen.HasDishwasher == true)
            {
                Console.WriteLine($"Kitchen Island");
                Console.WriteLine($"Dishwasher");
            }
            else if ((kitchen.HasIsland == true) && (kitchen.HasDishwasher == false))
            {
                Console.WriteLine($"Kitchen Island");
            }
            else if ((kitchen.HasIsland == false) && (kitchen.HasDishwasher == true))
            {
                Console.WriteLine($"Dishwasher");
            }
            else
            {
                Console.WriteLine($"");
            }
            Console.WriteLine("");
        }

        private void DisplayDiningRoom(DiningRoom diningRoom)
        {
            var displayDiningRoom = diningRoom.RoomType;
            Console.WriteLine($"- {displayDiningRoom}");
            Console.WriteLine($"Table Occupancy: {diningRoom.TableOccupancyCount}");
            if (diningRoom.HasFrenchDoors == true && diningRoom.HasBuffet == true)
            {
                Console.WriteLine($"Buffet Section");
                Console.WriteLine($"French Doors Entry");
            }
            else if ((diningRoom.HasFrenchDoors == true) && (diningRoom.HasBuffet == false))
            {
                Console.WriteLine($"Buffet Section");
            }
            else if ((diningRoom.HasFrenchDoors == false) && (diningRoom.HasBuffet == true))
            {
                Console.WriteLine($"French Doors Entry");
            }
            else
            {
                Console.WriteLine($"");
            }
        }

        private void DisplayLivingRoom (LivingRoom livingRoom)
        {
            var displayLivingRoom = livingRoom.RoomType;
            Console.WriteLine($"- {displayLivingRoom}");
            Console.WriteLine($"Square Footage: {livingRoom.SquareFootage}");
            Console.WriteLine($"Window Count: {livingRoom.WindowCount}");
            Console.WriteLine($"Flooring Type: {livingRoom.FlooringType}");
            Console.WriteLine("");
        }

        private void DisplayBasement (Basement basement)
        {
            var displayBasement = basement.RoomType;
            Console.WriteLine($"- {displayBasement}");
            Console.WriteLine($"Square Footage: {basement.SquareFootage}");
            Console.WriteLine($"Flooring Type: {basement.FlooringType}");
            Console.WriteLine("");
        }
                
            
        public void DisplayListing()
            {

            Console.WriteLine("House Listing:");
            Console.WriteLine("");

            Console.WriteLine($"{this.Address}");
            Console.WriteLine($"{this.City},{this.State} {this.ZipCode} - {this.Country}");
            Console.WriteLine("");
            var totalSquareFootage = this.Rooms.Sum(r => r.SquareFootage);
            Console.WriteLine($"Total Square Footage: {totalSquareFootage}");
            var totalRooms = this.Rooms.Count();
            Console.WriteLine($"Total rooms: {totalRooms}");

            Console.WriteLine("");
            Console.WriteLine("Facts & Features:");

            Console.WriteLine("Interior Features");
            var bedroomCount = this.Rooms.Count(r => r.RoomType.Contains("Bedroom"));
            Console.WriteLine($"- Bedrooms");
            Console.WriteLine($"Bedrooms: {bedroomCount}");
            Console.WriteLine("");

            foreach (var item in this.Rooms)
            {
                switch (item.RoomType)
                {
                    case "Kitchen":
                        var kitchenPrivate = (Kitchen)item;
                        DisplayKitchen(kitchenPrivate);
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

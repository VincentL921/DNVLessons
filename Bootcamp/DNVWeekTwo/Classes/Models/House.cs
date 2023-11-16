using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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


        public void DisplayGenHouseListInfo()
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
        }

    }
}

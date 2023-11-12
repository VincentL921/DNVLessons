using Classes;
using Classes.Models;

var vinsHouse = new House();
var davesHouse = new House();


#region vinsHouse info
vinsHouse.HasFoyer = true;
vinsHouse.Yard = new Yard();
vinsHouse.Rooms = new List<Room>();

vinsHouse.Address = "1126 83rd Street";
vinsHouse.City = "Brooklyn";
vinsHouse.State = "NY";
vinsHouse.Country = "USA";
vinsHouse.ZipCode = 11228;
vinsHouse.Stories = 2;
vinsHouse.Yard.HasFence = true;
vinsHouse.Yard.HasDeck = true;
vinsHouse.Yard.HasGrass = false;
vinsHouse.Yard.hasParking = true;

var kitchen = new Kitchen();
kitchen.RoomType = "Kitchen";
kitchen.SquareFootage = 100;
kitchen.HasCloset = true;
kitchen.FlooringType = "Porcelian Tile";
kitchen.HasIsland = true;
kitchen.HasDishwasher = true;
kitchen.CounterMaterial = "Granite";
kitchen.StoveType = "Gas";
kitchen.SinkType = "ClassicSink";

vinsHouse.Rooms.Add(kitchen);

var masterBedroom = new Bedroom();
masterBedroom.RoomType = "Bedroom";
masterBedroom.SquareFootage = 200;
masterBedroom.HasCloset = true;
masterBedroom.FlooringType = "Porcelian Tile";
masterBedroom.Bedcount = 1;
masterBedroom.HasDesk = false;
masterBedroom.HasAttachedBathroom = true;
masterBedroom.WindowCount = 2;

vinsHouse.Rooms.Add(masterBedroom);

var masterBedroomTwo = new Bedroom();
masterBedroomTwo.RoomType = "Bedroom";
masterBedroomTwo.SquareFootage = 200;
masterBedroomTwo.HasCloset = true;
masterBedroomTwo.FlooringType = "Porcelian Tile";
masterBedroomTwo.Bedcount = 1;
masterBedroomTwo.HasDesk = false;
masterBedroomTwo.HasAttachedBathroom = true;
masterBedroomTwo.WindowCount = 2;

vinsHouse.Rooms.Add(masterBedroomTwo);

var regBedroomOne = new Bedroom();
regBedroomOne.RoomType = "Bedroom";
regBedroomOne.SquareFootage = 300;
regBedroomOne.HasCloset = true;
regBedroomOne.FlooringType = "Vinyl Flooring";
regBedroomOne.Bedcount = 2;
regBedroomOne.HasDesk = true;
regBedroomOne.HasAttachedBathroom = false;
regBedroomOne.WindowCount = 2;

vinsHouse.Rooms.Add(regBedroomOne);

var regBedroomTwo = new Bedroom();
regBedroomTwo.RoomType = "Bedroom";
regBedroomTwo.SquareFootage = 200;
regBedroomTwo.HasCloset= true;
regBedroomTwo.FlooringType = "Vinyl Flooring";
regBedroomTwo.Bedcount = 2;
regBedroomTwo.HasDesk = true;
regBedroomTwo.HasAttachedBathroom= false;
regBedroomTwo.WindowCount = 1;

vinsHouse.Rooms.Add(regBedroomTwo);

var homeOffice = new HomeOffice();
homeOffice.RoomType = "Home Office";
homeOffice.SquareFootage = 150;
homeOffice.HasCloset= true;
homeOffice.FlooringType = "Wood-Look Porcelian Tile";
homeOffice.WindowCount = 1;

vinsHouse.Rooms.Add(homeOffice);

var livingRoom = new LivingRoom();
livingRoom.RoomType = "Living Room";
livingRoom.SquareFootage= 500;
livingRoom.HasCloset = false;
livingRoom.FlooringType = "Wood-Look Porcelian Tile";
livingRoom.WindowCount = 3;

vinsHouse.Rooms.Add(livingRoom);

var basement =  new Basement();
basement.RoomType = "Basement";
basement.SquareFootage = 2000;
basement.HasCloset= true;
basement.FlooringType = "Porcelain Tile";

vinsHouse.Rooms.Add(basement);

var diningRooms = new DiningRoom();
diningRooms.RoomType = "Dining Room";
diningRooms.SquareFootage = 300;
diningRooms.HasCloset = false;
diningRooms.FlooringType = "Wood-Look Porceilain Tile";
diningRooms.HasBuffet = true;
diningRooms.HasFrenchDoors = true;
diningRooms.TableOccupancyCount = 8;

vinsHouse.Rooms.Add(diningRooms);
#endregion

#region davesHouse info
davesHouse.HasFoyer = true;
davesHouse.Yard = new Yard();
davesHouse.Rooms = new List<Room>();

davesHouse.Address = "1126 83rd Street";
davesHouse.City = "Brooklyn";
davesHouse.State = "NY";
davesHouse.Country = "USA";
davesHouse.ZipCode = 11228;
davesHouse.Stories = 2;
davesHouse.Yard.HasFence = true;
davesHouse.Yard.HasDeck = true;
davesHouse.Yard.HasGrass = false;
davesHouse.Yard.hasParking = true;

var davesKitchen = new Kitchen();
davesKitchen.RoomType = "Kitchen";
davesKitchen.SquareFootage = 100;
davesKitchen.HasCloset = true;
davesKitchen.FlooringType = "Porcelian Tile";
davesKitchen.HasIsland = true;
davesKitchen.HasDishwasher = true;
davesKitchen.CounterMaterial = "Granite";
davesKitchen.StoveType = "Gas";
davesKitchen.SinkType = "ClassicSink";

davesHouse.Rooms.Add(davesKitchen);

var davesMasterBedroom = new Bedroom();
davesMasterBedroom.RoomType = "Bedroom";
davesMasterBedroom.SquareFootage = 200;
davesMasterBedroom.HasCloset = true;
davesMasterBedroom.FlooringType = "Porcelian Tile";
davesMasterBedroom.Bedcount = 1;
davesMasterBedroom.HasDesk = false;
davesMasterBedroom.HasAttachedBathroom = true;
davesMasterBedroom.WindowCount = 2;

davesHouse.Rooms.Add(davesMasterBedroom);

var davesMasterBedroomTwo = new Bedroom();
davesMasterBedroomTwo.RoomType = "Bedroom";
davesMasterBedroomTwo.SquareFootage = 200;
davesMasterBedroomTwo.HasCloset = true;
davesMasterBedroomTwo.FlooringType = "Porcelian Tile";
davesMasterBedroomTwo.Bedcount = 1;
davesMasterBedroomTwo.HasDesk = false;
davesMasterBedroomTwo.HasAttachedBathroom = true;
davesMasterBedroomTwo.WindowCount = 2;

davesHouse.Rooms.Add(davesMasterBedroomTwo);

var davesRegBedroomOne = new Bedroom();
davesRegBedroomOne.RoomType = "Bedroom";
davesRegBedroomOne.SquareFootage = 300;
davesRegBedroomOne.HasCloset = true;
davesRegBedroomOne.FlooringType = "Vinyl Flooring";
davesRegBedroomOne.Bedcount = 2;
davesRegBedroomOne.HasDesk = true;
davesRegBedroomOne.HasAttachedBathroom = false;
davesRegBedroomOne.WindowCount = 2;

davesHouse.Rooms.Add(davesRegBedroomOne);

var davesRegBedroomTwo = new Bedroom();
davesRegBedroomTwo.RoomType = "Bedroom";
davesRegBedroomTwo.SquareFootage = 200;
davesRegBedroomTwo.HasCloset = true;
davesRegBedroomTwo.FlooringType = "Vinyl Flooring";
davesRegBedroomTwo.Bedcount = 2;
davesRegBedroomTwo.HasDesk = true;
davesRegBedroomTwo.HasAttachedBathroom = false;
davesRegBedroomTwo.WindowCount = 1;

davesHouse.Rooms.Add(davesRegBedroomTwo);

var davesHomeOffice = new HomeOffice();
davesHomeOffice.RoomType = "Home Office";
davesHomeOffice.SquareFootage = 150;
davesHomeOffice.HasCloset = true;
davesHomeOffice.FlooringType = "Wood-Look Porcelian Tile";
davesHomeOffice.WindowCount = 1;

davesHouse.Rooms.Add(davesHomeOffice);

var davesLivingRoom = new LivingRoom();
davesLivingRoom.RoomType = "Living Room";
davesLivingRoom.SquareFootage = 500;
davesLivingRoom.HasCloset = false;
davesLivingRoom.FlooringType = "Wood-Look Porcelian Tile";
davesLivingRoom.WindowCount = 3;

davesHouse.Rooms.Add(davesLivingRoom);

var davesBasement = new Basement();
davesBasement.RoomType = "Basement";
davesBasement.SquareFootage = 2000;
davesBasement.HasCloset = true;
davesBasement.FlooringType = "Porcelain Tile";

davesHouse.Rooms.Add(davesBasement);

var davesDiningRoom = new DiningRoom();
davesDiningRoom.RoomType = "Dining Room";
davesDiningRoom.SquareFootage = 300;
davesDiningRoom.HasCloset = false;
davesDiningRoom.FlooringType = "Wood-Look Porceilain Tile";
davesDiningRoom.HasBuffet = true;
davesDiningRoom.HasFrenchDoors = true;
davesDiningRoom.TableOccupancyCount = 8;

davesHouse.Rooms.Add(davesDiningRoom);
#endregion

//house.Add(vinsHouse);
//First changed the house as a list and made my house as an object in the list,
//but changed it back to original way to get the lamba counts.

#region vinsHouse Listing
Console.WriteLine("House Listing:");
Console.WriteLine("");

Console.WriteLine($"{vinsHouse.Address}");
Console.WriteLine($"{vinsHouse.City},{vinsHouse.State} {vinsHouse.ZipCode} - {vinsHouse.Country}");
Console.WriteLine("");
var totalSquareFootage = vinsHouse.Rooms.Sum(r => r.SquareFootage);
Console.WriteLine($"Total Square Footage: {totalSquareFootage}");
var totalRooms = vinsHouse.Rooms.Count();
Console.WriteLine($"Total rooms: {totalRooms}");

Console.WriteLine("");
Console.WriteLine("Facts & Features:");

Console.WriteLine("Interior Features");
var bedroomCount = vinsHouse.Rooms.Count(r => r.RoomType.Contains("Bedroom"));
Console.WriteLine($"- Bedrooms");
Console.WriteLine($"Bedrooms: {bedroomCount}");
//Need to go back and get the sum of beds - VL 11/11/2023
Console.WriteLine("");
Console.WriteLine($"- {kitchen.RoomType}");
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
else
{
    Console.WriteLine($"Dishwasher");
}
Console.WriteLine("");
Console.WriteLine($"- {diningRooms.RoomType}");
Console.WriteLine($"Table Occupancy: {diningRooms.TableOccupancyCount}");
if (diningRooms.HasFrenchDoors == true && diningRooms.HasBuffet == true)
{
    Console.WriteLine($"Buffet Section");
    Console.WriteLine($"French Doors Entry");
}
else if ((diningRooms.HasFrenchDoors == true) && (diningRooms.HasBuffet == false))
{
    Console.WriteLine($"Buffet Section");
}
else
{
    Console.WriteLine($"French Doors Entry");
}
Console.WriteLine("");
Console.WriteLine($"- {livingRoom.RoomType}");
Console.WriteLine($"Square Footage: {livingRoom.SquareFootage}");
Console.WriteLine($"Window Count: {livingRoom.WindowCount}");
Console.WriteLine($"Flooring Type: {livingRoom.FlooringType}");
Console.WriteLine("");
Console.WriteLine($"- {basement.RoomType}");
Console.WriteLine($"Square Footage: {basement.SquareFootage}");
Console.WriteLine($"Flooring Type: {basement.FlooringType}");
#endregion


//For code
//Model this house object after the house I grew up in
//Master bedrooms, number of other bedrooms
//that means if it's a 4 bedroom house, then rooms collection should have 4 bedrooms
//Finish out building out my house, the build out daves 3 bedroom house, make up other objects & values, make them different from my house
//If I get far enough, display the house info - specifically like a zillow ad
//create a way to display it like a zillow add for a house
//Similar to the one construction ones we did
//*KEY* - when starting to add bedrooms to the collection, make sure the room type is always bedroom

//For research
//What's the difference between a constructor & method?
//What's the difference between inheriting from a class & inheriting from an interface?
//Perfereably in my own words for both - academic terms help too

﻿using Classes;
using Classes.Models;

var vinsHouse = new House();
var davesHouse = new House();


#region vinsHouse info
vinsHouse.HasFoyer = true;
//moved to House constructor
//vinsHouse.Yard = new Yard();
//vinsHouse.Rooms = new List<Room>();

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

davesHouse.Address = "818 E Morningside Dr NE";
davesHouse.City = "Atlanta";
davesHouse.State = "GA";
davesHouse.Country = "USA";
davesHouse.ZipCode = 30324;
davesHouse.Stories = 2;
davesHouse.Yard.HasFence = true;
davesHouse.Yard.HasDeck = true;
davesHouse.Yard.HasGrass = true;
davesHouse.Yard.hasParking = true;

var davesKitchen = new Kitchen();
davesKitchen.RoomType = "Kitchen";
davesKitchen.SquareFootage = 200;
davesKitchen.HasCloset = true;
davesKitchen.FlooringType = "Hardwood Flooring";
davesKitchen.HasIsland = false;
davesKitchen.HasDishwasher = true;
davesKitchen.CounterMaterial = "Granite";
davesKitchen.StoveType = "Gas";
davesKitchen.SinkType = "ClassicSink";

davesHouse.Rooms.Add(davesKitchen);

var davesMasterBedroom = new Bedroom();
davesMasterBedroom.RoomType = "Bedroom";
davesMasterBedroom.SquareFootage = 400;
davesMasterBedroom.HasCloset = true;
davesMasterBedroom.FlooringType = "Hardwood Flooring";
davesMasterBedroom.Bedcount = 1;
davesMasterBedroom.HasDesk = true;
davesMasterBedroom.HasAttachedBathroom = true;
davesMasterBedroom.WindowCount = 3;

davesHouse.Rooms.Add(davesMasterBedroom);

var davesRegBedroomThree = new Bedroom();
davesRegBedroomThree.RoomType = "Bedroom";
davesRegBedroomThree.SquareFootage = 300;
davesRegBedroomThree.HasCloset = true;
davesRegBedroomThree.FlooringType = "Hardwood Flooring";
davesRegBedroomThree.Bedcount = 1;
davesRegBedroomThree.HasDesk = true;
davesRegBedroomThree.HasAttachedBathroom = true;
davesRegBedroomThree.WindowCount = 3;

davesHouse.Rooms.Add(davesRegBedroomThree);

var davesRegBedroomOne = new Bedroom();
davesRegBedroomOne.RoomType = "Bedroom";
davesRegBedroomOne.SquareFootage = 300;
davesRegBedroomOne.HasCloset = true;
davesRegBedroomOne.FlooringType = "Hardwood Flooring";
davesRegBedroomOne.Bedcount = 1;
davesRegBedroomOne.HasDesk = true;
davesRegBedroomOne.HasAttachedBathroom = true;
davesRegBedroomOne.WindowCount = 3;

davesHouse.Rooms.Add(davesRegBedroomOne);

var davesRegBedroomTwo = new Bedroom();
davesRegBedroomTwo.RoomType = "Bedroom";
davesRegBedroomTwo.SquareFootage = 300;
davesRegBedroomTwo.HasCloset = true;
davesRegBedroomTwo.FlooringType = "Hardwood Flooring";
davesRegBedroomTwo.Bedcount = 1;
davesRegBedroomTwo.HasDesk = true;
davesRegBedroomTwo.HasAttachedBathroom = true;
davesRegBedroomTwo.WindowCount = 3;

davesHouse.Rooms.Add(davesRegBedroomTwo);

var davesHomeOffice = new HomeOffice();
davesHomeOffice.RoomType = "Home Office";
davesHomeOffice.SquareFootage = 150;
davesHomeOffice.HasCloset = true;
davesHomeOffice.FlooringType = "Hardwood Flooring";
davesHomeOffice.WindowCount = 2;

davesHouse.Rooms.Add(davesHomeOffice);

var davesLivingRoom = new LivingRoom();
davesLivingRoom.RoomType = "Living Room";
davesLivingRoom.SquareFootage = 500;
davesLivingRoom.HasCloset = false;
davesLivingRoom.FlooringType = "Hardwood Flooring";
davesLivingRoom.WindowCount = 5;

davesHouse.Rooms.Add(davesLivingRoom);

var davesBasement = new Basement();
davesBasement.RoomType = "Basement";
davesBasement.SquareFootage = 2000;
davesBasement.HasCloset = true;
davesBasement.FlooringType = "Carpet";

davesHouse.Rooms.Add(davesBasement);

var davesDiningRoom = new DiningRoom();
davesDiningRoom.RoomType = "Dining Room";
davesDiningRoom.SquareFootage = 300;
davesDiningRoom.HasCloset = false;
davesDiningRoom.FlooringType = "Hardwood Flooring";
davesDiningRoom.HasBuffet = true;
davesDiningRoom.HasFrenchDoors = true;
davesDiningRoom.TableOccupancyCount = 5;

davesHouse.Rooms.Add(davesDiningRoom);
#endregion


#region davesHouse w/ methods
davesHouse.DisplayListing();
#endregion

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

#region vinsHouse w/ methods
vinsHouse.DisplayListing();
#endregion



#region last week's HW 11/11/23
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
#endregion

//for Thursday
//Move all of the Console.WriteLines into a self-created DisplayListing() method for the House class
//If have time
//F thats delicious is the project name
//Set up a class called oven, and a class called food
//for food at bare min - time to cook property, food name property, food type property - 3 most important properties
//create a few beef, chicken, fish & vegetable food type variables
//on oven class - make all the methods return void right now
//oven methods - add() to pass in one food object in add, addRange() to pass in a collection of food items, getCookTime() method, & method of getTimeRemaining(), & method setTimeElapsed()

//research for thursday
//look up method overloading
//tell dave what it is & what its benefits are

using FoodShowHomework.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

var foodItems = new List<Food>();
var oven = new Oven();

var chickenParm = new Food();
var friedChicken = new Food();
var roastChicken = new Food();

var cheeseBurger = new Food();
var filetMignon = new Food();
var steakBurrito = new Food();

var fishAndChips = new Food();
var bakedSalmon = new Food();
var friedCalamari = new Food();

var cobbSalad = new Food();
var ratatouille = new Food();
var stuffedPeppers = new Food();

chickenParm.FoodName = "Chicken Parm";
chickenParm.FoodType = "Chicken";
chickenParm.CookTimeMin = 45;

friedChicken.FoodName = "Nashville Fried Chicken";
friedChicken.FoodType = "Chicken";
friedChicken.CookTimeMin = 44;

roastChicken.FoodName = "Whole Roast Chicken";
roastChicken.FoodType = "Chicken";
roastChicken.CookTimeMin = 105;

cheeseBurger.FoodName = "Cheese Burger";
cheeseBurger.FoodType = "Beef";
cheeseBurger.CookTimeMin = 20;

filetMignon.FoodName = "Filet Mignon";
filetMignon.FoodType = "Beef";
filetMignon.CookTimeMin = 20;

steakBurrito.FoodName = "Steak Burrito";
steakBurrito.FoodType = "Beef";
steakBurrito.CookTimeMin = 30;

fishAndChips.FoodName = "Fish And Chips";
fishAndChips.FoodType = "Fish";
fishAndChips.CookTimeMin = 65;

bakedSalmon.FoodName = "Baked Salmon";
bakedSalmon.FoodType = "Fish";
bakedSalmon.CookTimeMin = 15;

friedCalamari.FoodName = "Fried Calamari";
friedCalamari.FoodType = "Fish";
friedCalamari.CookTimeMin = 25;

cobbSalad.FoodName = "Cobb Salad";
cobbSalad.FoodType = "Vegetables";
cobbSalad.CookTimeMin = 40;

ratatouille.FoodName = "Ratatouille";
ratatouille.FoodType = "Vegatables";
ratatouille.CookTimeMin = 90;

stuffedPeppers.FoodName = "Stuffed Peppers";
stuffedPeppers.FoodType = "Vegatables";
stuffedPeppers.CookTimeMin = 95;

foodItems.Add(chickenParm);
foodItems.Add(friedChicken);
foodItems.Add(roastChicken);
foodItems.Add(cheeseBurger);
foodItems.Add(filetMignon);
foodItems.Add(steakBurrito);
foodItems.Add(fishAndChips);
foodItems.Add(bakedSalmon);
foodItems.Add(friedCalamari);
foodItems.Add(cobbSalad);
foodItems.Add(ratatouille);
foodItems.Add(stuffedPeppers);



//F thats delicious is the project name
//Set up a class called oven, and a class called food
//for food at bare min - time to cook property, food name property, food type property - 3 most important properties
//create a few beef, chicken, fish & vegetable food type variables
//on oven class - make all the methods return void right now
//oven methods - add() to pass in one food object in add() with method overloading to pass in a collection of food items, getCookTime() method, & method of getTimeRemaining(), & method setTimeElapsed()
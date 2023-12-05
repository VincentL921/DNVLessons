using OrderHomework.Models;
using System.Collections.Generic;
using System.Xml.Linq;

var orderedItems = new List<Product>();

var playstationFive = new Product();
var samsungTV = new Product();

var adidasTracksuit = new Product();
var nikeHoodie = new Product();

var airForceOnes = new Product();
var nikeDunks = new Product();

var kitchenAidMixer = new Product();
var vitamixBlender = new Product();

playstationFive.Name = "Playstation 5";
playstationFive.Department = "Electronics";
playstationFive.Cost = 225.0;
playstationFive.Price = 450.0;

samsungTV.Name = "50in Samsung Smart TV";
samsungTV.Department = "Electronics";
samsungTV.Cost = 140.0;
samsungTV.Price = 280.0;

adidasTracksuit.Name = "USA Adidas Tracksuit";
adidasTracksuit.Department = "Clothing";
adidasTracksuit.Cost = 40.0;
adidasTracksuit.Price = 80.0;

nikeHoodie.Name = "Nike Air Max Hoodie";
nikeHoodie.Department = "Clothing";
nikeHoodie.Cost = 55.0;
nikeHoodie.Price = 110.0;

airForceOnes.Name = "Nike Air Force 1 Uptowns";
airForceOnes.Department = "Shoes";
airForceOnes.Cost = 57.50;
airForceOnes.Price = 115.0;

nikeDunks.Name = "Nike Panda Dunks";
nikeDunks.Department = "Shoes";
nikeDunks.Cost = 72.50;
nikeDunks.Price = 115.0;

kitchenAidMixer.Name = "KitchenAid Stand Mixer";
kitchenAidMixer.Department = "Kitchenware";
kitchenAidMixer.Cost = 175.0;
kitchenAidMixer.Price = 350.0;

vitamixBlender.Name = "Vitamix Blender";
vitamixBlender.Department = "Kitchenware";
vitamixBlender.Cost = 150.0;
vitamixBlender.Price = 300.0;

var order = new Order();
order.Add(orderedItems);

var average = order.GetTotalCost();



//class Order
//    list of products in which we use methods to add to the order as a private variable.
//    private variable for currentBalanceOwed -
//    private variable for amountPaid -

//class Product
//    name
//    department
//    sale price
//    unit cost

//On order class

//*we need 2 methods for ADd products -> one to add a single product, one to add a collection of Products.

//* methods to 
//    * get total cost
//    * add 1 overload to get total cost by department.
//        - note, you've done this in weekone -> collections code/project
//    * get average cost
//    * get total price
//    * get average price
//    * making payment -> we need to track total amount paid so use private variable above to do so and add to itself.
//    * get remaining balance

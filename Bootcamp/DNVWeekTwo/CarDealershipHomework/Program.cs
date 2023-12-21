using CarDealershipHomework.Models;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

var carsInLot = new TestData();

carsInLot.Build();

var davesDealership = new Dealership();
davesDealership.Add(mazda626);
davesDealership.Add(porsche968);
davesDealership.Add(saturnOutlook);
davesDealership.Add(toyotaTundra);
davesDealership.Add(mazdaMazda3);
davesDealership.Add(fordFocus);
davesDealership.Add(landRoverRangeRover);
davesDealership.Add(lincolnMks);
davesDealership.Add(pontiacGrandAm);
davesDealership.Add(lexusIsf);
davesDealership.Add(mercedesSClass);
davesDealership.Add(audi5000S);
davesDealership.Add(subaruBrat);
davesDealership.Add(cadillacCatera);
davesDealership.Add(fiat500);
davesDealership.Add(nissan370Z);
davesDealership.Add(nissan200SX);
davesDealership.Add(teslaModelS);
davesDealership.Add(teslamodelX);
davesDealership.Add(mitsubishiEvo);

var total = davesDealership.GetNumberOfCars();
//Console.WriteLine(total);

davesDealership.DisplayCarInventory();


//*Dealership-> class
//    private variable of Cars which is a collection of Car checked

//    method to Add -> pass in a single car or a collection of cars -> hint: overload.
//    * A method to get the number of cars on the lot
//        overload to get the number of electric vehicles on the lot.
//        hint: reading comprehension important "get the number of vehicles on the lot" ex: if its sold its noton lot.

//    *A method to get the total msrp of all cars
//        an overload to get total msrp of electric vehicles.
//        another overload to get total msrp by make.
//    * A method to get the average msrp of all cars
//        an overload to get average msrp of electric vehicles.
//        another overload to get average msrp by make.
//    * Average odometer value of all cars on the lot.
//        overload for average odometer reading by electric vehicles.
//        overload for average odometer reading by make
//    * Average age of vehicles on the lot.
//        overload for average age of vehicles by make.

//    * create amethod to display inventory of dealrship.
//        utilize all methods above to print out data about the daerlship
//            in a readable manner
//        within this method, get the unique makes of all vehicles currently on the lot
//            in order to loop over and utilize any methods with overloads by make.

//    * 

//* Class of Car
//    year
//    make
//    model
//    odometer -> capture # of miles.
//    MSRP
//    is electric
//    is sold

//    * add a method to this class to display just the information about this individaual car.

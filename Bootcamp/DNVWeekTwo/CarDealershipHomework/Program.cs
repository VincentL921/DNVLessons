using CarDealershipHomework.Models;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

var carsInLot = new List<Car>();

var mazda626 = new Car();
var porsche968 = new Car();
var saturnOutlook = new Car();
var toyotaTundra = new Car();
var mazdaMazda3 = new Car();
var fordFocus = new Car();
var landRoverRangeRover = new Car();
var lincolnMks = new Car();
var pontiacGrandAm = new Car();
var lexusIsf = new Car();
var mercedesSClass = new Car();
var audi5000S = new Car();
var subaruBrat = new Car();
var cadillacCatera = new Car();
var fiat500 = new Car();
var nissan370Z = new Car();
var nissan200SX = new Car();
var teslaModelS = new Car();
var teslamodelX = new Car();
var mitsubishiEvo = new Car();

mazda626.Make = "Mazda";
mazda626.Model = "626";
mazda626.Year = 2002;
mazda626.Odometer = 19053;
mazda626.MSRP = 35343.42;
mazda626.IsElectric = false;
mazda626.IsSold = false;

porsche968.Make = "Porsche";
porsche968.Model = "968";
porsche968.Year = 1995;
porsche968.Odometer = 9791;
porsche968.MSRP = 3691.22;
porsche968.IsElectric = false;
porsche968.IsSold = true;

saturnOutlook.Make = "Saturn";
saturnOutlook.Model = "Outlook";
saturnOutlook.Year = 2007;
saturnOutlook.Odometer = 11105;
saturnOutlook.MSRP = 44537.76;
saturnOutlook.IsElectric = false;
saturnOutlook.IsSold = false;

toyotaTundra.Make = "Toyota";
toyotaTundra.Model = "Tundra";
toyotaTundra.Year = 2001;
toyotaTundra.Odometer = 25896;
toyotaTundra.MSRP = 27162.34;
toyotaTundra.IsElectric = false;
toyotaTundra.IsSold = true;

mazdaMazda3.Make = "Mazda";
mazdaMazda3.Model = "Mazda3";
mazdaMazda3.Year = 2009;
mazdaMazda3.Odometer = 23260;
mazdaMazda3.MSRP = 41619.14;
mazdaMazda3.IsElectric = false;
mazdaMazda3.IsSold = false;

fordFocus.Make = "Ford";
fordFocus.Model = "Focus";
fordFocus.Year = 2000;
fordFocus.Odometer = 22153;
fordFocus.MSRP = 17745.71;
fordFocus.IsElectric = false;
fordFocus.IsSold = true;

landRoverRangeRover.Make = "Land Rover";
landRoverRangeRover.Model = "Range Rover";
landRoverRangeRover.Year = 1995;
landRoverRangeRover.Odometer = 5881;
landRoverRangeRover.MSRP = 50069.07;
landRoverRangeRover.IsElectric = false;
landRoverRangeRover.IsSold = false;

lincolnMks.Make = "Lincoln";
lincolnMks.Model = "MKS";
lincolnMks.Year = 2013;
lincolnMks.Odometer = 24597;
lincolnMks.MSRP = 26963.01;
lincolnMks.IsElectric = false;
lincolnMks.IsSold = true;

pontiacGrandAm.Make = "Pontiac";
pontiacGrandAm.Model = "Grand Am";
pontiacGrandAm.Year = 2005;
pontiacGrandAm.Odometer = 19359;
pontiacGrandAm.MSRP = 39276.89;
pontiacGrandAm.IsElectric = false;
pontiacGrandAm.IsSold = false;

lexusIsf.Make = "Lexus";
lexusIsf.Model = "IS-F";
lexusIsf.Year = 2001;
lexusIsf.Odometer = 22161;
lexusIsf.MSRP = 33366.88;
lexusIsf.IsElectric = false;
lexusIsf.IsSold = true;

mercedesSClass.Make = "Mercedes-Benz";
mercedesSClass.Model = "S-Class";
mercedesSClass.Year = 1990;
mercedesSClass.Odometer = 4667;
mercedesSClass.MSRP = 49578.59;
mercedesSClass.IsElectric = false;
mercedesSClass.IsSold = false;

audi5000S.Make = "Audi";
audi5000S.Model = "5000S";
audi5000S.Year = 1988;
audi5000S.Odometer = 24072;
audi5000S.MSRP = 20006.96;
audi5000S.IsElectric = false;
audi5000S.IsSold = true;

subaruBrat.Make = "Subaru";
subaruBrat.Model = "Brat";
subaruBrat.Year = 1988;
subaruBrat.Odometer = 24298;
subaruBrat.MSRP = 35821.30;
subaruBrat.IsElectric = false;
subaruBrat.IsSold = false;

cadillacCatera.Make = "Cadillac";
cadillacCatera.Model = "Catera";
cadillacCatera.Year = 2001;
cadillacCatera.Odometer = 25038;
cadillacCatera.MSRP = 22391.86;
cadillacCatera.IsElectric = false;
cadillacCatera.IsSold = true;

fiat500.Make = "FIAT";
fiat500.Model = "500";
fiat500.Year = 2012;
fiat500.Odometer = 29529;
fiat500.MSRP = 21087.56;
fiat500.IsElectric = false;
fiat500.IsSold = false;

nissan370Z.Make = "Nissan";
nissan370Z.Model = "370Z";
nissan370Z.Year = 2010;
nissan370Z.Odometer = 17024;
nissan370Z.MSRP = 12365.61;
nissan370Z.IsElectric = false;
nissan370Z.IsSold = true;

nissan200SX.Make = "Nissan";
nissan200SX.Model = "200SX";
nissan200SX.Year = 1997;
nissan200SX.Odometer = 21711;
nissan200SX.MSRP = 12477.29;
nissan200SX.IsElectric = false;
nissan200SX.IsSold = false;

teslaModelS.Make = "Tesla";
teslaModelS.Model = "Model S Plaid";
teslaModelS.Year = 2021;
teslaModelS.Odometer = 1997;
teslaModelS.MSRP = 79995.00;
teslaModelS.IsElectric = true;
teslaModelS.IsSold = true;

teslamodelX.Make = "Tesla";
teslamodelX.Model = "Model X";
teslamodelX.Year = 2020;
teslamodelX.Odometer = 21711;
teslamodelX.MSRP = 48995.00;
teslamodelX.IsElectric = true;
teslamodelX.IsSold = false;

mitsubishiEvo.Make = "Mitsubishi";
mitsubishiEvo.Model = "Evo";
mitsubishiEvo.Year = 2005;
mitsubishiEvo.Odometer = 15960;
mitsubishiEvo.MSRP = 49999.00;
mitsubishiEvo.IsElectric = false;
mitsubishiEvo.IsSold = true;


//*Dealership-> class
//    private variable of Cars which is a collection of Car

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

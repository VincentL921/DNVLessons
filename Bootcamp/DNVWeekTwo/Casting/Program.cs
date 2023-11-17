

//Research topic for weekend: Boxing & Un-boxing C#
//force converting one type to another type




//bad cast
using Casting;

var badAge = "12";
try
{
    var badAgeConvert = int.Parse(badAge);
}
catch(FormatException fex)
{
    Console.WriteLine("Error: Format Converting");
}

var didBadAgeParse = int.TryParse(badAge, out int goodAge);
if(didBadAgeParse == true)
{
    Console.WriteLine($"Our age is: {goodAge}");
}
else
{
    Console.WriteLine("Parsing Failed");
}


//DateTime Casting
var goodDateAsString = "11/16/2023";
var goodDate =  DateTime.Parse(goodDateAsString);
Console.WriteLine(goodDate);

var badDateAsString = "1 23";
var didBadDateParse = DateTime.TryParse(badDateAsString, out DateTime parsedGoodDate);
if(didBadDateParse == true)
{
    Console.WriteLine($"Today's date and time is: {parsedGoodDate}");
}
else
{
    Console.WriteLine("Parsing failed");
}


//boxing/unboxing casting example
var fiatAbarth = new Fiat();
var camry = new Toyota();

fiatAbarth.Make = "Fiat";
fiatAbarth.Model = "500 Abarth";
fiatAbarth.Year = 2017;
fiatAbarth.IsCoupe = true;

camry.Make = "Toyota";
camry.Model = "Camry";
camry.Year = 2023;
camry.IsCoupe = false;
camry.IsTRD = true;

List <Car> cars = new List<Car>();

cars.Add(fiatAbarth);
cars.Add(camry);

foreach (var item in cars)
{
    Console.WriteLine(item);

    switch (item.Make)
    {
        case "Toyota" :
            var toyota = (Toyota)item;
            Console.WriteLine($"Year: {item.Year}, Make: {item.Make}, Model: {camry.Model} Is TRD: {item.IsCoupe}");
            break;
        case "Fiat" :
            var fiat = (Fiat)item;
            break;
    }

}

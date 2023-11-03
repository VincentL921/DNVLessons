var name = "Vincent";
var nameToUpper = name.ToUpper();
var nameToLower = name.ToLower();
var nameWithSpaces = "   Vincent   ";
var trimmedName = nameWithSpaces.Trim();
var nameWithComma = "Vincent,/+=";
var cleanName = nameWithComma.Replace(",", "").Replace("/", "").Replace("+=", "");


var nameCSV = "David, Vincent Lentini, John Williams, Bill, Jim, Justin Lentini";
string[] names = nameCSV.Split(",");
//var nameCSVAsArray = new string[] { "David", "Vincent", "Bill" };

var acceptedNames = new List<string>();
var theLentinis = new List<string>();
var theJs = new List<string>();

foreach (string item in names)
{
    var cleanItem = item.Replace(" ", "");
    var trimmedItem = item.TrimStart().ToLower();
    Console.WriteLine(trimmedItem);

    if (trimmedItem.Contains("vi"))
    {
        acceptedNames.Add(item);
    }

    if (trimmedItem.EndsWith("lentini"))
    {
        theLentinis.Add(item);
    }

    if (trimmedItem.StartsWith("j"))
    {
        theJs.Add(item);
    }
}

var dollars = 101;
var paddedDollars = dollars.ToString().PadLeft(6, '0');
Console.WriteLine(paddedDollars);

var destination = "The London Bridge";
var destSubString = destination.Substring(4);
Console.WriteLine(destSubString);

var destLondon = destination.Substring(4, 6);
Console.WriteLine(destLondon);

//For Thursday:
//Tell Dave the different types of loops in C# (hint: there should be 4)
//Also tell him the differences between the loops. And specifically, how it goes about executing the code (how it goes about deciding when to execute the code within the loop).

//Tell dave in the concept of object oriented programing - tell him what abstraction, encapsulation & polymorphism mean.
//If you can tell him the differences between abstraction & encapsulation.

//For code:
//*strings in chat*
//parse the CSV strings into an array.
//Within that array, when you loop over it, take all names that start with "Ch", put it into a list
//""""" take all names that end with "G", put into another list
//""""" tak all names that end with "ass", put into another list

//There's a name in the string named "Eagle"
//From that string, use substring to pull out his first name & last name
//Display first name & last name of this guy.

//As looping through all this data, clean it up as necessary.

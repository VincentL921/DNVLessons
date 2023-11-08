var hwCSVNames = "Easter Quade,Artemis Gon,  Hanan Shave,  Katerina Cowap,Reeba Base,Matias Adamoli  ,   Ashlan+Arnau,Jori!Allum,Cal Major,   Desiri@#Land,#$Charmine Gilbride,Kimbra McGilben,   Roldan Rustich,Lorrie Buttel,Cello Brookz,Sylvester Fellon   ,Becky Shoebottom,  Chic Ruzic,  Sterling Eastop,   Jacklyn Pryce,Zoe Yong,Michaelina Kullmann,    Deloris Hindrich,Myrle Shearn,)(*   Zulema Laverack,Cherise Fergie,   Marena Lazenby,Iseabal Ainge,  Nahum Herley,Tammie Batty,   Theda Finnemore,Brian Deering,   Arv Kesby,   Gamaliel Patters,  {}  Waly Eagle,Max Rawlison,Gayelord Gantzer    ,Worth Raywood,Burgess Cattemull, []\\!!! Sile Pirson,Fifine Pedro,   Giralda Canning,Aeriel Bleackly,   Quincy Huggard,    Arman Rotchell,Horst Hiddersley,    Jennilee Lowmass,Karissa Bastone,Erica Sloper,Roda Verrick,  Malena Stollsteimer,Gayel Deave,   Blancha Birney";
string[] namesSplit = hwCSVNames.Split(",");

var startsWithCh = new List<string>();
var endsWithG = new List<string>();
var endsWithAss = new List<string>();
var nameWithEagle = new List<string>();

foreach (var item in namesSplit)
{
    var cleanIteam = item.Trim().Replace("+", "").Replace("!", "")
        .Replace("@#", "").Replace("#$", "")
        .Replace(")(*", "").Replace("{}", "")
        .Replace("[]", "").Replace(@"\", "")
        .Replace(@"!!!  ", "").Replace("   ", "")
        .Replace("  ", "").Trim();
    Console.WriteLine(cleanIteam);

    if (cleanIteam.StartsWith("Ch"))
    {
        startsWithCh.Add(item);
        Console.WriteLine(cleanIteam);
    }

    if (cleanIteam.EndsWith("g"))
    {
        endsWithG.Add(item);
        Console.WriteLine(cleanIteam);
    }

    if (cleanIteam.EndsWith("ass"))
    {
        endsWithAss.Add(item);
        Console.WriteLine(cleanIteam);
    }

    if (cleanIteam.Contains("Eagle"))
    {
        nameWithEagle.Add(item);
        Console.WriteLine(cleanIteam);
    }
}

Console.WriteLine("");
Console.WriteLine($"Names that start with CH: {startsWithCh.Count}");
Console.WriteLine($"Names that end with g: {endsWithG.Count}");
Console.WriteLine($"Names that end with ass: {endsWithAss.Count}");



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

using System.Text;

string name = "Aaron";

//long myNetWorth = 10008938475893485;

//var charhcar ="c";

string petFish ="puffer fish";


//concatination
petFish ="porcupine" + petFish;
Console.WriteLine(petFish);

//Template Literal

Console.WriteLine($"I am buying {petFish}. YOU CANNOT STOP ME !! ");


//READ
//CONSOLE.WRITELINE
//UPDATE

string newPetfish = petFish.Replace("porcupine","blue dot");

Console.WriteLine(newPetfish);

Console.WriteLine(name);

//DELETE
//String Builder
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crab");
Console.WriteLine(newCrustacean);
newCrustacean.Remove(0, 8);
Console.WriteLine(newCrustacean);


//ARRAYS
//ARRAY CRUD
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"];

//Read array
foreach(var rat in favoriteRats)
{
    Console.WriteLine(rat);
}
Console.WriteLine(favoriteRats);


//UPDATE
favoriteRats[0] = "Fancy Rat";


var newFavouritesRats = favoriteRats.Where((e)=>e.StartsWith("b"));

foreach (var rats in newFavouritesRats)
{
    Console.WriteLine(rats);
}

//if-else

if(isLoggedIn){
    Console.WriteLine("that is how if work");
}
else if(isAdmin)
{
    Console.WriteLine("This is just a dummy code");
}


//Operators
var fishPrice = 1000;

if(fishTankPrice <=1000)
{
    Console.WriteLine("Buy tank");
}

//syntax for enum

enum Warning{
    CodeRed,//0
    CodeBlue,//1
    CodeGreen//2
}

Console.WriteLine(Warning.CodeBlue);


//switch case
var preHistoricFish = "Cockerelitte";

switch(preHistoricFish)
{
    case "Hellionatis":
    Console.WriteLine("heliobatis!");
    break;

    case "Cockerelitte":
    Console.WriteLine("Cockerelitte!");
    break;
    default:
    Console.WriteLine("Nothing matches!");
    break;
}

//switch expression

var historicalFish = "Cockerelitte";

var result = historicalFish switch
{
    "hellobatis" => "Hellobatis!",
    "Cockerelitte" => "Cockerelitte",
    _ => "No Match!"
};

Console.WriteLine("This is a " +result);


//loops

//Pinger
using System.Net.NetworkingInformation

Ping p1 = new Ping();
PingReply PR = p1.Send("8.8.8.8");

while(PR.status.ToString()== "Success")
{
    Console.WriteLine(PR.Status.ToString() 
    + "|");
    PR = p1.Send("8.8.8.8");
    Console.WriteLine(Waiting ten seconds for next request);
    Thread.Sleep(10000);

}

//CRUD

Rat wolfRat = new Rat();

wolfRat.Name = "Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioactive = false;

//READ

Console.WriteLine(wolfRat.Name);


//Update

wolfRat.Name = "WOLF RAT";

Console.WriteLine(wolfRat.Name);

//Delete
wolfRat.Name = "";

Console.WriteLine(wolfRat.Name);

//TUPPLE

RealEstate elmStreet = new()
{
    Address = "Elm Street",
    SquareFootage = 1300,
    Price = 30000
};

Console.WriteLine(elmStreet.CalculatePricePerSquareFoot());

var values = ("t", 2, "p");

Console.WriteLine(values.Item1);
Console.WriteLine(values.Item2);
Console.WriteLine(values.Item3);


var valuesWithName = (First: "t", Second:2, Third:"p");

Console.WriteLine(valuesWithName.First);

(int a, string b, bool c) ReturnTheseValues()
{
    return (9, "u",true);
}

var tupleReturnValue = ReturnTheseValues();
Console.WriteLine(tupleReturnValue.0);


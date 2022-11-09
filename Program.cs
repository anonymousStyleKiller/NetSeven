// See https://aka.ms/new-console-template for more information
using LINQNetSeven;



List<int> ages = new(){1,15,6,44,25};

var sorted = ages.Order();
var descending = ages.OrderDescending();

foreach(var age in sorted) Console.WriteLine(age);
Console.WriteLine(new string('-', 50));
foreach(var i in descending) Console.WriteLine(i);
Console.WriteLine(new string('-', 50));



List<PersonModel> peoples = new()
{
  new(){Name = "Anton", Age = 25},
  new (){Name = "Sasha", Age = 23},
  new (){Name = "YURII", Age = 77}
};


var orderedPeople = peoples.Order();
var desc = peoples.OrderDescending();

foreach(var x in orderedPeople) Console.WriteLine($"Name {x.Name} -  Age {x.Age}");
Console.WriteLine(new string('-', 50));
foreach(var x in desc) Console.WriteLine($"Name {x.Name} -  Age {x.Age}");
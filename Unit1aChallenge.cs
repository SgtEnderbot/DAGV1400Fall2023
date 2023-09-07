using System;

int dwarfAge = 62;
int heroAge = 25;
string dwarfName = "Bob Big-Beard";
string heroName = "Jeff";
bool bobIsBetter = true;

Console.WriteLine(heroName);
Console.WriteLine(heroAge);
Console.WriteLine(dwarfName);
Console.WriteLine(dwarfAge);
Console.WriteLine("Is " + dwarfName + " better?\n" + bobIsBetter);

int x = dwarfAge + heroAge;
int y = dwarfAge - heroAge;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine("Enter your name: ");
string userName = Console.ReadLine();

Console.WriteLine(userName + ", " + dwarfName + ", and " + heroName + " are great friends");

Console.WriteLine("Enter your best friend's name:");
string bestieName = Console.ReadLine();

Console.WriteLine(userName + " and " + bestieName + " are best friends");

//I wrote a story for fun. :)

Console.WriteLine("\nStory time!");

Console.WriteLine("\nOur hero named " + heroName + " once met a strange dwarf named " + dwarfName);
Console.WriteLine(heroName + " was young, and was only " + heroAge + " years old ");
Console.WriteLine(dwarfName + ", however, was " + dwarfAge + " years old");
Console.WriteLine(heroName + " asked if " + dwarfName + " thought his name was the best ");
Console.WriteLine(dwarfName + " said that this is " + bobIsBetter + " and his name is the best");
Console.WriteLine("But even if the two don't always get along, at least they're still friends with both " + userName + " and " + bestieName);

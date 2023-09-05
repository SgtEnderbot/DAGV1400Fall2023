using System;

//A list of variables used in the WriteLine and operations.
int smallNum = 5;
int bigNum = 100;
string playerName = "Bob";
string npcName = "Todd";
//A few operations printed in the WriteLines.
int x = smallNum + bigNum;
int y = bigNum / smallNum;

Console.WriteLine(playerName + " asks " + npcName + " what his favorite numbers are.");
Console.WriteLine(x);
Console.WriteLine(y);
//A WriteLine that includes an operation of the two above operations combined.
Console.WriteLine(x + y);

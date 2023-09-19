// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");


//Create a dictionary that takes an int as the key and a string as the value, call it topGames.
Dictionary<int, string> topGames = new Dictionary<int, string>()
{
    {1, "Minecraft" },
    {2, "Terreria" },
    {3, "Tears of the Kingdom" },
    {4, "Ocorania of Time" },
    {5, "Majoras Mask" },
    {6, "Link to the Past" },
    {7, "Breath of the Wild" },
    {8, "Destiny 2" },
    {9, "Learn 2 Fly" },
    {10, "Lava Floor" }
};

//Add your top ten favorite games to the dictionary, with the key being their placement (1 is your favorite).

//Loop through the topGames dictionary and print out each Key/Value pair on a new line("Key: <Key>, Value: <Value>").
foreach (var game in topGames)
{
    Console.WriteLine($"Key: {game.Key}, Value: {game.Value}");
}
//Then check if topGames contains key 1, if it does, print to console "My favorite game is: <topGames[1]>".
if (topGames.ContainsKey(1))
{
    Console.WriteLine($"My favorite game is: {topGames[1]}");
}
//Create an empty string called result.
string result;
//Implement the TryGetValue method on topGames for key 11, set output to result string.
topGames.TryGetValue(11, out result);
//If it outputs something to result then print the result to console, else print, "There is no game in the eleventh position."
if(result != null)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("There is nothing in the key value 11");
}
//Switch the dictionary entry object at key 5 with a new game title you also enjoy; be sure to check if topGames contains the key 5.
topGames[5] = "HAHAHA"
    ;//Print the new value at key 5.
Console.WriteLine(topGames[5]);
//Create a new Hashtable and set it equal to topGames.
Hashtable sstupid = new Hashtable(topGames);
//Create a string called favGame.
string favGame;
//Set favGame to the value of key 1 in the hashtable you just created.
favGame = (string)sstupid[1];
//Print favGame to console.
Console.WriteLine(favGame);
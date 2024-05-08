
using System.ComponentModel.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Markup;

//**NOTE- I started working on this in another program window which ended up really convoluted and messy with code pointing everywhere
//so I opened an empty solution and pasted in one little section at a time to test and fix so that I could think more clearly
//still kind of a work in progress :/

//main code

Dictionary<string, decimal> store = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
store.Add("Soft Pretzel",4.99m);
store.Add("Crackers", 3.75m);
store.Add("Cheese Cubes", 3.25m);
store.Add("Pineapple Cup", 2.25m);
store.Add("Granola Bar", 1.99m);
store.Add("Chocolate Bar", 1.99m);
store.Add("Nachos", 4.99m);
store.Add("Chewing Gum", 0.75m);

global::System.Console.WriteLine("Hello, Welcome to Clare's Snack Store!\n");
Console.WriteLine("These options are available for sale:");
//Display store items here
foreach (KeyValuePair<string, decimal> kvp in store)
{
    Console.WriteLine(kvp);
    Console.WriteLine($"{kvp.Key, -15}${kvp.Value}");
    
}


List<string> shoppinglist = new List<string>();

bool runProgram = true;
//while loop for choosing an item


while (runProgram)
{



Console.WriteLine("\nPlease choose an item to purchase:");

string userInput = Console.ReadLine().ToLower().Trim();


if(IsIteminShop(store, userInput))
{
    Console.WriteLine("Added this item to your shopping list");
    shoppinglist.Add(userInput);
    //need to put code here to input the users item into shopping list
}
    else 
    {
        Console.WriteLine("That item is not in the store");
        continue; 
    }
    


while (true)
{
    Console.WriteLine("\nWould you like to choose another? y/n");
    string choice = Console.ReadLine().ToLower().Trim();
    if (choice == "y")
    {
        break;
    }
    else if (choice == "n")
    {
        runProgram = false;
        break;
    }
    else
    {
        Console.WriteLine("that answer is invalid, please type y or n only");
    }
}
}
decimal Shoppingtotal = 0;
Console.WriteLine("This is the list of items you have selected.\n");
//displays shopping list and total of amount 
foreach (string s in shoppinglist)
{
    Console.WriteLine($"{s,-15}${store[s]}");
    Shoppingtotal += store[s];

}

Console.WriteLine($"Your total amount for these items is {Shoppingtotal}.");
Console.WriteLine("Thank you for shopping at Clare's Snack Store!");


//methods
static bool IsIteminShop(Dictionary<string, decimal> store, string userInput)
{
    if (store.ContainsKey(userInput))
    {
        return true;
    }
    else
    {
        return false;
    }
}

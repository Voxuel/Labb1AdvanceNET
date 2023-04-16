// See https://aka.ms/new-console-template for more information

using Labb1AdvanceNET.Controllers;
using Labb1AdvanceNET.Models;

App();

static void App()
{
    BoxCollection boxCollection = new BoxCollection();
    
    boxCollection.Add(new Box(10,10,10));
    boxCollection.Add(new Box(10,10,10));
    boxCollection.Add(new Box(13,15,95));
    boxCollection.Add(new Box(13,17,33));
    boxCollection.Add(new Box(10,15,20));
    boxCollection.Add(new Box(20,15,10));
    
    PrintCollection(boxCollection);
    Console.ReadLine();
}

static void PrintCollection(BoxCollection boxes)
{
    foreach (var box in boxes)
    {
        Console.WriteLine($"The box has dimensions: H{box.Height} L{box.Length} W{box.Width}");
    }

    boxes.Remove(new Box(10, 10, 10));

    Console.WriteLine("--------After Remove---------");
    foreach (var box in boxes)
    {
        Console.WriteLine($"The box has dimensions: H{box.Height} L{box.Length} W{box.Width}");
    }

    Console.WriteLine("-------Contains------");

    var result = boxes.Contains(new Box(20, 55, 10)) ? $"The box exists in the collection" :
        "There is no box with those measures";

    Console.WriteLine(result);
}
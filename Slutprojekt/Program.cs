
System.Console.WriteLine("Welcome to the colosseum");
System.Console.WriteLine("You have been summoned to participate in the yearly fighting tournament");
System.Console.WriteLine("State your name peaseant");
String player = Console.ReadLine();
while(true)
    if (player != "")
    {
        break;
    }
    else if (player == "")
    {
        System.Console.WriteLine("YOUR KING DEMANDS YOU TO STATE YOUR NAME!");
        player = Console.ReadLine();
    }
System.Console.WriteLine("Well then peaseant prepare for battle ");


Console.ReadLine();
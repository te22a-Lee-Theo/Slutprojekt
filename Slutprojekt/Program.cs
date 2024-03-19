Player player = new Player();
Enemy enemy = new Enemy();

String Choise = "";
int Action = int.Parse(Choise);

System.Console.WriteLine("Welcome to the colosseum");
System.Console.WriteLine("You have been summoned to participate in the yearly fighting tournament");
System.Console.WriteLine("State your name peaseant");
String playername = Console.ReadLine();
while(true)
{
    if (playername != "")
    {
        break;
    }
    else if (playername == "")
    {
        System.Console.WriteLine("YOUR KING DEMANDS YOU TO STATE YOUR NAME!");
        playername = Console.ReadLine();
    }
}
System.Console.WriteLine("Well then peaseant prepare for battle.");
System.Console.WriteLine("You have been placed against the weakest in this colosseum and you only way to freedom is to fight for it.");


while(player.hp >= 0 || enemy.hp >= 0)
{
    System.Console.WriteLine("Challenger make your move.");
    System.Console.WriteLine("1. Attack");
    System.Console.WriteLine("2. block");
    Choise = Console.ReadLine();

    if (Action == 1)
    {
        player.Attack(enemy);
    }
}

Console.ReadLine();
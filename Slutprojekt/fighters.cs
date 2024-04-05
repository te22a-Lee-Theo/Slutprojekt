using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;

public class Player
{
    public string Name;
    public int hp = 50;

    public int BaseDmg = 10;

    public void Attack(Enemy enemy)
    {
        int Dmg = new Random().Next(BaseDmg/2,BaseDmg);
        enemy.hp -= Dmg;
        System.Console.WriteLine($"{Name} deals {Dmg} damage to the opponent.");

        enemy.hp = Math.Max(0, enemy.hp);
    }

    public void Block(Player player, Enemy enemy)
    {
        int DmgRed = enemy.BaseDmg/2;
        System.Console.WriteLine($"{Name} chooses to block and reduces to incomming damage");
        int qwert = enemy.Move();
        if ( qwert == 1)
        {
            player.hp -= DmgRed;
        }
        else
        {
            System.Console.WriteLine("Both chose to stand down and no attack was made");
        }
    }

    public string GetName(Player player)
    {
        string Name = Console.ReadLine();
        while (string.IsNullOrEmpty(Name))   //Lånad från internet
        {
            System.Console.WriteLine("YOUR KING DEMANDS YOU TO STATE YOUR NAME!");
            Name = Console.ReadLine();
        }
        return Name;
    }
}

public class Enemy
{
    public int hp = 30;
    public int BaseDmg = 5;

    public void Attack(Player player)
    {
        int Dmg = BaseDmg;
        player.hp -= Dmg;
        System.Console.WriteLine($"The enemy deals {Dmg} damage to the challenger");

        player.hp = Math.Max(0, player.hp);
    }

    public void Block (Player player)
    {
        int DmgDown = player.BaseDmg/2;

        if ()
        System.Console.WriteLine($"The enemy blocks the attack but still suffers {DmgDown} Damage");

    }

    public int Move()
    {
        Random generator = new Random();
        int Rand = generator.Next(1,2);
        return Rand;
    }
}
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
        int DmgRed = enemy.BaseDmg2/2;
        System.Console.WriteLine($"{Name} chooses to block and reduces to incomming damage");
        player.hp -= enemy.BaseDmg2 -DmgRed;
    }

    public string GetName(Player player)
    {
        string Name = Console.ReadLine();
        while (string.IsNullOrEmpty(Name))
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
    public int BaseDmg2 = 5;

    public void Attack(Player player)
    {
        int Dmg = BaseDmg2;
        player.hp -= Dmg;
        System.Console.WriteLine($"The enemy deals {Dmg} damage to the challenger");

        player.hp = Math.Max(0, player.hp);
    }
}
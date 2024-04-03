public class Player
{
    public string name;
    public int hp = 50;

    public int BaseDmg = 10;

    public void Attack(Enemy enemy)
    {
        int Dmg = new Random().Next(BaseDmg/2,BaseDmg);
        enemy.hp -= Dmg;
        System.Console.WriteLine($"{name} deals {Dmg} damage to the opponent.");
    }

    public void Block(Player player, Enemy enemy)
    {
        int DmgRed = enemy.BaseDmg2/2;
        System.Console.WriteLine($"{name} chooses to block and reduces to incomming damage");
        player.hp -= DmgRed;
    }

    public string GetName(Player player)
    {
        string name = player.name;
        while (string.IsNullOrEmpty(name))
        {
            System.Console.WriteLine("YOUR KING DEMANDS YOU TO STATE YOUR NAME!");
            name = Console.ReadLine();
        }
        return name;
    }
}

public class Enemy
{
    public int hp = 30;
    public int BaseDmg2 = 5;
}
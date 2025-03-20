using System;

public abstract class Fighter
{
    public string Name { get; }
    public int Health { get; set; }

    public int AttackStrength { get; }

    public Fighter(string name, int health, int attackStrength)
    {
        Name = name;
        Health = health;
        AttackStrength = attackStrength;

    }


    public abstract int Attack();

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Health = 0;
            Console.WriteLine($"{Name} has died! 5B EXP Added");
        }
        else
        {
            Console.WriteLine($"{Name} took {damage} hits and only has {Health} life left! ");
        }
    }

    public bool LifeCheck => Health > 0;
}

public class Viking : Fighter
{
    public Viking(string name) :
   base(name, 100, 15)
    { }

    public override int Attack()
    {
        return AttackStrength;
    }
}

public class Caveman : Fighter
{
    public Caveman(string name) :
   base(name, 120, 12)
    { }

    public override int Attack()
    {
        return AttackStrength;
    }
}

public class BattleArena
{
    public Fighter Fight(Fighter player1, Fighter player2)
    {
        Console.WriteLine($"THE BATTLE HAS BEGUN: {player1} VS {player2} ");

        while (player1.LifeCheck && player2.LifeCheck)
        {

            int damage = player1.Attack();
            player2.TakeDamage(damage);
            Console.WriteLine($"{player1.Name} SWINGS! dealing {damage} damage. {player2.Name} Health: {player2.Health}");

            if (!player2.LifeCheck)
                break;

            damage = player2.Attack();
            player1.TakeDamage(damage);
            Console.WriteLine($"{player2.Name} throws an uppercut and deals {damage} damage. {player1.Name} Health: {player1.Health}");
        }
        Fighter winner = player1.LifeCheck ? player1 : player2;
        Console.WriteLine($"THE WINNER ISSSSS.....\n {winner.Name}!");
        return winner;



    }
}

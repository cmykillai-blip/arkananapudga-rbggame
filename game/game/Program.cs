using System.Diagnostics.Contracts;

namespace RPG_game

{
   public class Troll : Enemy
    {
        public Troll() : base(40, 10, "Троль", 50)
        {
        }
        public override void Attack(Character target)
        {
            var damage = Strength;
            Console.WriteLine($"{Name} swings a club at {target.Name}, dealing {damage} damage!");
        }
    }
    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Hello, World!");

        }

    }

}


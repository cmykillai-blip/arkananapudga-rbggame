namespace RPG_game

{
    public class Weapon : Item, IEquippable
    {
        public int Damage { get; protected set; }
        public Weapon(string name, string description, int damage) : base(name, description)
        {
            Damage = damage;
        }

        public void Equip(Player player)
        {
            Console.WriteLine($"{player.Name} has equipped {Name}.");
            
        }

        public void Unequip(Player player)
        {
            Console.WriteLine($"{player.Name} has unequipped {Name}.");
            
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} swings the {Name}, dealing {Damage} damage.");
            Equip(player);
        }
    }

}


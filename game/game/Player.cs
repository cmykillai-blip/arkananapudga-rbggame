namespace RPG_game

{
    public class Player : Character, ISpellCaster
    {
        private int _mana;
        private int _maxMana;
        private int _experience;
        private int _level;
        private IEquippable  _equipableWeapon;
        private List<Item> _inventory;

        public int Mana
        {
            get => _mana;
            private set => _mana = Math.Max(0, Math.Min(value, _maxMana));
        }

        public int MaxMana
        {
            get => _maxMana;
            private set => _maxMana = value;    
        }
        public int Experience
       {
            get => _experience;
            private set => _experience = value;
        }
           public int Level
        {
            get => _level;
            private set => _level = value;
        }


        public IReadOnlyCollection<Item> Inventory => _inventory.AsReadOnly();
        public Player(string name) : base(100, 10, name)
        {
            _maxMana = 50;
            _mana = _maxMana;
            _level = 1;
            _experience = 0;
            _inventory = new List<Item>();
        }
public override void Attack(Character target)
        {
            var rand = new Random();
            var baseDamage = Strength;

            if (_equipableWeapon != null && _equipableWeapon is Weapon weapon)
            {
                baseDamage += weapon.Damage;
            }

            var isCritical = rand.Next(100) < 20;
            var damage = isCritical ? baseDamage * 2 : baseDamage;

            if (isCritical)
            {
                Console.WriteLine($"{Name} lands a critical hit on {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage.");
            }
            target.TakeDamage(damage);
        }
            



public void CastSpell(Character target)
        {
            throw new NotImplementedException();
        }

        public void RestoreMana(int amount)
        {
            throw new NotImplementedException();
        }
    }

}


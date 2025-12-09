namespace RPG_game

{
    public abstract class Enemy : Character
    {
        private int _experienceReward;
        private List<Item> _loot;
        public int ExperienceReward
        {
            get => _experienceReward;
            protected set => _experienceReward = value;
        }
        protected Enemy(int health, int strength, string name, int experienceReward) : base(health, strength, name)
        {
            ExperienceReward = experienceReward;
            _loot = new List<Item>();
        }

        protected void AddLoot(Item item)
        {
            _loot.Add(item);
        }
        public List<Item> GetLoot()
        {
            return new List<Item>(_loot);
        }
    }

}


namespace RPG_game

{
    public interface ISpellCaster
    {
        int Mana { get; }
        void CastSpell(Character target);
        void RestoreMana(int amount);
    }

}


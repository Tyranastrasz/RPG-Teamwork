namespace RpgGame.Enemies.RangeType
{
    public class Goblin : Range
    {
        public const int GoblinExperience = 50;

        public Goblin(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, GoblinExperience)
        {
        }
    }
}

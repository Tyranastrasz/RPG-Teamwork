namespace RpgGame.Enemies.RangeType
{
    public class Drake : Range
    {
        public const int DrakeExperience = 50;

        public Drake(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, DrakeExperience)
        {
        }
    }
}

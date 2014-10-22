namespace RpgGame.Enemies.RangeType
{
    public class Shade : Range
    {
        public const int ShadeExperience = 50;

        public Shade(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, ShadeExperience)
        {
        }
    }
}

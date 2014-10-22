namespace RpgGame.Enemies.MeleeType
{
    public class Ork : Melee
    {
        public const int OrkExperience = 50;

        public Ork(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, OrkExperience)
        {
        }
    }
}

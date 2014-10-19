namespace RpgGame.Enemies
{
    public abstract class Melee : Enemy
    {
        protected Melee(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture)
        {
        }
    }
}

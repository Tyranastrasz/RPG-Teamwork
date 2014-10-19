namespace RpgGame.Enemies
{
    public abstract class Melee : Enemy
    {
        protected Melee(string name, int hitPoints, int attackPoints, int defensePoints)
            : base(name, hitPoints, defensePoints, attackPoints)
        {
        }
    }
}

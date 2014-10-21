namespace RpgGame.Enemies
{
    public abstract class Melee : Enemy
    {
        protected Melee(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture, int experience)
            : base(name, hitPoints, defensePoints, attackPoints, picture, experience)
        {
        }
    }
}

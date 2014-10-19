namespace RpgGame.Enemies
{
    public abstract class Range : Enemy
    {
        protected Range(string name, int hitPoints, int attackPoints, int defensePoints)
            : base(name, hitPoints, defensePoints, attackPoints)
        {

        }
    }
}

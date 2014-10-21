namespace RpgGame.Enemies
{
    public abstract class Range : Enemy
    {
        protected Range(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture, int experience)
            : base(name, hitPoints, defensePoints, attackPoints, picture, experience)
        {

        }
    }
}

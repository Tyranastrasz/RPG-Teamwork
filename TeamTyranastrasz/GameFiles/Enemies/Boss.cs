namespace RpgGame.Enemies
{
    public abstract class Boss : Enemy
    {
        protected Boss(string name, int hitPoints, int attackPoints, int defensePoints)
            : base(name, hitPoints, defensePoints, attackPoints)
        {
        }
    }
}

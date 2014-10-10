namespace RpgGame.Enemies
{
    using RpgGame.Interfaces;
    using System;

    public abstract class Enemy : Unit, IAttack
    {
        protected Enemy(string name) : base(name) // ??? enemies should't have names, just classes
        {
        }
        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}

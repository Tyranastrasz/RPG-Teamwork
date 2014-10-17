namespace RpgGame.Enemies
{
    using RpgGame.Interfaces;
    using System;

    public abstract class Enemy : Unit, IAttack, IEnemy
    {
        protected Enemy(string name) : base(name) // ??? enemies should't have names, just classes
        {
        }

        public virtual void Attack()
        {
            throw new NotImplementedException();
        }

        public abstract int HitPoints { get; set; }

        public abstract int DefensePoints { get; set; }

        public abstract int AttackPoints { get; set; }
    }
}

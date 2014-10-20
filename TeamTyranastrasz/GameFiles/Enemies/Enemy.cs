namespace RpgGame.Enemies
{
    using System;
    using RpgGame.Interfaces;

    public abstract class Enemy : Unit, IAttack, IEnemy
    {
        // changed for draw tets
        protected Enemy(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name) // ??? enemies should't have names, just classes
        {
            this.HitPoints = hitPoints;
            this.DefensePoints = defensePoints;
            this.AttackPoints = attackPoints;
            this.Picture = picture;
        }

        public virtual int Attack()
        {
            throw new NotImplementedException();
        }

        public int HitPoints { get; set; }

        public int DefensePoints { get; set; }

        public int AttackPoints { get; set; }

        public Pictures Picture { get; set; }
    }
}

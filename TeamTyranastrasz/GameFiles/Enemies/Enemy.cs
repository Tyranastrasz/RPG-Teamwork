﻿namespace RpgGame.Enemies
{
    using RpgGame.Interfaces;
    using System;

    public abstract class Enemy : Unit, IAttack, IEnemy
    {
        // changed for draw tets
        protected Enemy(string name, int hitPoints, int attackPoints, int defensePoints)
            : base(name) // ??? enemies should't have names, just classes
        {
            this.HitPoints = hitPoints;
            this.DefensePoints = defensePoints;
            this.AttackPoints = attackPoints;
        }

        public virtual void Attack()
        {
            throw new NotImplementedException();
        }

        public int HitPoints { get; set; }

        public int DefensePoints { get; set; }

        public int AttackPoints { get; set; }
    }
}

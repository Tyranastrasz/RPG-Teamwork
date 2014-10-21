﻿namespace RpgGame.Enemies
{
    using System;
    using RpgGame.Interfaces;
    using System.Windows.Forms;

    public abstract class Enemy : Unit, IUnit, IEnemy
    {
        // changed for draw tets
        protected Enemy(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture, int experience)
            : base(name) // ??? enemies should't have names, just classes
        {
            this.HitPoints = hitPoints;
            this.DefensePoints = defensePoints;
            this.AttackPoints = attackPoints;
            this.Picture = picture;
            this.PicBox = new PictureBox();
            this.IsAlive = true;
            this.CurrentHitPoints = this.HitPoints;
            this.Experience = experience;
        }

        public virtual int Attack()
        {
            return this.AttackPoints;
        }

        public virtual int Defend()
        {
            return this.DefensePoints;
        }

        public int HitPoints { get; set; }

        public int DefensePoints { get; set; }

        public int AttackPoints { get; set; }

        public bool IsAlive { get; set; }

        public int Experience { get; set; }

        public Pictures Picture { get; set; }

        public PictureBox PicBox { get; set; }
    }
}

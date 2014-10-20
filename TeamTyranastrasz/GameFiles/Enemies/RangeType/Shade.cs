﻿using System.Windows.Forms;

namespace RpgGame.Enemies.RangeType
{
    public class Shade : Range
    {
        public Shade(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}
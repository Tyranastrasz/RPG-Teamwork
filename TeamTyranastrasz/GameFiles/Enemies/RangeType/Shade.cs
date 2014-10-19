using System.Windows.Forms;

namespace RpgGame.Enemies.RangeType
{
    public class Shade : Range
    {
        public Shade(string name, int hitPoints, int attackPoints, int defensePoints)
            : base(name, hitPoints, defensePoints, attackPoints)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}

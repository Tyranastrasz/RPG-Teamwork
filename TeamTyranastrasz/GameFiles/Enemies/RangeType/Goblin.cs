using System.Windows.Forms;

namespace RpgGame.Enemies.RangeType
{
    public class Goblin : Range
    {
        public Goblin(string name, int hitPoints, int attackPoints, int defensePoints)
            : base(name, hitPoints, defensePoints, attackPoints)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}

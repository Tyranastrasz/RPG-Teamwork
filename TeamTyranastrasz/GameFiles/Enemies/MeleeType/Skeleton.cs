using System.Windows.Forms;

namespace RpgGame.Enemies.MeleeType
{
    public class Skeleton : Melee
    {
        public Skeleton(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}

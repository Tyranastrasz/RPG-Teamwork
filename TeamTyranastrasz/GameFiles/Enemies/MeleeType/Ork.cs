using System.Windows.Forms;

namespace RpgGame.Enemies.MeleeType
{
    public class Ork : Melee
    {
        public Ork(string name, int hitPoints, int attackPoints, int defensePoints)
            : base(name, hitPoints, defensePoints, attackPoints)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}

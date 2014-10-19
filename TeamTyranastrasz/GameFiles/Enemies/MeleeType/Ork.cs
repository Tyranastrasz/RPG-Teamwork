using System.Windows.Forms;

namespace RpgGame.Enemies.MeleeType
{
    public class Ork : Melee
    {
        public Ork(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
<<<<<<< HEAD
            : base(name, hitPoints, defensePoints, attackPoints, picture)
=======
            : base(name, hitPoints, defensePoints, attackPoints)
>>>>>>> fixing_bug
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}

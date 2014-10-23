using System.Windows.Forms;
namespace RpgGame.Enemies.MeleeType
{
    public class Golem : Melee
    {
        public const int GolemExperience = 50;

        public Golem(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, GolemExperience)
        {
        }
    }
}

namespace RpgGame.Interfaces
{
    using System.Windows.Forms;

    public interface IEnemy
    {
        int HitPoints { get; set; }

        int DefensePoints { get; set; }

        int AttackPoints { get; set; }

        bool IsAlive { get; set; }

        int Experience { get; set; }

        Position Position { get; set; }

        Pictures Picture { get; set; }

        PictureBox PicBox { get; set; }
    }
}

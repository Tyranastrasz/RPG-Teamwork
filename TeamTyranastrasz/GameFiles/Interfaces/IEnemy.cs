namespace RpgGame
{
    public interface IEnemy
    {
        int HitPoints { get; set; }

        int DefensePoints { get; set; }

        int AttackPoints { get; set; }

        void Attack();
    }
}

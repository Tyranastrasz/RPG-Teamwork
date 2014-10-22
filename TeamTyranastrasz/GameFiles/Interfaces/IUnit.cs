namespace RpgGame.Interfaces
{
    public interface IUnit : IAttack, IDefend
    {
        int CurrentHitPoints { get; set; }
        //PictureBox PicBox { get; }
    }
}

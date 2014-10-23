namespace RpgGame.Interfaces
{
    public interface ITrade
    {
        void Sell(IItem item);

        void Buy(IItem item);
    }
}

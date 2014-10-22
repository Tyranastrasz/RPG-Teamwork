namespace RpgGame.Interfaces
{
    using RpgGame.Items;

    public interface ITrade
    {
        void Sell(IItem item);

        void Buy(IItem item);
    }
}

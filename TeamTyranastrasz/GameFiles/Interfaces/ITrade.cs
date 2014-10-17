namespace RpgGame.Interfaces
{
    using RpgGame.Items;

    public interface ITrade
    {
        void Sell(Item item);

        void Buy(Item item);
    }
}

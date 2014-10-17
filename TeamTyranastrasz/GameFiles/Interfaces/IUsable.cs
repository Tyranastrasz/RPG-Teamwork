namespace RpgGame.Interfaces
{
    using RpgGame.Items;

    public interface IUsable
    {
        void Consume(Item item);

        void Equip(Item item);

        void AddToInventory(Item item);

        void RemoveFromInventory(Item item);
    }
}

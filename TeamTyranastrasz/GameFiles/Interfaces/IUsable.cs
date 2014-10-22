namespace RpgGame.Interfaces
{
    using RpgGame.Items;

    public interface IUsable
    {
        void Consume(IItem item);

        void Equip(IItem item);

        void AddToInventory(IItem item);

        void RemoveFromInventory(IItem item);
    }
}

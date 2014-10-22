namespace RpgGame.Interfaces
{
    using RpgGame.Items;

    public interface IUsable
    {
        void Consume(IItem item);

        void Equip(IItem item, int id, bool IsNew);

        void UnEquip(IItem item);

        void AddToInventory(IItem item);

        void RemoveFromInventory(IItem item);
    }
}

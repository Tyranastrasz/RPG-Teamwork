namespace RpgGame.Items
{
    public class Boots : Armor
    {
        private const ItemType BootsItemType =  ItemType.Boots;

        public Boots(string name, int price, Pictures picture, int defencePoints = 0, int attackPoints = 0, int hitPoints = 0, int str = 0, int dex = 0, int vit = 0, int intl = 0, int levelRequirement = 0, string description = null)
            : base(name, price, picture, Boots.BootsItemType, defencePoints, attackPoints, hitPoints, str, dex, vit, intl, levelRequirement, description)
        {
        }
    }
}

namespace RpgGame.Items
{
    // Maybe we can make this abstract class... or not?
    public class Weapon : Item
    {
        private const ItemType WeaponItemType = ItemType.Weapon;

        public Weapon(string name, int price, Pictures picture, int defencePoints = 0, int attackPoints = 0, int hitPoints = 0, int str = 0, int dex = 0, int vit = 0, int intl = 0, int levelRequirement = 0, string description = null)
            : base(name, price, picture, Weapon.WeaponItemType, defencePoints, attackPoints, hitPoints, str, dex, vit, intl, levelRequirement, description)
        {
        }
    }
}

namespace RpgGame.Items
{
    public class Gloves : Armor
    {
        public Gloves(string name, int price, Pictures picture, int defencePoints = 0, int attackPoints = 0, int hitPoints = 0, int str = 0, int dex = 0, int vit = 0, int intl = 0, int levelRequirement = 0, string description = null)
            : base(name, price, picture, defencePoints, attackPoints, hitPoints, str, dex, vit, intl, levelRequirement, description)
        {
        }
    }
}

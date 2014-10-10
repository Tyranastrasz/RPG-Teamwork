namespace RpgGame.Items
{
    public class Boots : Armor
    {
        public Boots(string name, int str = 0, int dex = 0, int vit = 0, int intl = 0, int level = 0) : base(name)
        {
            this.Strength = str;
            this.Dexterity = dex;
            this.Vitality = vit;
            this.Intelligence = intl;
            this.LevelRequirement = level;
        }
    }
}

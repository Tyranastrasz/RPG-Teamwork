namespace RpgGame.Player
{
    public class Warrior : Player
    {
        public Warrior(string name, int str, int dex, int vit, int intl, int x, int y) : base(name)
        {
            this.Strength = str;
            this.Dexterity = dex;
            this.Vitality = vit;
            this.Intelligence = intl;
            this.X = x;
            this.Y = y;
        }
    }
}

namespace RpgGame.Player
{
    public class Rogue : Player
    {
        // TODO - some of the stats have to be hardcoded when initializing the player!
        public Rogue(string name, int str, int dex, int vit, int intl, int x, int y) : base(name)
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

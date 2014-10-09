namespace GameObject.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rogue : Player
    {
        //TODO - some of the stats have to be hardcoded when initializing the player!
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

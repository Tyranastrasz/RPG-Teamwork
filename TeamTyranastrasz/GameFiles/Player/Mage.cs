namespace RpgGame.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mage : Player
    {
        public Mage(string name, int str, int dex, int vit, int intl, int x, int y) : base(name)
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

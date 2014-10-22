using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgGame.Interfaces;
using RpgGame.Items;

namespace RpgGame.Forms
{
    public partial class ShopInventory : Form
    {
        public List<IItem> shopItems = new List<IItem>(); 
        
        public List<Position> shopItemsPossitions = new List<Position>();
        public List<Position> playerItemsPossitions = new List<Position>();
        
        public ShopInventory()
        {
            InitializeComponent();

            ICharacter playerCharacter = GameEngine.PlayerCharacter;

            this.shopItemsPossitions.Add(new Position(x: 12, y: 10));
            this.shopItemsPossitions.Add(new Position(x: 82, y: 10));
            this.shopItemsPossitions.Add(new Position(x: 152, y: 10));
            this.shopItemsPossitions.Add(new Position(x: 222, y: 10));
            this.shopItemsPossitions.Add(new Position(x: 292, y: 10));
            this.shopItemsPossitions.Add(new Position(x: 12, y: 80));
            this.shopItemsPossitions.Add(new Position(x: 82, y: 80));
            this.shopItemsPossitions.Add(new Position(x: 152, y: 80));
            this.shopItemsPossitions.Add(new Position(x: 222, y: 80));
            this.shopItemsPossitions.Add(new Position(x: 292, y: 80));
            this.shopItemsPossitions.Add(new Position(x: 12, y: 150));
            this.shopItemsPossitions.Add(new Position(x: 82, y: 150));
            this.shopItemsPossitions.Add(new Position(x: 152, y: 150));
            this.shopItemsPossitions.Add(new Position(x: 222, y: 150));
            this.shopItemsPossitions.Add(new Position(x: 292, y: 150));
            this.shopItemsPossitions.Add(new Position(x: 12, y: 150));
            this.shopItemsPossitions.Add(new Position(x: 82, y: 220));
            this.shopItemsPossitions.Add(new Position(x: 152, y: 220));
            this.shopItemsPossitions.Add(new Position(x: 222, y: 220));
            this.shopItemsPossitions.Add(new Position(x: 292, y: 220));
            this.shopItemsPossitions.Add(new Position(x: 12, y: 220));
            this.shopItemsPossitions.Add(new Position(x: 82, y: 290));
            this.shopItemsPossitions.Add(new Position(x: 152, y: 290));
            this.shopItemsPossitions.Add(new Position(x: 222, y: 290));
            this.shopItemsPossitions.Add(new Position(x: 292, y: 290));

            this.playerItemsPossitions.Add(new Position(x: 378, y: 10));
            this.playerItemsPossitions.Add(new Position(x: 448, y: 10));
            this.playerItemsPossitions.Add(new Position(x: 378, y: 80));
            this.playerItemsPossitions.Add(new Position(x: 448, y: 80));
            this.playerItemsPossitions.Add(new Position(x: 378, y: 150));
            this.playerItemsPossitions.Add(new Position(x: 448, y: 150));
            this.playerItemsPossitions.Add(new Position(x: 378, y: 220));
            this.playerItemsPossitions.Add(new Position(x: 448, y: 220));
            this.playerItemsPossitions.Add(new Position(x: 378, y: 290));
            this.playerItemsPossitions.Add(new Position(x: 448, y: 290));

            //this.shopItems.Add(new Weapon("Big Sword", 100, 0, 40, 0, 0, 10, 0, 0, 8, "Big sword for heavy strikes."));
            //this.shopItems.Add(new Weapon("Iron Sword", 5, 0, 5, 0, 0, 0, 0, 0, 1, "Basic battle equipment."));
            //this.shopItems.Add(new Helmet("Iron-horn Helm", 20, 2, 0, 3, 0, 0, 1, 0, 1, "Basic - but stylis."));
            //this.shopItems.Add(new Gloves("Fighter Gloves", 15, 1, 0, 2, 0, 1, 0, 0, 1, "Good for melee characters."));
            //this.shopItems.Add(new Boots("Armored Boots", 10, 1, 1, 0, 0, 0, 1, 0, 1, "Heavy and slow."));
            //this.shopItems.Add(new Chainmail("Chainmail", 25, 2, 0, 0, 0, 1, 1, 0, 1, "Chainmail armor mekas you more agile."));
            //this.shopItems.Add(new Potion("Small Health Potion", 20, 0, 0, 0, 0, 0, 0, 0, 1, "Return + 10hp"));
            //this.shopItems.Add(new Scroll("Teleport Scroll", 0, 0, 0, 0, 0, 0, 0, 0, 1, "Use to teleport to location."));
        }

        private void ShopInventory_Load(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}

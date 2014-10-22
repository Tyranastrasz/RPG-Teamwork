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

namespace RpgGame.Forms
{
    public partial class PlayerInventory : Form
    {
        public Position equipHelmePosition;
        public Position equipWeaponPosition;
        public Position equipChaimailPosition;
        public Position equipGlovesPosition;
        public Position equpBootsPosition;
        
        public List<Position> inventoryItemPositions = new List<Position>();

        ICharacter playerCharacter = GameEngine.PlayerCharacter;
        
        public PlayerInventory()
        {
            InitializeComponent();
            
            equipHelmePosition = new Position(82, 10);
            equipWeaponPosition = new Position(12, 80);
            equipChaimailPosition = new Position(82, 80);
            equipGlovesPosition = new Position(152, 80);
            equpBootsPosition = new Position(82, 150);
            
            this.inventoryItemPositions.Add(new Position(12, 220));
            this.inventoryItemPositions.Add(new Position(82, 220));
            this.inventoryItemPositions.Add(new Position(152, 220));
            this.inventoryItemPositions.Add(new Position(222, 220));
            this.inventoryItemPositions.Add(new Position(292, 220));
            this.inventoryItemPositions.Add(new Position(12, 290));
            this.inventoryItemPositions.Add(new Position(82, 290));
            this.inventoryItemPositions.Add(new Position(152, 290));
            this.inventoryItemPositions.Add(new Position(222, 290));
            this.inventoryItemPositions.Add(new Position(292, 290));
        }

        private void PlayerInventory_Load(object sender, EventArgs e)
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

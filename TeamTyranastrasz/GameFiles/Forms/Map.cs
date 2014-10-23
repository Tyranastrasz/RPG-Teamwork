using System;
using System.Windows.Forms;
using RpgGame.Interfaces;
using RpgGame.SaveAndLoad;
using System.Diagnostics;  

namespace RpgGame.Forms
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            ICharacter playerCharacter = GameEngine.PlayerCharacter;
            Sound.PlayMapSound();

            // TODO: Make buttons transperant with no text, but on hover the objects are sparkling (photoshoped layers for each location)
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            if (GameEngine.Inventory == null)
            {
                GameEngine.Inventory = new PlayerInventory();
            }
            GameEngine.Inventory.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Save.SaveGame();
        }

        private void load_Click(object sender, EventArgs e)
        {
            SaveAndLoad.Load.LoadGame();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void battleTower_Click(object sender, EventArgs e)
        {
            GameEngine.CreateBattleScreen();
            this.Hide();
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;

            // Battle Tower Mouse Hover
            int towerLocationX = battleTower.Location.X;
            int towerLocationY = battleTower.Location.Y;

            int towerHeigh = battleTower.Size.Height;
            int towerWidth = battleTower.Size.Width;

            if (mouseX > towerLocationX && mouseX < towerLocationX + towerHeigh &&
                mouseY > towerLocationY && mouseY < towerLocationX + towerWidth)
            {
                battleTower.Visible = true;
            }
            else
            {
                battleTower.Visible = false;
            }

            // Secret Place Mouse Hover
            int secretPlaceLocationX = secretPlace.Location.X;
            int secretPlaceLocationY = secretPlace.Location.Y;

            int secretPlaceHeigh = secretPlace.Size.Height;
            int secretPlaceWidth = secretPlace.Size.Width;

            if (mouseX > secretPlaceLocationX && mouseX < secretPlaceLocationX + secretPlaceHeigh &&
                mouseY > secretPlaceLocationY && mouseY < secretPlaceLocationY + secretPlaceWidth)
            {
                secretPlace.Visible = true;
            }
            else
            {
                secretPlace.Visible = false;
            }

            int townLocationX = townSelected.Location.X;
            int townLocationY = townSelected.Location.Y;

            int townHeigh = townSelected.Size.Height;
            int townWidth = townSelected.Size.Width;

            if (mouseX > townLocationX && mouseX < townLocationX + townHeigh &&
                mouseY > townLocationY && mouseY < townLocationY + townWidth)
            {
                townSelected.Visible = true;
            }
            else
            {
                townSelected.Visible = false;
            }

            // TODO: Create separate method for mouse hover
        }

        private void secretPlace_Click(object sender, EventArgs e)
        {
            Process.Start("http://softuni.bg");
        }

        private void townSelected_Click(object sender, EventArgs e)
        {
            Town enterTown = new Town();
            enterTown.Show();
            this.Hide();
        }
    }
}

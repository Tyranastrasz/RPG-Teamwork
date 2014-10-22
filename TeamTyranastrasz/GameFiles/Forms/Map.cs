using System;
using System.Windows.Forms;
using RpgGame.Interfaces;
using RpgGame.SaveAndLoad;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void battleStart_Click(object sender, EventArgs e)
        {
            GameEngine.CreateBattleScreen();
            this.Hide();
        }

        private void enterTown_Click(object sender, EventArgs e)
        {
            Town enterTown = new Town();
            enterTown.Show();
            this.Hide();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            if (GameEngine.Inventory != null)
            {
                GameEngine.Inventory.Show();
            }
            else
            {
                GameEngine.Inventory = new PlayerInventory();
            }
            GameEngine.Inventory.Visible = false;
            GameEngine.Inventory.ShowDialog();
        }

        private void quests_Click(object sender, EventArgs e)
        {

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
    }
}

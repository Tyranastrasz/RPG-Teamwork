using System;
using System.Windows.Forms;
using RpgGame.Interfaces;

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
            PlayerInventory inventory = new PlayerInventory();
            inventory.ShowDialog();
        }

        private void quests_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {

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

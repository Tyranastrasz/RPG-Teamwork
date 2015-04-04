namespace RpgGame.Forms
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    using SaveAndLoad;

    public partial class Town : Form
    {
        private ShopInventory itemShop;

        public Town()
        {
            this.InitializeComponent();
        }

        private void Town_Load(object sender, EventArgs e)
        {
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.itemShop = new ShopInventory();
            this.itemShop.ShowDialog();
        }

        private void btnShop_MouseEnter(object sender, EventArgs e)
        {
            this.btnShop.Image = Properties.Resources.town_shop_hover;
            Cursor = Cursors.Hand;
        }

        private void btnShop_MouseLeave(object sender, EventArgs e)
        {
            this.btnShop.Image = null;
            Cursor = Cursors.Default;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save.SaveGame();
            MessageBox.Show("Game saved!");
        }

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            this.saveBtn.Image = Properties.Resources.town_save_hover;
            Cursor = Cursors.Hand;
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            this.saveBtn.Image = null;
            Cursor = Cursors.Default;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAndLoad.Load.LoadGame();
                MessageBox.Show("Game loaded!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No save games found!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
        }

        private void loadBtn_MouseEnter(object sender, EventArgs e)
        {
            this.loadBtn.Image = Properties.Resources.town_load_hover;
            Cursor = Cursors.Hand;
        }

        private void loadBtn_MouseLeave(object sender, EventArgs e)
        {
            this.loadBtn.Image = null;
            Cursor = Cursors.Default;
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            GameEngine.Inventory = new PlayerInventory();

            GameEngine.Inventory.ShowDialog();
        }

        private void inventoryBtn_MouseEnter(object sender, EventArgs e)
        {
            this.inventoryBtn.Image = Properties.Resources.town_inventory_hover;
            Cursor = Cursors.Hand;
        }

        private void inventoryBtn_MouseLeave(object sender, EventArgs e)
        {
            this.inventoryBtn.Image = null;
            Cursor = Cursors.Default;
        }

        // temp ussage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMap_Click(object sender, EventArgs e)
        {
            Close();
            GameEngine.Map.Show();
        }

        // This code reduces the flickering when loading the forms.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
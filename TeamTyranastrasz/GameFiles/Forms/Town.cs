using RpgGame.Interfaces;
using RpgGame.SaveAndLoad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgGame.Forms
{
    public partial class Town : Form
    {
        private ShopInventory itemShop = new ShopInventory();

        public Town()
        {
            InitializeComponent();
        }

        private void Town_Load(object sender, EventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            itemShop.ShowDialog();
        }

        private void btnShop_MouseEnter(object sender, EventArgs e)
        {
            this.btnShop.Image = Properties.Resources.town_shop_hover;
            this.Cursor = Cursors.Hand;
        }

        private void btnShop_MouseLeave(object sender, EventArgs e)
        {
            this.btnShop.Image = null;
            this.Cursor = Cursors.Default;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save.SaveGame();
        }

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            this.saveBtn.Image = Properties.Resources.town_save_hover;
            this.Cursor = Cursors.Hand;
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            this.saveBtn.Image = null;
            this.Cursor = Cursors.Default;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            SaveAndLoad.Load.LoadGame();
        }

        private void loadBtn_MouseEnter(object sender, EventArgs e)
        {
            this.loadBtn.Image = Properties.Resources.town_load_hover;
            this.Cursor = Cursors.Hand;
        }

        private void loadBtn_MouseLeave(object sender, EventArgs e)
        {
            this.loadBtn.Image = null;
            this.Cursor = Cursors.Default;
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            if (GameEngine.Inventory == null)
            {
                GameEngine.Inventory = new PlayerInventory();
            }
            GameEngine.Inventory.ShowDialog();
        }

        private void inventoryBtn_MouseEnter(object sender, EventArgs e)
        {
            this.inventoryBtn.Image = Properties.Resources.town_inventory_hover;
            this.Cursor = Cursors.Hand;
        }

        private void inventoryBtn_MouseLeave(object sender, EventArgs e)
        {
            this.inventoryBtn.Image = null;
            this.Cursor = Cursors.Default;
        }
        
        // temp ussage to close the form
        private void exit_Click(object sender, EventArgs e)
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

        private void backToMap_Click(object sender, EventArgs e)
        {
            this.Close();
            GameEngine.Map.Show();
        }
    }
}

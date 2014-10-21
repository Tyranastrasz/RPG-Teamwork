using RpgGame.Interfaces;
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
        public Town()
        {
            InitializeComponent();
            ICharacter playerCharacter = GameEngine.PlayerCharacter;
        }

        private void Town_Load(object sender, EventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopInventory shop = new ShopInventory();
            shop.ShowDialog();
        }
        
        // temp ussage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

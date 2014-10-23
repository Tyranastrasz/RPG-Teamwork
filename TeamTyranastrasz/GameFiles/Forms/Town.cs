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
            GameEngine.Map.Show();
        }
    }
}

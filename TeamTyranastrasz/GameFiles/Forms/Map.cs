using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgGame
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void battleStart_Click(object sender, EventArgs e)
        {
            Battle battleScreen = new Battle();
            battleScreen.Show();
            this.Hide();
        }

        private void enterTown_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Click(object sender, EventArgs e)
        {

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
    }
}

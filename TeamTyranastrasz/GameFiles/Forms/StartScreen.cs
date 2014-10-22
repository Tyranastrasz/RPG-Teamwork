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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void loadGame_Click(object sender, EventArgs e)
        {
            SaveAndLoad.Load.LoadGame();
            Map mainMap = new Map();
            mainMap.Show();
            this.Hide();
        }

        private void about_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Paint(object sender, PaintEventArgs e)
        {
            exit.ForeColor = Color.FromArgb(163, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DesignPanelUp.BackColor = Color.FromArgb(163, 0, 0, 0);
            
        }

        private void DesignPanelBottom_Paint_1(object sender, PaintEventArgs e)
        {
            DesignPanelBottom.BackColor = Color.FromArgb(163, 0, 0, 0);
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            CharacterCreation charCreation = new CharacterCreation();
            charCreation.Show();

            this.Hide();
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

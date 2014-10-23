namespace RpgGame.Forms
{
    using System;
    using System.IO;
    using System.Drawing;
    using System.Windows.Forms;

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
            try
            {
                SaveAndLoad.Load.LoadGame();
                Map mainMap = new Map();
                GameEngine.Map = mainMap;
                mainMap.Show();
                MessageBox.Show("Game loaded!");
                this.Hide();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("You have no saved games!");
            }
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

        // This code reduces the flickering when loading the forms.
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

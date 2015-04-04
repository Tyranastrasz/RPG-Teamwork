namespace RpgGame.Forms
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    using Interfaces;
    using SaveAndLoad;

    public partial class Map : Form
    {
        public Map()
        {
            this.InitializeComponent();

            //ICharacter playerCharacter = GameEngine.PlayerCharacter;
            this.welcome.Text = "Welcome, " + GameEngine.PlayerCharacter.Name + " !";
            this.theChoosenOne.Image = this.GetCharacterImage(Map.GetCharacterClass(GameEngine.PlayerCharacter));
            Sound.Sound.PlayMapSound();
        }

        private Image GetCharacterImage(string characterClass)
        {
            switch (characterClass)
            {
                case "Warrior":
                    return Properties.Resources.warrior;
                case "Rogue":
                    return Properties.Resources.rogue;
                case "Mage":
                    return Properties.Resources.mage;
                default:
                    throw new NoPictureException();
            }
        }

        private static string GetCharacterClass(ICharacter character)
        {
            string[] characterMeta = character.ToString().Split('.');
            return characterMeta[characterMeta.Length - 1];
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            GameEngine.Inventory = new PlayerInventory();
            GameEngine.Inventory.ShowDialog();
        }

        private void battleTower_Click(object sender, EventArgs e)
        {
            GameEngine.CreateBattleScreen();
            Hide();
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;

            // Battle Tower Mouse Hover
            int towerLocationX = this.battleTower.Location.X;
            int towerLocationY = this.battleTower.Location.Y;

            int towerHeigh = this.battleTower.Size.Height;
            int towerWidth = this.battleTower.Size.Width;

            if (mouseX > towerLocationX && mouseX < towerLocationX + towerHeigh &&
                mouseY > towerLocationY && mouseY < towerLocationX + towerWidth)
            {
                this.battleTower.Visible = true;
            }
            else
            {
                this.battleTower.Visible = false;
            }

            // Secret Place Mouse Hover
            int secretPlaceLocationX = this.secretPlace.Location.X;
            int secretPlaceLocationY = this.secretPlace.Location.Y;

            int secretPlaceHeigh = this.secretPlace.Size.Height;
            int secretPlaceWidth = this.secretPlace.Size.Width;

            if (mouseX > secretPlaceLocationX && mouseX < secretPlaceLocationX + secretPlaceHeigh &&
                mouseY > secretPlaceLocationY && mouseY < secretPlaceLocationY + secretPlaceWidth)
            {
                this.secretPlace.Visible = true;
            }
            else
            {
                this.secretPlace.Visible = false;
            }

            int townLocationX = this.townSelected.Location.X;
            int townLocationY = this.townSelected.Location.Y;

            int townHeigh = this.townSelected.Size.Height;
            int townWidth = this.townSelected.Size.Width;

            if (mouseX > townLocationX && mouseX < townLocationX + townHeigh &&
                mouseY > townLocationY && mouseY < townLocationY + townWidth)
            {
                this.townSelected.Visible = true;
            }
            else
            {
                this.townSelected.Visible = false;
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
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Map_Load(object sender, EventArgs e)
        {
        }

        private void save_Click(object sender, EventArgs e)
        {
            Save.SaveGame();
            MessageBox.Show("Game saved!");
        }

        private void load_Click(object sender, EventArgs e)
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
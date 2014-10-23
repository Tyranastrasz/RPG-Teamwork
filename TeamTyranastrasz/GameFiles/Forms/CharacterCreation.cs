using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgGame.Interfaces;
using RpgGame.Player;
using RpgGame;

namespace RpgGame.Forms
{
    public partial class CharacterCreation : Form
    {
        private PictureBox warriorPicBox;
        private PictureBox roguePicBox;
        private PictureBox magePicBox;

        public CharacterCreation()
        {

            warriorPicBox = new PictureBox();
            warriorPicBox.Image = Properties.Resources.warrior;
            warriorPicBox.Width = 250;
            warriorPicBox.Height = 250;
            warriorPicBox.BackColor = Color.Transparent;
            warriorPicBox.Left = 190;
            warriorPicBox.Top = 240;
            this.Controls.Add(warriorPicBox);

            roguePicBox = new PictureBox();
            roguePicBox.Image = Properties.Resources.rogue;
            roguePicBox.Width = 250;
            roguePicBox.Height = 250;
            roguePicBox.BackColor = Color.Transparent;
            roguePicBox.Left = 190;
            roguePicBox.Top = 240;
            this.Controls.Add(roguePicBox);
            roguePicBox.Hide();

            magePicBox = new PictureBox();
            magePicBox.Image = Properties.Resources.mage;
            magePicBox.Width = 250;
            magePicBox.Height = 250;
            magePicBox.BackColor = Color.Transparent;
            magePicBox.Left = 190;
            magePicBox.Top = 240;
            this.Controls.Add(magePicBox);
            magePicBox.Hide();

            InitializeComponent();

            //TODO: This will be moved on checked event, but for now, lets load bars here:
            
            strengthProgressBar.Maximum = 50;
            dexterityProgressBar.Maximum = 50;
            vitalityProgressBar.Maximum = 50;
            intelligenceProgressBar.Maximum = 50;

            // TODO: Add background music and sound for clicks
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {

        }

        private void lblCharName_Click(object sender, EventArgs e)
        {

        }

        private void inputCharName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCharacter_Enter(object sender, EventArgs e)
        {

        }

        // temp usage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void DesignPanelUp_Paint(object sender, PaintEventArgs e)
        //{
            
        //    // TODO: Animate panels to slide from out to the screen. Use timer and ticks to do that
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* TODO: One box with arrows. On click the image changes
               TODO: Arrays with images. If the mage is clicked (for example), 
               TODO: the 'array with mages' is loaded in the box and player can choose from different pictures for a hero*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Hide();
        }

        private void tempReffBox1_Click(object sender, EventArgs e)
        {
            //tempReffBox1.BringToFront(); interesting method
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DescriptionPanel.BackColor = Color.FromArgb(163, 0, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void arrowRight_Click(object sender, EventArgs e)
        {
        }

        private void arrowLeft_Click(object sender, EventArgs e)
        {
        }

        private void about_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(inputCharName.Text))
            {
                //throw new Exception("");
                MessageBox.Show("You must type in a name for your hero!");
                return;
            }

            if (!Btn_Mage.Checked && !Btn_Rogue.Checked && !Btn_Warrior.Checked)
            {
                // throw new Exception("")
                MessageBox.Show("You must select a character type!");
                return;
            }
            else if (this.Btn_Warrior.Checked)
            {
                string characterClass = "warrior";

                GameEngine.CreateNewPlayer(characterClass, inputCharName.Text);
            }
            else if (this.Btn_Mage.Checked)
            {
                string characterClass = "mage";
                GameEngine.CreateNewPlayer(characterClass, inputCharName.Text);
            }
            else if (this.Btn_Rogue.Checked)
            {
                string characterClass = "rogue";
                GameEngine.CreateNewPlayer(characterClass, inputCharName.Text);
            }

            this.Close();
            GameEngine.Map = new Map();
            GameEngine.Map.Show();
        }

        private void strengthProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Mage_CheckedChanged_1(object sender, EventArgs e)
        {
            ResetProgressBars();
            strengthProgressBar.Increment(3);
            dexterityProgressBar.Increment(5);
            vitalityProgressBar.Increment(7);
            intelligenceProgressBar.Increment(10);
            warriorPicBox.Hide();
            roguePicBox.Hide();
            magePicBox.Show();

            CharacterType.Text = "Mage";
            HeroDescription.Text = @"The mage is the loyal soldier, the man that stands up for what is right. The warrior is the guy that gets things done his own way.

The warrior has no time for childish games, but he doesn't let his personal life get in the way of his mission. The warrior is often a hero in the making on the verge of doing something great, a warrior is miss understood at times but he always pulls threw.

The warrior is born not made, he knows that his soul purpose in life is to serve and fight. ";
        }

        private void Btn_Warrior_CheckedChanged(object sender, EventArgs e)
        {
            ResetProgressBars();

            // Warrior base stats
            strengthProgressBar.Increment(5);
            dexterityProgressBar.Increment(2);
            vitalityProgressBar.Increment(8);
            intelligenceProgressBar.Increment(2);
            warriorPicBox.Show();
            roguePicBox.Hide();
            magePicBox.Hide();

            CharacterType.Text = "Warrior";
            HeroDescription.Text = @"The warrior is the loyal soldier, the man that stands up for what is right. The warrior is the guy that gets things done his own way.

The warrior has no time for childish games, but he doesn't let his personal life get in the way of his mission. The warrior is often a hero in the making on the verge of doing something great, a warrior is miss understood at times but he always pulls threw.

The warrior is born not made, he knows that his soul purpose in life is to serve and fight. ";
        }

        private void Btn_Rogue_CheckedChanged(object sender, EventArgs e)
        {
            ResetProgressBars();

            strengthProgressBar.Increment(10);
            dexterityProgressBar.Increment(4);
            vitalityProgressBar.Increment(10);
            intelligenceProgressBar.Increment(5);
            warriorPicBox.Hide();
            roguePicBox.Show();
            magePicBox.Hide();

            CharacterType.Text = "Rogue";
            HeroDescription.Text = @"The rogue is the loyal soldier, the man that stands up for what is right. The warrior is the guy that gets things done his own way.

The warrior has no time for childish games, but he doesn't let his personal life get in the way of his mission. The warrior is often a hero in the making on the verge of doing something great, a warrior is miss understood at times but he always pulls threw.

The warrior is born not made, he knows that his soul purpose in life is to serve and fight. ";
        }

        private void ResetProgressBars()
        {
            strengthProgressBar.Value = 0;
            dexterityProgressBar.Value = 0;
            vitalityProgressBar.Value = 0;
            intelligenceProgressBar.Value = 0;
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

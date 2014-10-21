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
        public CharacterCreation()
        {
            InitializeComponent();
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

        private void createChar_Click(object sender, EventArgs e)
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

            Map mainMap = new Map();
            mainMap.Show();

            this.Close();
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

    }
}

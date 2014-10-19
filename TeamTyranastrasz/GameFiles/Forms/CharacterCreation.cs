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

namespace RpgGame.Forms
{
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();
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

            Position characterPosition = new Position();
            if (!Btn_Mage.Checked && !Btn_Rogue.Checked && !Btn_Warrior.Checked)
            {
                // throw new Exception("")
                MessageBox.Show("You must select a character type!");
                return;
            }
            else if (this.Btn_Warrior.Checked)
            {
                ICharacter warrior = new Warrior(inputCharName.Text, characterPosition);
            }
            else if (this.Btn_Mage.Checked)
            {
                ICharacter mage = new Mage(inputCharName.Text, characterPosition);
            }
            else if (this.Btn_Warrior.Checked)
            {
                ICharacter rogue = new Rogue(inputCharName.Text, characterPosition);
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
    }
}

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

        private void btnWarrSelect_Click(object sender, EventArgs e)
        {

        }

        private void createChar_Click(object sender, EventArgs e)
        {
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

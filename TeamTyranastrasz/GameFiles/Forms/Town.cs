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
        }

        private void Town_Load(object sender, EventArgs e)
        {

        }

        // temp ussage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

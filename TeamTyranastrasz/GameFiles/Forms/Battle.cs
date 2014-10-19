using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RpgGame.Enemies.MeleeType;
using RpgGame.Enemies.RangeType;

namespace RpgGame.Forms
{
    public partial class Battle : Form
    {
        private List<IEnemy> enemyList = new List<IEnemy>();

        private List<PictureBox> picBoxList = new List<PictureBox>();

        private Label enemyHp;
        private Label enemyDmg;
        private Label enemyDef;
        private Label debug;
        
        public Battle()
        {
            InitializeComponent();

            debug = new Label();
            debug.Left = 10;
            debug.Top = 500;
            debug.Width = 600;
            debug.Height = 50;
            Controls.Add(debug);

            enemyHp = new Label();
            enemyHp.Left = 250;
            enemyHp.Top = 30;
            enemyHp.Width = 20;
            Controls.Add(enemyHp);

            enemyDmg = new Label();
            enemyDmg.Left = 250;
            enemyDmg.Top = 60;
            enemyDmg.Width = 20;
            Controls.Add(enemyDmg);

            enemyDef = new Label();
            enemyDef.Left = 250;
            enemyDef.Top = 90;
            enemyDef.Width = 20;
            Controls.Add(enemyDef);

            IEnemy enemy = new Golem("Dumb", 85, 35, 20, Pictures.Golem);
            enemy.Position = new Position(25, 12);
            enemyList.Add(enemy);

            IEnemy enemy2 = new Ork("Orglem", 100, 40, 25, Pictures.Golem);
            enemy2.Position = new Position(25, 200);
            enemyList.Add(enemy2);
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (IEnemy enemy in enemyList)
            {
                PictureBox picBox = new PictureBox();
                picBoxList.Add(picBox);
                DrawImages(picBox, enemy, Properties.Resources.golem, counter.ToString());
                counter++;
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

        }

        private void btnDefend_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackSkillLow_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackSkillMed_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackSkillHigh_Click(object sender, EventArgs e)
        {

        }

        private void btnAttackBuff_Click(object sender, EventArgs e)
        {

        }

        private void btnDefenseBuff_Click(object sender, EventArgs e)
        {

        }

        private void btnHeal_Click(object sender, EventArgs e)
        {

        }

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {

        }

        void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int id = int.Parse(p.Name);

            enemyHp.Text = enemyList[id].HitPoints.ToString();
            enemyDef.Text = enemyList[id].DefensePoints.ToString();
            enemyDmg.Text = enemyList[id].AttackPoints.ToString();
        }

        private void DrawImages(PictureBox pictureBox, IEnemy enemy, Image image, string id)
        {
            //golemEnemy1.Position = new Position(25, 12);
            //golemEnemy1.PictureBox.Image = Properties.Resources.golem;
            //golemEnemy1.PictureBox.Width = Properties.Resources.golem.Width;
            //golemEnemy1.PictureBox.Height = Properties.Resources.golem.Height;
            //golemEnemy1.PictureBox.BackColor = Color.Transparent;
            //golemEnemy1.PictureBox.Left = golemEnemy1.Position.X;
            //golemEnemy1.PictureBox.Top = golemEnemy1.Position.Y;
            //golemEnemy1.PictureBox.Click += PictureBox_Click;
            //this.Controls.Add(golemEnemy1.PictureBox);

            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Left = enemy.Position.X;
            pictureBox.Top = enemy.Position.Y;
            pictureBox.Click += PictureBox_Click;
            pictureBox.Name = id;
            this.Controls.Add(pictureBox);
        }

        // temp usage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

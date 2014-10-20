namespace RpgGame.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using RpgGame.Enemies.MeleeType;
    using RpgGame.Enemies.RangeType;
    using RpgGame.Interfaces;

    public partial class Battle : Form
    {
        private BattleManager battle = new BattleManager();

        private Label debug;
        private Label targetBox;
        
        public Battle()
        {
            InitializeComponent();

            debug = new Label();
            debug.Left = 10;
            debug.Top = 500;
            debug.Width = 600;
            debug.Height = 50;
            //Controls.Add(debug);

            targetBox = new Label();
            targetBox.Left = 0;
            targetBox.Top = 0;
            targetBox.Width = 100;
            targetBox.Height = 50;
            Controls.Add(targetBox);
            targetBox.Hide();

            IEnemy enemy = new Golem("Dumb", 85, 35, 20, Pictures.Golem);
            enemy.Position = new Position(25, 12);
            battle.enemyList.Add(enemy);

            IEnemy enemy2 = new Ork("Orglem", 100, 40, 25, Pictures.Golem);
            enemy2.Position = new Position(25, 200);
            battle.enemyList.Add(enemy2);
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            DrawEnemies();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

            if (battle.playerTurn == true)
            {
                try
                {
                    battle.Attack((IUnit)battle.player, (IUnit)battle.currentTarget);
                }
                catch (EndBattleException ex)
                {
                    MessageBox.Show(ex.ToString());
                    Map mapScreen = new Map();
                    mapScreen.Show();
                    this.Close();
                }
            }
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            battle.playerTurn = false;
            battle.EnemyTurn();
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

            battle.currentTarget = battle.enemyList[id];
            battle.currentTargetId = id;
            showTargetBox(targetBox, battle.enemyList[id]);
        }

        private void DrawImages(PictureBox pictureBox, IEnemy enemy, Image image, string id)
        {
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

        private void DrawEnemies()
        {
            int counter = 0;
            foreach (IEnemy enemy in battle.enemyList)
            {
                DrawImages(enemy.PicBox, enemy, Properties.Resources.golem, counter.ToString());
                counter++;
            }
        }

        private void showTargetBox(Label box, IEnemy enemy)
        {
            box.Show();
            box.Text = "Attack: " + enemy.AttackPoints
                        + "\nDefense: " + enemy.DefensePoints
                        + "\nHitpoints: " + enemy.HitPoints;
        }

        // temp usage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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

        private Label targetBox;
        private Label mainStatsBox;
        private Label subStatsBox;
        private Label dicePointsBox;
        public ProgressBar experienceBar;

        public Battle()
        {
            InitializeComponent();

            targetBox = new Label();
            targetBox.Left = 500;
            targetBox.Top = 0;
            targetBox.Width = 130;
            targetBox.Height = 68;
            targetBox.Image = Properties.Resources.target_panel;
            targetBox.BackColor = Color.Transparent;
            targetBox.ForeColor = Color.White;
            targetBox.Padding = new Padding(30, 0, 25, 0);
            targetBox.Font = new Font("Microsoft Sans Serif", 8);
            Controls.Add(targetBox);
            targetBox.Hide();

            mainStatsBox = new Label();
            mainStatsBox.Left = 650;
            mainStatsBox.Top = 650;
            mainStatsBox.Width = 150;
            mainStatsBox.Height = 40;
            mainStatsBox.BackColor = Color.Transparent;
            mainStatsBox.ForeColor = Color.White;
            Controls.Add(mainStatsBox);

            subStatsBox = new Label();
            subStatsBox.Left = 650;
            subStatsBox.Top = 710;
            subStatsBox.Width = 150;
            subStatsBox.Height = 40;
            subStatsBox.BackColor = Color.Transparent;
            subStatsBox.ForeColor = Color.White;
            Controls.Add(subStatsBox);

            dicePointsBox = new Label();
            dicePointsBox.Left = 900;
            dicePointsBox.Top = 600;
            dicePointsBox.Width = 120;
            dicePointsBox.Height = 50;
            dicePointsBox.BackColor = Color.Transparent;
            dicePointsBox.ForeColor = Color.White;
            Controls.Add(dicePointsBox);

            experienceBar = new ProgressBar();
            experienceBar.Location = new System.Drawing.Point(294, 741);
            experienceBar.Name = "experienceBar";
            experienceBar.Size = new System.Drawing.Size(293, 23);
            experienceBar.TabIndex = 14;
            experienceBar.Maximum = 1000;
            experienceBar.Value = battle.Player.Experience;
            Controls.Add(experienceBar);

            battle.CreateEnemies();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            DrawEnemies();
            RefreshStats();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

            if (battle.IsPlayerTurn == true && battle.CurrentTarget != null)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackDicePoints);
                    battle.Attack((IUnit)battle.Player, (IUnit)battle.CurrentTarget);
                    if (battle.EnemyList[battle.CurrentTargetId].IsAlive)
                    {
                        showTargetBox(targetBox, (IUnit)battle.EnemyList[battle.CurrentTargetId]);
                    }
                    RefreshStats();
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.DefendDicePoints);
                    battle.Defend();
                    RefreshStats();
                }
                catch(NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            if (battle.AttackBuffUsed == true)
            {
                battle.Player.ClearBuff("attack");
                battle.AttackBuffUsed = false;
            }
            if (battle.DefenceBuffUsed == true)
            {
                battle.Player.ClearBuff("defence");
                battle.DefenceBuffUsed = false;
            }
            if (battle.HealthBuffUsed == true)
            {
                battle.Player.ClearBuff("health");
                battle.HealthBuffUsed = false;
            }

            battle.EnemyTurn();
        }

        private void btnAttackSkillLow_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.CurrentTarget != null)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill1DicePoints);
                    battle.Player.BonusAttackPoints += battle.Player.CalculateSkillStats("low");
                    battle.Attack((IUnit)battle.Player, (IUnit)battle.CurrentTarget);
                    battle.Player.BonusAttackPoints -= battle.Player.CalculateSkillStats("low");
                    if (battle.EnemyList[battle.CurrentTargetId].IsAlive)
                    {
                        showTargetBox(targetBox, (IUnit)battle.EnemyList[battle.CurrentTargetId]);
                    }
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnAttackSkillMed_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.CurrentTarget != null)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill2DicePoints);
                    battle.Player.BonusAttackPoints += battle.Player.CalculateSkillStats("medium");
                    battle.Attack((IUnit)battle.Player, (IUnit)battle.CurrentTarget);
                    battle.Player.BonusAttackPoints -= battle.Player.CalculateSkillStats("medium");
                    if (battle.EnemyList[battle.CurrentTargetId].IsAlive)
                    {
                        showTargetBox(targetBox, (IUnit)battle.EnemyList[battle.CurrentTargetId]);
                    }
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnAttackSkillHigh_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.CurrentTarget != null)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill3DicePoints);
                    battle.Player.BonusAttackPoints += battle.Player.CalculateSkillStats("heavy");
                    battle.Attack((IUnit)battle.Player, (IUnit)battle.CurrentTarget);
                    battle.Player.BonusAttackPoints -= battle.Player.CalculateSkillStats("heavy");
                    if (battle.EnemyList[battle.CurrentTargetId].IsAlive)
                    {
                        showTargetBox(targetBox, (IUnit)battle.EnemyList[battle.CurrentTargetId]);
                    }
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnAttackBuff_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.AttackBuffUsed == false)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackBuffDicePoints);
                    battle.Player.CastBuff("attack");
                    battle.AttackBuffUsed = true;
                    RefreshStats();
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnDefenseBuff_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.DefenceBuffUsed == false)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.DefenceBuffDicePoints);
                    battle.Player.CastBuff("defence");
                    battle.DefenceBuffUsed = true;
                    RefreshStats();
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.HealthBuffUsed == false)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.HealthDicePoints);
                    battle.Player.CastBuff("health");
                    battle.HealthBuffUsed = true;
                    RefreshStats();
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int id = int.Parse(p.Name);

            battle.CurrentTarget = battle.EnemyList[id];
            battle.CurrentTargetId = id;
            showTargetBox(targetBox, (IUnit)battle.EnemyList[id]);
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
            foreach (IEnemy enemy in battle.EnemyList)
            {
                DrawImages(enemy.PicBox, enemy, getImage(enemy), counter.ToString());
                counter++;
            }
        }

        private void showTargetBox(Label box, IUnit enemy)
        {
            box.Show();
            box.Text = "\nAttack: " + enemy.Attack()
                        + "\nDefense: " + enemy.Defend()
                        + "\nHitpoints: " + enemy.CurrentHitPoints;
        }

        private Image getImage(IEnemy enemy)
        {
            switch (enemy.Picture)
            {
                case Pictures.Golem:
                    return Properties.Resources.golem;
                    break;
                //case Pictures.Ork:
                //    return Properties.Resources.ork;
                //    break;
                //case Pictures.Skeleton:
                //    return Properties.Resources.skeleton;
                //    break;
                //case Pictures.Drake:
                //    return Properties.Resources.drake;
                //    break;
                //case Pictures.Goblin:
                //    return Properties.Resources.goblin;
                //    break;
                //case Pictures.Shade:
                //    return Properties.Resources.shade;
                //    break;
                default:
                    return Properties.Resources.golem;
                //throw new NoPictureException();
            }
        }

        public void RefreshStats()
        {
            this.mainStatsBox.Text = "Strength: " + battle.Player.Strength
                              + "      Intelligence: " + battle.Player.Intelligence
                              + "\n\nDexterity: " + battle.Player.Dexterity
                              + "     Vitality: " + battle.Player.Vitality;

            this.subStatsBox.Text = "Attack: " + battle.Player.Attack()
                              + "        Defence: " + battle.Player.Defend()
                              + "\n\nHealth: " + battle.Player.CurrentHitPoints;

            this.dicePointsBox.Text = battle.DicePoints.ToString();
        }

        // temp usage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

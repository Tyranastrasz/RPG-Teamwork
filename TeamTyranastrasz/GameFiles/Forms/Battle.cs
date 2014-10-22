using RpgGame.Exceptions;

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

            this.attackPb.Value = BattleManager.AttackDicePoints;
            this.defendPb.Value = BattleManager.DefendDicePoints;
            this.attackSkillLowPb.Value = BattleManager.AttackSkill1DicePoints;
            this.attackSkillMedPb.Value = BattleManager.AttackSkill2DicePoints;
            this.attackSkillHeavyPb.Value = BattleManager.AttackSkill3DicePoints;
            this.attackBuffPb.Value = BattleManager.AttackBuffDicePoints;
            this.defenceBuffPb.Value = BattleManager.DefenceBuffDicePoints;
            this.healthBuffPb.Value = BattleManager.HealthDicePoints;

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
            mainStatsBox.Left = 640;
            mainStatsBox.Top = 650;
            mainStatsBox.Width = 95;
            mainStatsBox.Height = 120;
            mainStatsBox.BackColor = Color.Transparent;
            mainStatsBox.ForeColor = Color.White;
            Controls.Add(mainStatsBox);

            subStatsBox = new Label();
            subStatsBox.Left = 735;
            subStatsBox.Top = 650;
            subStatsBox.Width = 80;
            subStatsBox.Height = 120;
            subStatsBox.BackColor = Color.Transparent;
            subStatsBox.ForeColor = Color.White;
            Controls.Add(subStatsBox);

            dicePointsBox = new Label();
            dicePointsBox.Left = 870;
            dicePointsBox.Top = 590;
            dicePointsBox.Width = 150;
            dicePointsBox.Height = 60;
            dicePointsBox.BackColor = Color.Transparent;
            dicePointsBox.ForeColor = Color.White;
            dicePointsBox.Image = Properties.Resources.dices;
            dicePointsBox.ImageAlign = ContentAlignment.TopLeft;
            dicePointsBox.TextAlign = ContentAlignment.TopRight;
            dicePointsBox.Font = new Font("Microsoft Sans Serif", 27, FontStyle.Bold);
            dicePointsBox.Padding = new Padding(0, 10, 30, 0);
            Controls.Add(dicePointsBox);

            experienceBar = new ProgressBar();
            experienceBar.Location = new System.Drawing.Point(294, 739);
            experienceBar.Name = "experienceBar";
            experienceBar.Size = new System.Drawing.Size(296, 24);
            experienceBar.TabIndex = 14;
            experienceBar.Maximum = 1000;
            experienceBar.Value = GameEngine.PlayerCharacter.Experience;
            experienceBar.BackColor = ColorTranslator.FromHtml("#b0b0b1");
            experienceBar.ForeColor = ColorTranslator.FromHtml("#04252d");
            experienceBar.Style = ProgressBarStyle.Continuous;
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
                    battle.Attack((IUnit)GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
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
            if (GameEngine.Inventory != null)
            {
                GameEngine.Inventory.Show();
            }
            else
            {
                GameEngine.Inventory = new PlayerInventory();
            }
            GameEngine.Inventory.Visible = false;
            GameEngine.Inventory.ShowDialog();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            if (battle.AttackBuffUsed == true)
            {
                GameEngine.PlayerCharacter.ClearBuff("attack");
                battle.AttackBuffUsed = false;
            }
            if (battle.DefenceBuffUsed == true)
            {
                GameEngine.PlayerCharacter.ClearBuff("defence");
                battle.DefenceBuffUsed = false;
            }
            if (battle.HealthBuffUsed == true)
            {
                GameEngine.PlayerCharacter.ClearBuff("health");
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
                    GameEngine.PlayerCharacter.BonusAttackPoints += GameEngine.PlayerCharacter.CalculateSkillStats("low");
                    battle.Attack((IUnit)GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
                    GameEngine.PlayerCharacter.BonusAttackPoints -= GameEngine.PlayerCharacter.CalculateSkillStats("low");
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

        private void btnAttackSkillMed_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.CurrentTarget != null)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill2DicePoints);
                    GameEngine.PlayerCharacter.BonusAttackPoints += GameEngine.PlayerCharacter.CalculateSkillStats("medium");
                    battle.Attack((IUnit)GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
                    GameEngine.PlayerCharacter.BonusAttackPoints -= GameEngine.PlayerCharacter.CalculateSkillStats("medium");
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

        private void btnAttackSkillHigh_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.CurrentTarget != null)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill3DicePoints);
                    GameEngine.PlayerCharacter.BonusAttackPoints += GameEngine.PlayerCharacter.CalculateSkillStats("heavy");
                    battle.Attack((IUnit)GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
                    GameEngine.PlayerCharacter.BonusAttackPoints -= GameEngine.PlayerCharacter.CalculateSkillStats("heavy");
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

        private void btnAttackBuff_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn == true && battle.AttackBuffUsed == false)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackBuffDicePoints);
                    GameEngine.PlayerCharacter.CastBuff("attack");
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
                    GameEngine.PlayerCharacter.CastBuff("defence");
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
                    GameEngine.PlayerCharacter.CastBuff("health");
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
                case Pictures.Ork:
                    return Properties.Resources.orc;
                case Pictures.Skeleton:
                    return Properties.Resources.skeleton;
                case Pictures.Drake:
                    return Properties.Resources.drake;
                case Pictures.Goblin:
                    return Properties.Resources.goblin;
                case Pictures.Shade:
                    return Properties.Resources.shade;
                default:
                    //return Properties.Resources.golem;
                    throw new NoPictureException();
            }
        }

        public void RefreshStats()
        {
            this.mainStatsBox.Text = "Strength: " + GameEngine.PlayerCharacter.Strength
                              + "\n\nIntelligence: " + GameEngine.PlayerCharacter.Intelligence
                              + "\n\nDexterity: " + GameEngine.PlayerCharacter.Dexterity
                              + "\n\nVitality: " + GameEngine.PlayerCharacter.Vitality;

            this.subStatsBox.Text = "Attack: " + GameEngine.PlayerCharacter.Attack()
                              + "\n\nDefence: " + GameEngine.PlayerCharacter.Defend()
                              + "\n\nHealth: " + GameEngine.PlayerCharacter.CurrentHitPoints
                              + "\n\nLevel: " + GameEngine.PlayerCharacter.Level;

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

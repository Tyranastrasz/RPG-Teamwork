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
        private Label statsBox;

        public Battle()
        {
            InitializeComponent();

            targetBox = new Label();
            targetBox.Left = 0;
            targetBox.Top = 0;
            targetBox.Width = 100;
            targetBox.Height = 50;
            Controls.Add(targetBox);
            targetBox.Hide();

            statsBox = new Label();
            statsBox.Left = 0;
            statsBox.Top = 0;
            statsBox.Width = 100;
            statsBox.Height = 50;
            Controls.Add(statsBox);

            battle.CreateEnemies();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            DrawEnemies();
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
                    battle.Defend(); // todo
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
            box.Text = "Attack: " + enemy.Attack()
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

        private void RefreshStats()
        {
            // todo
        }

        // temp usage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

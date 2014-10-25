namespace RpgGame.Forms
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Exceptions;

    public partial class Battle : Form
    {
        private BattleManager battle = new BattleManager();

        public Label targetBox;
        private Label unitDamage;
        private Label mainStatsBox;
        private Label subStatsBox;
        private Label dicePointsBox;
        public ProgressBar experienceBar;
        public PictureBox characterPicture;

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

            unitDamage = new Label();
            unitDamage.Width = 150;
            unitDamage.Height = 70;
            unitDamage.AutoSize = true;
            unitDamage.BackColor = Color.Transparent;
            unitDamage.Font = new Font("Microsoft Sans Serif", 35, FontStyle.Bold);
            unitDamage.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(unitDamage);
            unitDamage.Hide();

            mainStatsBox = new Label();
            mainStatsBox.Left = 650;
            mainStatsBox.Top = 670;
            mainStatsBox.Width = 85;
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
            experienceBar.Location = new Point(294, 739);
            experienceBar.Name = "experienceBar";
            experienceBar.Size = new Size(296, 24);
            experienceBar.TabIndex = 14;
            experienceBar.Maximum = GameEngine.PlayerCharacter.CalculateExperience(GameEngine.PlayerCharacter.Level);
            experienceBar.Value = GameEngine.PlayerCharacter.Experience;
            experienceBar.BackColor = ColorTranslator.FromHtml("#b0b0b1");
            experienceBar.ForeColor = ColorTranslator.FromHtml("#04252d");
            experienceBar.Style = ProgressBarStyle.Continuous;
            Controls.Add(experienceBar);

            characterPicture = new PictureBox();
            characterPicture.Image = GetCharacterImage(GetCharacterClass(GameEngine.PlayerCharacter));
            characterPicture.Width = 250;
            characterPicture.Height = 250;
            characterPicture.BackColor = Color.Transparent;
            characterPicture.Left = 750;
            characterPicture.Top = 200;
            this.Controls.Add(characterPicture);

            playerName.Text = "Player:  " + GameEngine.PlayerCharacter.Name;

            battle.CreateEnemies();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            DrawEnemies();
            RefreshStats();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

            if (battle.IsPlayerTurn && battle.CurrentTarget != null && battle.CurrentTargetId > -1)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackDicePoints);
                    battle.Attack(GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
                    RefreshStats();
                    Sound.Sound.PlayAttackSound();
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.DefendDicePoints);
                    battle.Defend();
                    RefreshStats();
                    Sound.Sound.PlayDefendSound();
                }
                catch(NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            GameEngine.Inventory = new PlayerInventory();
            GameEngine.Inventory.ShowDialog();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            battle.EnemyTurn();
        }

        private void btnAttackSkillLow_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn && battle.CurrentTarget != null && battle.CurrentTargetId > -1)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill1DicePoints);
                    GameEngine.PlayerCharacter.BonusAttackPoints += GameEngine.PlayerCharacter.CalculateSkillStats("low");
                    battle.Attack(GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
                    GameEngine.PlayerCharacter.BonusAttackPoints -= GameEngine.PlayerCharacter.CalculateSkillStats("low");
                    Sound.Sound.PlayFirstSpellSound();
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
            if (battle.IsPlayerTurn && battle.CurrentTarget != null && battle.CurrentTargetId > -1)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill2DicePoints);
                    GameEngine.PlayerCharacter.BonusAttackPoints += GameEngine.PlayerCharacter.CalculateSkillStats("medium");
                    battle.Attack(GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
                    GameEngine.PlayerCharacter.BonusAttackPoints -= GameEngine.PlayerCharacter.CalculateSkillStats("medium");
                    Sound.Sound.PlaySecondSpellSound();
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
            if (battle.IsPlayerTurn && battle.CurrentTarget != null && battle.CurrentTargetId > -1)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackSkill3DicePoints);
                    GameEngine.PlayerCharacter.BonusAttackPoints += GameEngine.PlayerCharacter.CalculateSkillStats("heavy");
                    battle.Attack((IUnit)GameEngine.PlayerCharacter, (IUnit)battle.CurrentTarget);
                    GameEngine.PlayerCharacter.BonusAttackPoints -= GameEngine.PlayerCharacter.CalculateSkillStats("heavy");
                    Sound.Sound.PlayThirdSpellSound();
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
            if (battle.IsPlayerTurn && battle.IsAttackBuffUsed == false)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.AttackBuffDicePoints);
                    int attDiff = GameEngine.PlayerCharacter.Attack();
                    GameEngine.PlayerCharacter.CastBuff("attack");
                    attDiff = GameEngine.PlayerCharacter.Attack() - attDiff;
                    ShowDamageBox(attDiff, Color.Yellow, characterPicture);
                    battle.IsAttackBuffUsed = true;
                    RefreshStats();
                    Sound.Sound.PlayAttackBuffSound();
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnDefenseBuff_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn && battle.IsDefenceBuffUsed == false)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.DefenceBuffDicePoints);
                    int defDiff = GameEngine.PlayerCharacter.Defend();
                    GameEngine.PlayerCharacter.CastBuff("defence");
                    defDiff = GameEngine.PlayerCharacter.Defend() - defDiff;
                    ShowDamageBox(defDiff, Color.Blue, characterPicture);
                    battle.IsDefenceBuffUsed = true;
                    RefreshStats();
                    Sound.Sound.PlayDefenseBuffSound();
                }
                catch (NotEnoughDicePointsException)
                {
                    MessageBox.Show("You do not have enough dice points!");
                }
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (battle.IsPlayerTurn && battle.IsHealthBuffUsed == false)
            {
                try
                {
                    battle.CheckDicePoints(BattleManager.HealthDicePoints);
                    int hpDiff = GameEngine.PlayerCharacter.CurrentHitPoints;
                    GameEngine.PlayerCharacter.CastBuff("health");
                    hpDiff = GameEngine.PlayerCharacter.CurrentHitPoints - hpDiff;
                    ShowDamageBox(hpDiff, Color.LightGreen, characterPicture);
                    battle.IsHealthBuffUsed = true;
                    RefreshStats();
                    Sound.Sound.PlayHealSound();
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
            ShowTargetBox(targetBox, (IUnit)battle.EnemyList[id]);
        }

        private void DrawImages(PictureBox pictureBox, IEnemy enemy, Image image, string id)
        {
            pictureBox.Image = image;
            pictureBox.Width = 140;
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
                DrawImages(enemy.PicBox, enemy, GetImage(enemy), counter.ToString());
                counter++;
            }
        }

        public void ShowTargetBox(Label box, IUnit enemy)
        {
            box.Show();
            box.Text = "\nAttack: " + enemy.Attack()
                        + "\nDefense: " + enemy.Defend()
                        + "\nHitpoints: " + enemy.CurrentHitPoints;
        }

        private Image GetImage(IEnemy enemy)
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

        private static string GetCharacterClass(ICharacter character)
        {
            string[] characterMeta = character.ToString().Split('.');
            return characterMeta[characterMeta.Length - 1];
        }

        private Image GetCharacterImage(string characterClass)
        {
            switch (characterClass)
            {
                case "Warrior":
                    return Properties.Resources.warrior;
                case "Rogue":
                    return Properties.Resources.rogue;
                case "Mage":
                    return Properties.Resources.mage;
                default:
                    throw new NoPictureException();
            }
        }

        public void ShowDamageBox(int num, Color color, PictureBox picBox)
        {
            unitDamage.ForeColor = color;
            string prefix = "";
            if (num > 0)
            {
                prefix = "+";
            }
            unitDamage.Text = prefix + num;
            unitDamage.Left = 0;
            unitDamage.Top = 40;
            unitDamage.Parent = picBox;
            unitDamage.Show();
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

        private void empty_Click(object sender, EventArgs e)
        {
            targetBox.Hide();
        }

        // temp usage to close the form
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // This code reduces the flickering when loading the forms.
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

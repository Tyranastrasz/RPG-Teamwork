namespace RpgGame
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using RpgGame.Enemies.MeleeType;
    using RpgGame.Enemies.RangeType;
    using RpgGame.Forms;
    using RpgGame.Interfaces;
    using RpgGame.Exceptions;
    using System.Drawing;

    public class BattleManager
    {
        public const int AttackDicePoints = 2;
        public const int DefendDicePoints = 2;
        public const int AttackSkill1DicePoints = 3;
        public const int AttackSkill2DicePoints = 4;
        public const int AttackSkill3DicePoints = 6;
        public const int AttackBuffDicePoints = 3;
        public const int DefenceBuffDicePoints = 3;
        public const int HealthDicePoints = 3;

        public List<Position> enemiesPossitions = new List<Position>();

        public bool IsPlayerTurn { get; set; }
        public bool IsBattleEnd { get; set; }
        public int DicePoints { get; set; }
        
        public List<IEnemy> EnemyList { get; set; }

        public IEnemy CurrentTarget { get; set; }

        public int CurrentTargetId { get; set; }

        public int LastTurnEnemyId { get; set; }

        public bool IsAttackBuffUsed { get; set; }

        public bool IsDefenceBuffUsed { get; set; }

        public bool IsHealthBuffUsed { get; set; }

        public bool IsDefendUsed { get; set; }

        public BattleManager()
        {
            GameEngine.PlayerCharacter.CurrentHitPoints = GameEngine.PlayerCharacter.MaxHitPoints;

            this.IsPlayerTurn = true;
            this.IsBattleEnd = false;
            this.EnemyList = new List<IEnemy>();
            this.LastTurnEnemyId = -1;

            this.IsAttackBuffUsed = false;
            this.IsDefenceBuffUsed = false;
            this.IsHealthBuffUsed = false;
            this.IsDefendUsed = false;

            this.enemiesPossitions.Add(new Position(x: 40, y: 166));
            this.enemiesPossitions.Add(new Position(x: 40, y: 336));
            this.enemiesPossitions.Add(new Position(x: 40, y: 506));
            this.enemiesPossitions.Add(new Position(x: 200, y: 166));
            this.enemiesPossitions.Add(new Position(x: 200, y: 336));
            this.enemiesPossitions.Add(new Position(x: 200, y: 506));

            RollTheDice();
        }

        public void PlayerTurn()
        {
            this.IsPlayerTurn = true;
            RollTheDice();
            GameEngine.BattleScreen.RefreshStats();
        }

        public void EnemyTurn()
        {
            // use thread.sleep
            this.IsPlayerTurn = false;
            this.LastTurnEnemyId++;
            if (this.LastTurnEnemyId > this.EnemyList.Count - 1)
            {
                this.LastTurnEnemyId = 0;
            }

            try
            {
                while (this.EnemyList[this.LastTurnEnemyId].IsAlive == false)
                {
                    if (this.LastTurnEnemyId == this.EnemyList.Count - 1)
                    {
                        this.LastTurnEnemyId = 0;
                    }
                    this.LastTurnEnemyId++;
                }
                Attack((IUnit)this.EnemyList[this.LastTurnEnemyId], GameEngine.PlayerCharacter);
            }
            catch (EndBattleException)
            {
                MessageBox.Show("You have died!");
                GameEngine.BattleScreen.Close();
                GameEngine.Map.Show();
            }

            if (this.IsDefendUsed)
            {
                GameEngine.PlayerCharacter.BonusDefencePoints -= 2;
                this.IsDefendUsed = false;
            }
            if (this.IsAttackBuffUsed)
            {
                GameEngine.PlayerCharacter.ClearBuff("attack");
                this.IsAttackBuffUsed = false;
            }
            if (this.IsDefenceBuffUsed)
            {
                GameEngine.PlayerCharacter.ClearBuff("defence");
                this.IsDefenceBuffUsed = false;
            }
            if (this.IsHealthBuffUsed)
            {
                this.IsHealthBuffUsed = false;
            }

            PlayerTurn();
        }

        public void CheckBattleStatus(List<IEnemy> enemyList)
        {
            if (this.EnemyList.Count == 0 || GameEngine.PlayerCharacter.CurrentHitPoints <= 0)
            {
                this.IsBattleEnd = true;
            }
        }

        public bool CheckDicePoints(int points)
        {
            if (this.DicePoints >= points)
            {
                this.DicePoints -= points;
                return true;
            }

            throw new NotEnoughDicePointsException();
        }

        public void Attack(IUnit attacker, IUnit target)
        {
            int damage = attacker.Attack() - target.Defend();

            if (damage > 0)
            {
                target.CurrentHitPoints -= damage;
                if (this.IsPlayerTurn)
                {
                    GameEngine.BattleScreen.ShowDamageBox(-damage, Color.Red, this.CurrentTarget.PicBox);
                }
                else
                {
                    GameEngine.BattleScreen.ShowDamageBox(-damage, Color.Red, GameEngine.BattleScreen.characterPicture);
                }
            }

            if (target.CurrentHitPoints <= 0)
            {
                if (this.IsPlayerTurn)
                {
                    this.EnemyList[this.CurrentTargetId].PicBox.Hide();
                    this.EnemyList[this.CurrentTargetId].IsAlive = false;
                    GameEngine.PlayerCharacter.Experience += this.EnemyList[this.CurrentTargetId].Experience;
                    
                    if (GameEngine.PlayerCharacter.Experience >= GameEngine.BattleScreen.experienceBar.Maximum)
                    {
                        GameEngine.PlayerCharacter.Level++;
                        GameEngine.PlayerCharacter.Strength++;
                        GameEngine.PlayerCharacter.Intelligence++;
                        GameEngine.PlayerCharacter.Dexterity++;
                        GameEngine.PlayerCharacter.Vitality++;
                        GameEngine.BattleScreen.experienceBar.Maximum = GameEngine.PlayerCharacter.CalculateExperience(GameEngine.PlayerCharacter.Level);
                        GameEngine.PlayerCharacter.Experience = 0;
                        GameEngine.BattleScreen.experienceBar.Value = 0;
                    }
                    else
                    {
                        GameEngine.BattleScreen.experienceBar.Value = GameEngine.PlayerCharacter.Experience;
                    }

                    bool aliveEnemies = false;

                    foreach(IEnemy enemy in this.EnemyList) {
                        if (enemy.IsAlive)
                        {
                            aliveEnemies = true;
                            break;
                        }
                    }

                    if (aliveEnemies == false)
                    {
                        MessageBox.Show("VICTORY!");
                        GameEngine.BattleScreen.Close();
                        GameEngine.Map.Show();
                    }
                }
                else
                {
                    throw new EndBattleException();
                }
            }
        }

        public void Defend()
        {
            if (!this.IsDefendUsed)
            {
                GameEngine.PlayerCharacter.BonusDefencePoints += 2;
                this.IsDefendUsed = true;
            }
        }

        public void RollTheDice()
        {
            int[] dices = new int[2];

            Random rnd = new Random();
            dices[0] = rnd.Next(1, 7);
            dices[1] = rnd.Next(1, 7);

            this.DicePoints = dices[0] + dices[1];
        }

        public void CreateEnemies() {

            Random rnd = new Random();
            int enemiesCount = rnd.Next(2, 7);
            int meleCount = rnd.Next(0, enemiesCount + 1);
            int rangeCount = enemiesCount - meleCount;

            int possitionCounter = 0;

            for (int i = 0; i < rangeCount; i++)
            {
                int rangeType = rnd.Next(0, 3);
                IEnemy enemy = new Drake("Drake", 85, 35, 5, Pictures.Drake);
                for (int k = 0; k < rangeType; k++)
                {
                    switch (k)
                    {
                        case 0:
                            enemy = new Goblin("Goblin", 85, 35, 5, Pictures.Goblin);
                            break;
                        case 1:
                            enemy = new Shade("Shade", 85, 35, 5, Pictures.Shade);
                            break;
                        case 2:
                            enemy = new Drake("Drake", 85, 35, 5, Pictures.Drake);
                            break;
                    }
                }
                enemy.Position = this.enemiesPossitions[possitionCounter];
                this.EnemyList.Add(enemy);
                possitionCounter++;
            }

            for (int i = 0; i < meleCount; i++)
            {
                int meleType = rnd.Next(0, 3);
                IEnemy enemy = new Golem("Golem", 85, 35, 5, Pictures.Golem);
                for (int k = 0; k < meleType; k++)
                {
                    switch (k)
                    {
                        case 0:
                            enemy = new Skeleton("Skeleton", 85, 35, 5, Pictures.Skeleton);
                            break;
                        case 1:
                            enemy = new Ork("Ork", 85, 35, 5, Pictures.Ork);
                            break;
                        case 2:
                            enemy = new Drake("Drake", 85, 35, 5, Pictures.Drake);
                            break;
                    }
                }
                enemy.Position = this.enemiesPossitions[possitionCounter];
                this.EnemyList.Add(enemy);
                possitionCounter++;
            }
        }
    }
}

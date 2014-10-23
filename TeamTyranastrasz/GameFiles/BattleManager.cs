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
            try
            {
                Attack((IUnit)this.EnemyList[this.LastTurnEnemyId], GameEngine.PlayerCharacter);
            }
            catch (EndBattleException)
            {
                MessageBox.Show("You have died!");
                GameEngine.BattleScreen.Close();
                Map mapScreen = new Map();
                mapScreen.Show();
            }

            if (this.IsDefendUsed)
            {
                GameEngine.PlayerCharacter.BonusDefencePoints -= 2;
                this.IsDefendUsed = false;
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
            }

            if (target.CurrentHitPoints <= 0)
            {
                if (this.IsPlayerTurn)
                {
                    this.EnemyList[this.CurrentTargetId].PicBox.Hide();
                    this.EnemyList[this.CurrentTargetId].IsAlive = false;
                    GameEngine.PlayerCharacter.Experience += this.EnemyList[this.CurrentTargetId].Experience;
                    GameEngine.BattleScreen.experienceBar.Value = GameEngine.PlayerCharacter.Experience;
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

            IEnemy[] meleTypes =
            {
                new Skeleton("Skeleton", 85, 35, 5, Pictures.Skeleton),
                new Ork("Ork", 85, 35, 5, Pictures.Ork),
                new Golem("Golem", 85, 35, 5, Pictures.Golem)
            };

            IEnemy[] rangeTypes =
            {
                new Goblin("Goblin", 85, 35, 5, Pictures.Goblin),
                new Shade("Shade", 85, 35, 5, Pictures.Shade),
                new Drake("Drake", 85, 35, 5, Pictures.Drake)
            };

            int possitionCounter = 0;

            for (int i = 0; i < meleCount; i++)
            {
                int meleType = rnd.Next(0, meleTypes.Length);
                IEnemy enemy = meleTypes[meleType];
                enemy.Position = this.enemiesPossitions[possitionCounter];
                possitionCounter++;
                this.EnemyList.Add(enemy);
            }

            for (int i = 0; i < rangeCount; i++)
            {
                int rangeType = rnd.Next(0, rangeTypes.Length);
                IEnemy enemy = rangeTypes[rangeType];
                enemy.Position = this.enemiesPossitions[possitionCounter];
                possitionCounter++;
                this.EnemyList.Add(enemy);
            }
        }
    }
}

namespace RpgGame
{
    using System;
    using RpgGame.Interfaces;
    using System.Collections.Generic;
    using RpgGame.Player;
    using System.Threading;
    using RpgGame.Enemies.MeleeType;
    using RpgGame.Enemies.RangeType;

    public class BattleManager
    {
        public List<Position> enemiesPossitions = new List<Position>();

        public bool IsPlayerTurn { get; set; }
        public bool IsBattleEnd { get; set; }
        public int DicePoints { get; set; }

        public ICharacter Player { get; set; }
        public List<IEnemy> EnemyList { get; set; }

        public IEnemy CurrentTarget { get; set; }
        public int CurrentTargetId { get; set; }

        public int LastTurnEnemyId { get; set; }

        public BattleManager()
        {
            this.Player = GameEngine.PlayerCharacter;
            this.IsPlayerTurn = true;
            this.IsBattleEnd = false;
            this.EnemyList = new List<IEnemy>();
            this.LastTurnEnemyId = -1;

            this.enemiesPossitions.Add(new Position(20, 20));
            this.enemiesPossitions.Add(new Position(20, 170));
            this.enemiesPossitions.Add(new Position(20, 340));
            this.enemiesPossitions.Add(new Position(200, 20));
            this.enemiesPossitions.Add(new Position(200, 170));
            this.enemiesPossitions.Add(new Position(200, 340));
        }

        public void PlayerTurn()
        {
            // TODO ?
        }

        public void EnemyTurn()
        {
            // use thread.sleep
            this.IsPlayerTurn = false;
            this.LastTurnEnemyId++;
            Attack((IUnit)this.EnemyList[this.LastTurnEnemyId], (IUnit)Player);
            this.IsPlayerTurn = true;
            GameEngine.BattleScreen.debug.Text = this.Player.ToString();
        }

        public void CheckBattleStatus(List<IEnemy> enemyList)
        {
            if (this.EnemyList.Count == 0 || this.Player.CurrentHitPoints <= 0)
            {
                this.IsBattleEnd = true;
            }
        }

        public List<IEnemy> CheckForDeadEnemies(List<IEnemy> enemyList)
        {
            foreach (IEnemy enemy in this.EnemyList)
            {
                if (enemy.HitPoints <= 0)
                {
                    this.EnemyList[this.CurrentTargetId].IsAlive = false;
                }
            }

            return enemyList;
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
                if (this.IsPlayerTurn == true)
                {
                    target.PicBox.Hide();
                    this.EnemyList[this.CurrentTargetId].IsAlive = false;
                    this.Player.Experience += this.EnemyList[this.CurrentTargetId].Experience;
                }
                else
                {
                    throw new EndBattleException("You have died!");
                }
            }
        }

        public void RollTheDices()
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
            int mele = rnd.Next(0, enemiesCount + 1);
            int range = enemiesCount - mele;

            int possitionCounter = 0;

            if (this.Player.Level >= 1 && this.Player.Level <= 4)
            {
                for (int i = 0; i < mele; i++)
                {
                    IEnemy enemy = new Skeleton("Skeleton", 85, 35, 5, Pictures.Skeleton);
                    enemy.Position = this.enemiesPossitions[possitionCounter];
                    possitionCounter++;
                    this.EnemyList.Add(enemy);
                }

                for (int i = 0; i < range; i++)
                {
                    IEnemy enemy = new Goblin("Goblin", 85, 35, 5, Pictures.Goblin);
                    enemy.Position = this.enemiesPossitions[possitionCounter];
                    possitionCounter++;
                    this.EnemyList.Add(enemy);
                }
            }
            else if (this.Player.Level > 4 && this.Player.Level <= 8)
            {
                for (int i = 0; i < mele; i++)
                {
                    IEnemy enemy = new Ork("Ork", 85, 35, 5, Pictures.Ork);
                    enemy.Position = this.enemiesPossitions[possitionCounter];
                    possitionCounter++;
                    this.EnemyList.Add(enemy);
                }

                for (int i = 0; i < range; i++)
                {
                    IEnemy enemy = new Shade("Shade", 85, 35, 5, Pictures.Shade);
                    enemy.Position = this.enemiesPossitions[possitionCounter];
                    possitionCounter++;
                    this.EnemyList.Add(enemy);
                }
            }
            else if (this.Player.Level > 8 && this.Player.Level <= 10)
            {
                for (int i = 0; i < mele; i++)
                {
                    IEnemy enemy = new Golem("Golem", 85, 35, 5, Pictures.Golem);
                    enemy.Position = this.enemiesPossitions[possitionCounter];
                    possitionCounter++;
                    this.EnemyList.Add(enemy);
                }

                for (int i = 0; i < range; i++)
                {
                    IEnemy enemy = new Drake("Drake", 85, 35, 5, Pictures.Drake);
                    enemy.Position = this.enemiesPossitions[possitionCounter];
                    possitionCounter++;
                    this.EnemyList.Add(enemy);
                }
            }
        }
    }
}

namespace RpgGame
{
    using System;
    using RpgGame.Interfaces;
    using System.Collections.Generic;
    using RpgGame.Player;

    public class BattleManager
    {
        public bool playerTurn = true;
        public bool battleEnd = false;
        public int dicePoints;

        public ICharacter player;
        public List<IEnemy> enemyList = new List<IEnemy>();

        public IEnemy currentTarget;
        public int currentTargetId;

        public int lastTurnEnemyId = -1;

        public void PlayerTurn()
        {
            int[] dices = RollTheDices();
            dicePoints = dices[0] + dices[1];
        }

        public void EnemyTurn()
        {

        }

        public void CheckBattleStatus(List<IEnemy> enemyList)
        {
            if (enemyList.Count == 0 || player.CurrentHitPoints <= 0)
            {
                this.battleEnd = true;
            }
        }

        public List<IEnemy> CheckForDeadEnemies(List<IEnemy> enemyList)
        {
            foreach (IEnemy enemy in enemyList)
            {
                if (enemy.HitPoints <= 0)
                {
                    enemyList.Remove(enemy);
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
                if (this.playerTurn == true)
                {
                    target.PicBox.Hide();
                    enemyList.RemoveAt(this.currentTargetId);
                }
                else
                {
                    throw new EndBattleException("You have died!");
                }
            }
        }

        public static int[] RollTheDices()
        {
            int[] dices = new int[2];

            Random rnd = new Random();
            dices[0] = rnd.Next(1, 7);
            dices[1] = rnd.Next(1, 7);

            return dices;
        }
    }
}

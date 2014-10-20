namespace RpgGame
{
    using System;
    using RpgGame.Interfaces;
    using System.Collections.Generic;
    using RpgGame.Player;

    public static class BattleManager
    {
        public static bool playerTurn = true;
        public static bool battleEnd = false;
        public static int dicePoints;

        public static ICharacter player;
        public static IEnemy currentTarget;
        public static int currentTargetId;

        public static int lastEnemyTurn = 0;

        public static void PlayerTurn()
        {
            int[] dices = RollTheDices();
            dicePoints = dices[0] + dices[1];
        }

        public static void EnemyTurn()
        {

        }

        public static int[] RollTheDices()
        {
            int[] dices = new int[2];

            Random rnd = new Random();
            dices[0] = rnd.Next(1, 7);
            dices[1] = rnd.Next(1, 7);

            return dices;

        }

        public static void CheckBattleStatus(List<IEnemy> enemyList)
        {
            if (enemyList.Count == 0 || player.CurrentHitPoints <= 0)
            {
                battleEnd = true;
            }
        }

        public static List<IEnemy> CheckForDeadEnemies(List<IEnemy> enemyList)
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

        public static IEnemy PlayerAttack(IEnemy enemy)
        {
            int damage = player.AttackPoints - enemy.DefensePoints + enemy.HitPoints;
            player.Attack();

            if (damage <= 0)
            {
                enemy.DefensePoints = 0;
                enemy.HitPoints = 0;
            }
            else
            {
                int defDamage = player.AttackPoints - enemy.DefensePoints;
                int hpDamage = player.AttackPoints - enemy.HitPoints;

                if (defDamage <= 0)
                {
                    enemy.DefensePoints = 0;

                    if (hpDamage <= 0)
                    {
                        enemy.HitPoints = 0;
                    }
                    else
                    {
                        enemy.HitPoints = hpDamage;
                    }
                }
                else
                {
                    enemy.DefensePoints = defDamage;
                }
            }

            return enemy;
        }
    }
}

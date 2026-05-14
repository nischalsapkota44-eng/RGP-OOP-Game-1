using System;
using System.Collections.Generic;

namespace RGP_OOP_Game_1
{
    // BattleManager - orchestrates all battle logic - demonstrates ENCAPSULATION
    public class BattleManager
    {
        private Hero hero;
        private Enemy currentEnemy;
        private List<string> battleLog;
        private Random random;
        private List<Enemy> enemies;
        private int currentEnemyIndex;

        public List<string> BattleLog
        {
            get { return battleLog; }
        }

        public Hero Hero
        {
            get { return hero; }
        }

        public Enemy CurrentEnemy
        {
            get { return currentEnemy; }
        }

        public int CurrentEnemyIndex
        {
            get { return currentEnemyIndex; }
        }

        public BattleManager(Hero hero)
        {
            try
            {
                this.hero = hero;
                battleLog = new List<string>();
                random = new Random();
                enemies = new List<Enemy> { new Goblin(), new Orc(), new Dragon() };
                currentEnemyIndex = 0;
                currentEnemy = enemies[0];
                battleLog.Add($"Battle started! {hero.GetStatus()}");
                battleLog.Add($"Enemy appears: {currentEnemy.GetStatus()}");
            }
            catch (Exception ex)
            {
                battleLog.Add($"Error initializing battle: {ex.Message}");
            }
        }

        // Hero attacks enemy
        public void HeroAttack()
        {
            try
            {
                int damage = hero.AttackPower + random.Next(-3, 5);
                currentEnemy.TakeDamage(damage);
                battleLog.Add($"{hero.Name} attacks for {damage} damage!");
                battleLog.Add($"{currentEnemy.GetStatus()}");

                if (!currentEnemy.IsAlive())
                {
                    EndBattle();
                }
                else
                {
                    EnemyTurn();
                }
            }
            catch (Exception ex)
            {
                battleLog.Add($"Error during hero attack: {ex.Message}");
            }
        }

        // Hero uses special ability
        public void HeroSpecialAbility()
        {
            try
            {
                int damage = hero.SpecialAbility();
                currentEnemy.TakeDamage(damage);
                battleLog.Add($"{hero.Name} uses special ability for {damage} damage!");
                battleLog.Add($"{currentEnemy.GetStatus()}");

                if (!currentEnemy.IsAlive())
                {
                    EndBattle();
                }
                else
                {
                    EnemyTurn();
                }
            }
            catch (Exception ex)
            {
                battleLog.Add($"Error during special ability: {ex.Message}");
            }
        }

        // Enemy attacks hero
        private void EnemyTurn()
        {
            try
            {
                // Enemy randomly chooses normal attack or special ability
                int choice = random.Next(1, 3);
                int damage;

                if (choice == 1)
                {
                    damage = currentEnemy.AttackPower + random.Next(-2, 4);
                    battleLog.Add($"{currentEnemy.Name} attacks for {damage} damage!");
                }
                else
                {
                    damage = currentEnemy.SpecialAbility();
                    battleLog.Add($"{currentEnemy.Name} uses special ability for {damage} damage!");
                }

                hero.TakeDamage(damage);
                battleLog.Add($"{hero.GetStatus()}");

                if (!hero.IsAlive())
                {
                    battleLog.Add($"You were defeated by {currentEnemy.Name}!");
                }
            }
            catch (Exception ex)
            {
                battleLog.Add($"Error during enemy turn: {ex.Message}");
            }
        }

        // End current battle
        private void EndBattle()
        {
            try
            {
                battleLog.Add($"{currentEnemy.Name} defeated!");
                battleLog.Add(currentEnemy.DropLoot());

                hero.GainExperience(currentEnemy.ExperienceReward);
                battleLog.Add($"{hero.Name} gained {currentEnemy.ExperienceReward} XP!");
                battleLog.Add($"{hero.GetStatus()}");

                // Move to next enemy
                currentEnemyIndex++;
                if (currentEnemyIndex < enemies.Count)
                {
                    currentEnemy = enemies[currentEnemyIndex];
                    battleLog.Add($"\nNext enemy appears: {currentEnemy.GetStatus()}");
                }
            }
            catch (Exception ex)
            {
                battleLog.Add($"Error ending battle: {ex.Message}");
            }
        }

        public bool IsGameOver()
        {
            return !hero.IsAlive() || currentEnemyIndex >= enemies.Count;
        }

        public bool HeroWon()
        {
            return hero.IsAlive() && currentEnemyIndex >= enemies.Count;
        }
    }
}
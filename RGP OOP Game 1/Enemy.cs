using System;

namespace RGP_OOP_Game_1
{
    // Enemy inherits from Character - demonstrates INHERITANCE
    public abstract class Enemy : Character
    {
        private bool isBoss;
        private int experienceReward;
        private Random random;

        public bool IsBoss
        {
            get { return isBoss; }
            set { isBoss = value; }
        }

        public int ExperienceReward
        {
            get { return experienceReward; }
            set { experienceReward = value; }
        }

        public Enemy(string name, int maxHp, int attackPower, int defence, bool isBoss, int experienceReward)
            : base(name, maxHp, attackPower, defence)
        {
            this.isBoss = isBoss;
            this.experienceReward = experienceReward;
            random = new Random();
        }

        // Enemy attacks hero - returns damage dealt
        public int AttackHero()
        {
            try
            {
                // Random variation in attack
                int damage = AttackPower + random.Next(-2, 5);
                return Math.Max(1, damage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enemy attack error: " + ex.Message);
                return 1;
            }
        }

        // Drop loot message
        public string DropLoot()
        {
            if (isBoss)
                return $"{Name} dropped the LEGENDARY CROWN! You win!";
            else
                return $"{Name} dropped {experienceReward} XP!";
        }

        // Abstract special ability - must be overridden
        public override int SpecialAbility()
        {
            return AttackPower + random.Next(5, 15);
        }

        public override string GetStatus()
        {
            string bossTag = isBoss ? " [BOSS]" : "";
            return $"{Name}{bossTag} | HP: {HP}/{MaxHP} | ATK: {AttackPower}";
        }
    }
}
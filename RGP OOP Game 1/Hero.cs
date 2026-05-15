using System;

namespace RGP_OOP_Game_1
{
    // Hero inherits from Character - demonstrates INHERITANCE
    public abstract class Hero : Character
    {
        private int level;
        private int experience;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        // Constructor calls base class constructor
        public Hero(string name, int maxHp, int attackPower, int defence)
            : base(name, maxHp, attackPower, defence)
        {
            level = 1;
            experience = 0;
        }

        // Gain experience method
        public void GainExperience(int xp)
        {
            experience += xp;
            if (experience >= 100)
            {
                level++;
                experience = 0;
                AttackPower += 2;
                MaxHP += 10;
                HP = MaxHP;
            }
        }

        public override string GetStatus()
        {
            return $"{Name} (Lvl {level}) | HP: {HP}/{MaxHP} | ATK: {AttackPower} | DEF: {Defence}";
        }
    }
}
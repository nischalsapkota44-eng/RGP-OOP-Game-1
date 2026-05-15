using System;

namespace RGP_OOP_Game_1
{
    // Rogue inherits from Hero - demonstrates INHERITANCE and POLYMORPHISM
    public class Rogue : Hero
    {
        private bool stealthMode;
        private Random random;

        public bool StealthMode
        {
            get { return stealthMode; }
            set { stealthMode = value; }
        }

        public Rogue(string name)
            : base(name, maxHp: 110, attackPower: 20, defence: 5)
        {
            stealthMode = false;
            random = new Random();
        }

        // Override SpecialAbility - SNEAK ATTACK - demonstrates POLYMORPHISM
        public override int SpecialAbility()
        {
            try
            {
                // 40% chance of critical hit doing triple damage
                int roll = random.Next(1, 101);
                if (roll <= 40)
                {
                    int damage = AttackPower * 3;
                    stealthMode = false;
                    return damage;
                }
                else
                {
                    return AttackPower; // normal attack if sneak fails
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rogue ability error: " + ex.Message);
                return 0;
            }
        }

        public override string GetStatus()
        {
            string stealth = stealthMode ? " [IN STEALTH]" : "";
            return base.GetStatus() + stealth;
        }
    }
}
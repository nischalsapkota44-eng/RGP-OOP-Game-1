using System;

namespace RGP_OOP_Game_1
{
    // Dragon is the final BOSS - demonstrates INHERITANCE and POLYMORPHISM
    public class Dragon : Enemy
    {
        private Random random;

        public Dragon()
            : base(name: "Dragon", maxHp: 200, attackPower: 30, defence: 15, isBoss: true, experienceReward: 500)
        {
            random = new Random();
        }

        // Override SpecialAbility - FIRE BREATH - massive damage
        public override int SpecialAbility()
        {
            try
            {
                // Dragon breathes fire and deals devastating damage
                int damage = AttackPower * 2 + random.Next(20, 40);
                return damage;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dragon ability error: " + ex.Message);
                return AttackPower;
            }
        }

        public override string GetStatus()
        {
            return base.GetStatus() + " 🔥";
        }
    }
}
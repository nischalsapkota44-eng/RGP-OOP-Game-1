using System;

namespace RGP_OOP_Game_1
{
    // Orc is a strong enemy - demonstrates INHERITANCE and POLYMORPHISM
    public class Orc : Enemy
    {
        private Random random;

        public Orc()
            : base(name: "Orc", maxHp: 80, attackPower: 18, defence: 5, isBoss: false, experienceReward: 100)
        {
            random = new Random();
        }

        // Override SpecialAbility - Berserk attack
        public override int SpecialAbility()
        {
            try
            {
                // Orcs go berserk and deal massive damage
                int damage = AttackPower * 2 + random.Next(5, 15);
                return damage;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Orc ability error: " + ex.Message);
                return AttackPower;
            }
        }
    }
}
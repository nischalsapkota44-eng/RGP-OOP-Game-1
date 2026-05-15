using System;

namespace RGP_OOP_Game_1
{
    public class Goblin : Enemy
    {
        private Random random;

        public Goblin()
            : base(name: "Goblin", maxHp: 30, attackPower: 8, defence: 1, isBoss: false, experienceReward: 50)
        {
            random = new Random();
        }

        public override int SpecialAbility()
        {
            try
            {
                int roll = random.Next(1, 101);
                if (roll <= 30)
                    return 0;
                else
                    return AttackPower + 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Goblin ability error: " + ex.Message);
                return AttackPower;
            }
        }
    }
}
using System;

namespace RGP_OOP_Game_1
{
    // Mage inherits from Hero - demonstrates INHERITANCE and POLYMORPHISM
    public class Mage : Hero
    {
        private int mana;
        private int maxMana;

        public int Mana
        {
            get { return mana; }
            set { mana = Math.Max(0, value); }
        }

        public int MaxMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }

        public Mage(string name)
            : base(name, maxHp: 100, attackPower: 25, defence: 3)
        {
            maxMana = 100;
            mana = 100;
        }

        // Override SpecialAbility - FIREBALL - demonstrates POLYMORPHISM
        public override int SpecialAbility()
        {
            try
            {
                if (mana >= 30)
                {
                    mana -= 30;
                    int damage = AttackPower * 2;
                    return damage;
                }
                else
                {
                    return AttackPower; // normal attack if no mana
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mage ability error: " + ex.Message);
                return 0;
            }
        }

        public override string GetStatus()
        {
            return base.GetStatus() + $" | Mana: {mana}/{maxMana}";
        }
    }
}
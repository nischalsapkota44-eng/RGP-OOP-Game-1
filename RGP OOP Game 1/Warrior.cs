using System;

namespace RGP_OOP_Game_1
{
    // Warrior inherits from Hero - demonstrates INHERITANCE and POLYMORPHISM
    public class Warrior : Hero
    {
        private bool shieldActive;

        public Warrior(string name)
            : base(name, maxHp: 150, attackPower: 15, defence: 10)
        {
            shieldActive = false;
        }

        // Override SpecialAbility - demonstrates POLYMORPHISM
        public override int SpecialAbility()
        {
            shieldActive = true;
            Defence += 10;
            return 0; // no damage dealt, but defence increases
        }

        public bool ShieldActive
        {
            get { return shieldActive; }
            set { shieldActive = value; }
        }

        public void ResetShield()
        {
            if (shieldActive)
            {
                Defence -= 10;
                shieldActive = false;
            }
        }

        public override string GetStatus()
        {
            string shield = shieldActive ? " [SHIELD ACTIVE]" : "";
            return base.GetStatus() + shield;
        }
    }
}

using System;

namespace RGP_OOP_Game_1
{
    // Abstract base class - demonstrates ABSTRACTION and ENCAPSULATION
    public abstract class Character
    {
        // Private fields - ENCAPSULATION
        private string name;
        private int hp;
        private int maxHp;
        private int attackPower;
        private int defence;

        // Public properties to access private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = Math.Max(0, value); }
        }

        public int MaxHP
        {
            get { return maxHp; }
            set { maxHp = value; }
        }

        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        // Constructor
        public Character(string name, int maxHp, int attackPower, int defence)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
            this.attackPower = attackPower;
            this.defence = defence;
        }

        // Regular method
        public bool IsAlive()
        {
            return hp > 0;
        }

        // Take damage method
        public void TakeDamage(int damage)
        {
            try
            {
                int actualDamage = Math.Max(1, damage - defence);
                HP -= actualDamage;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error taking damage: " + ex.Message);
            }
        }

        // Abstract method - must be overridden by subclasses - POLYMORPHISM
        public abstract int SpecialAbility();

        // Virtual method - can be overridden
        public virtual string GetStatus()
        {
            return $"{name} | HP: {hp}/{maxHp} | ATK: {attackPower} | DEF: {defence}";
        }
    }
}
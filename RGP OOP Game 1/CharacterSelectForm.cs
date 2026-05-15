using System;
using System.Windows.Forms;

namespace RGP_OOP_Game_1
{
    public partial class CharacterSelectForm : Form
    {
        public CharacterSelectForm()
        {
            InitializeComponent();
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            Warrior hero = new Warrior("My Warrior");
            BattleForm battleForm = new BattleForm(hero);
            battleForm.Show();
            this.Hide();
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            Mage hero = new Mage("My Mage");
            BattleForm battleForm = new BattleForm(hero);
            battleForm.Show();
            this.Hide();
        }

        private void btnRogue_Click(object sender, EventArgs e)
        {
            Rogue hero = new Rogue("My Rogue");
            BattleForm battleForm = new BattleForm(hero);
            battleForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }
    }
}
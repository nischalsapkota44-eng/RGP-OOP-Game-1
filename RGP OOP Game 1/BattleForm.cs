using System;
using System.Windows.Forms;

namespace RGP_OOP_Game_1
{
    public partial class BattleForm : Form
    {
        private BattleManager battleManager;

        public BattleForm(Hero hero)
        {
            InitializeComponent();
            battleManager = new BattleManager(hero);
            UpdateUI();
        }

        private void UpdateUI()
        {
            try
            {
                lblHeroName.Text = battleManager.Hero.Name;
                lblHeroHP.Text = "HP: " + battleManager.Hero.HP + "/" + battleManager.Hero.MaxHP;
                progressHeroHP.Maximum = battleManager.Hero.MaxHP;
                progressHeroHP.Value = Math.Max(0, battleManager.Hero.HP);
                lblEnemyName.Text = battleManager.CurrentEnemy.Name;
                lblEnemyHP.Text = "HP: " + battleManager.CurrentEnemy.HP + "/" + battleManager.CurrentEnemy.MaxHP;
                progressEnemyHP.Maximum = battleManager.CurrentEnemy.MaxHP;
                progressEnemyHP.Value = Math.Max(0, battleManager.CurrentEnemy.HP);
                lstBattleLog.Items.Clear();
                foreach (string log in battleManager.BattleLog)
                    lstBattleLog.Items.Add(log);
                if (lstBattleLog.Items.Count > 0)
                    lstBattleLog.TopIndex = lstBattleLog.Items.Count - 1;
                if (battleManager.IsGameOver())
                {
                    btnAttack.Enabled = false;
                    btnSpecial.Enabled = false;
                    GameOverForm gameOver = new GameOverForm(
                        battleManager.HeroWon(),
                        battleManager.Hero.Name);
                    gameOver.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            battleManager.HeroAttack();
            UpdateUI();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            battleManager.HeroSpecialAbility();
            UpdateUI();
        }

        private void btnFlee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to flee?",
                "Flee Battle",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                this.Close();
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace RGP_OOP_Game_1
{
    public partial class GameOverForm : Form
    {
        private bool heroWon;
        private string heroName;

        public GameOverForm(bool heroWon, string heroName)
        {
            InitializeComponent();
            this.heroWon = heroWon;
            this.heroName = heroName;
            SetupUI();
        }

        private void SetupUI()
        {
            if (heroWon)
            {
                lblResult.Text = "VICTORY!";
                lblResult.ForeColor = System.Drawing.Color.Gold;
                lblMessage.Text = $"Congratulations {heroName}!\nYou defeated the Dragon and saved the kingdom!";
            }
            else
            {
                lblResult.Text = "DEFEAT!";
                lblResult.ForeColor = System.Drawing.Color.OrangeRed;
                lblMessage.Text = $"{heroName} has fallen in battle...\nThe Dragon reigns supreme!";
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
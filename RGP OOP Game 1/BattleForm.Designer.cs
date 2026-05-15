namespace RGP_OOP_Game_1
{
    partial class BattleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.Label lblHeroHP;
        private System.Windows.Forms.ProgressBar progressHeroHP;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.ProgressBar progressEnemyHP;
        private System.Windows.Forms.ListBox lstBattleLog;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblBattleLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeroName = new System.Windows.Forms.Label();
            this.lblHeroHP = new System.Windows.Forms.Label();
            this.progressHeroHP = new System.Windows.Forms.ProgressBar();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.progressEnemyHP = new System.Windows.Forms.ProgressBar();
            this.lstBattleLog = new System.Windows.Forms.ListBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblBattleLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblHeroName.Text = "HERO";
            this.lblHeroName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeroName.ForeColor = System.Drawing.Color.LightGreen;
            this.lblHeroName.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroName.Size = new System.Drawing.Size(200, 35);
            this.lblHeroName.Location = new System.Drawing.Point(20, 20);

            this.lblHeroHP.Text = "HP: 0/0";
            this.lblHeroHP.Font = new System.Drawing.Font("Arial", 10F);
            this.lblHeroHP.ForeColor = System.Drawing.Color.White;
            this.lblHeroHP.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroHP.Size = new System.Drawing.Size(200, 25);
            this.lblHeroHP.Location = new System.Drawing.Point(20, 55);

            this.progressHeroHP.Size = new System.Drawing.Size(200, 20);
            this.progressHeroHP.Location = new System.Drawing.Point(20, 80);
            this.progressHeroHP.ForeColor = System.Drawing.Color.LightGreen;
            this.progressHeroHP.BackColor = System.Drawing.Color.DarkGray;

            this.lblVS.Text = "VS";
            this.lblVS.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblVS.ForeColor = System.Drawing.Color.Gold;
            this.lblVS.BackColor = System.Drawing.Color.Transparent;
            this.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVS.Size = new System.Drawing.Size(80, 40);
            this.lblVS.Location = new System.Drawing.Point(360, 40);

            this.lblEnemyName.Text = "ENEMY";
            this.lblEnemyName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblEnemyName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblEnemyName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEnemyName.Size = new System.Drawing.Size(200, 35);
            this.lblEnemyName.Location = new System.Drawing.Point(580, 20);

            this.lblEnemyHP.Text = "HP: 0/0";
            this.lblEnemyHP.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEnemyHP.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHP.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEnemyHP.Size = new System.Drawing.Size(200, 25);
            this.lblEnemyHP.Location = new System.Drawing.Point(580, 55);

            this.progressEnemyHP.Size = new System.Drawing.Size(200, 20);
            this.progressEnemyHP.Location = new System.Drawing.Point(580, 80);
            this.progressEnemyHP.ForeColor = System.Drawing.Color.OrangeRed;
            this.progressEnemyHP.BackColor = System.Drawing.Color.DarkGray;

            this.lblBattleLog.Text = "BATTLE LOG";
            this.lblBattleLog.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblBattleLog.ForeColor = System.Drawing.Color.Gold;
            this.lblBattleLog.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleLog.Size = new System.Drawing.Size(760, 25);
            this.lblBattleLog.Location = new System.Drawing.Point(20, 120);

            this.lstBattleLog.Size = new System.Drawing.Size(760, 220);
            this.lstBattleLog.Location = new System.Drawing.Point(20, 148);
            this.lstBattleLog.BackColor = System.Drawing.Color.FromArgb(10, 10, 30);
            this.lstBattleLog.ForeColor = System.Drawing.Color.LightGray;
            this.lstBattleLog.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBattleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnAttack.Text = "ATTACK";
            this.btnAttack.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnAttack.ForeColor = System.Drawing.Color.White;
            this.btnAttack.BackColor = System.Drawing.Color.FromArgb(60, 120, 60);
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Size = new System.Drawing.Size(180, 50);
            this.btnAttack.Location = new System.Drawing.Point(80, 400);
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);

            this.btnSpecial.Text = "SPECIAL";
            this.btnSpecial.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnSpecial.ForeColor = System.Drawing.Color.White;
            this.btnSpecial.BackColor = System.Drawing.Color.FromArgb(60, 60, 160);
            this.btnSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecial.Size = new System.Drawing.Size(180, 50);
            this.btnSpecial.Location = new System.Drawing.Point(310, 400);
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);

            this.btnFlee.Text = "FLEE";
            this.btnFlee.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnFlee.ForeColor = System.Drawing.Color.White;
            this.btnFlee.BackColor = System.Drawing.Color.FromArgb(120, 40, 40);
            this.btnFlee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlee.Size = new System.Drawing.Size(180, 50);
            this.btnFlee.Location = new System.Drawing.Point(540, 400);
            this.btnFlee.Click += new System.EventHandler(this.btnFlee_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblHeroName);
            this.Controls.Add(this.lblHeroHP);
            this.Controls.Add(this.progressHeroHP);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.progressEnemyHP);
            this.Controls.Add(this.lblBattleLog);
            this.Controls.Add(this.lstBattleLog);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.btnFlee);
            this.Name = "BattleForm";
            this.Text = "Battle!";
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 40);
            this.ResumeLayout(false);
        }
    }
}
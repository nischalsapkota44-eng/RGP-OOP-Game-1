namespace RGP_OOP_Game_1
{
    partial class CharacterSelectForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnMage;
        private System.Windows.Forms.Button btnRogue;
        private System.Windows.Forms.Label lblWarriorDesc;
        private System.Windows.Forms.Label lblMageDesc;
        private System.Windows.Forms.Label lblRogueDesc;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnMage = new System.Windows.Forms.Button();
            this.btnRogue = new System.Windows.Forms.Button();
            this.lblWarriorDesc = new System.Windows.Forms.Label();
            this.lblMageDesc = new System.Windows.Forms.Label();
            this.lblRogueDesc = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.Text = "CHOOSE YOUR HERO";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new System.Drawing.Size(760, 60);
            this.lblTitle.Location = new System.Drawing.Point(20, 30);

            this.lblChoose.Text = "Select your character class to begin the battle!";
            this.lblChoose.Font = new System.Drawing.Font("Arial", 11F);
            this.lblChoose.ForeColor = System.Drawing.Color.LightGray;
            this.lblChoose.BackColor = System.Drawing.Color.Transparent;
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoose.Size = new System.Drawing.Size(760, 30);
            this.lblChoose.Location = new System.Drawing.Point(20, 100);

            this.btnWarrior.Text = "WARRIOR";
            this.btnWarrior.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnWarrior.ForeColor = System.Drawing.Color.White;
            this.btnWarrior.BackColor = System.Drawing.Color.FromArgb(139, 69, 19);
            this.btnWarrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrior.Size = new System.Drawing.Size(180, 55);
            this.btnWarrior.Location = new System.Drawing.Point(80, 180);
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);

            this.lblWarriorDesc.Text = "HP: 150\nAttack: 15\nDefence: 10\nSpecial: Shield Block";
            this.lblWarriorDesc.Font = new System.Drawing.Font("Arial", 10F);
            this.lblWarriorDesc.ForeColor = System.Drawing.Color.LightGray;
            this.lblWarriorDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblWarriorDesc.Size = new System.Drawing.Size(180, 100);
            this.lblWarriorDesc.Location = new System.Drawing.Point(80, 245);

            this.btnMage.Text = "MAGE";
            this.btnMage.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnMage.ForeColor = System.Drawing.Color.White;
            this.btnMage.BackColor = System.Drawing.Color.FromArgb(60, 60, 160);
            this.btnMage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMage.Size = new System.Drawing.Size(180, 55);
            this.btnMage.Location = new System.Drawing.Point(310, 180);
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);

            this.lblMageDesc.Text = "HP: 100\nAttack: 25\nDefence: 3\nSpecial: Fireball";
            this.lblMageDesc.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMageDesc.ForeColor = System.Drawing.Color.LightGray;
            this.lblMageDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblMageDesc.Size = new System.Drawing.Size(180, 100);
            this.lblMageDesc.Location = new System.Drawing.Point(310, 245);

            this.btnRogue.Text = "ROGUE";
            this.btnRogue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnRogue.ForeColor = System.Drawing.Color.White;
            this.btnRogue.BackColor = System.Drawing.Color.FromArgb(60, 100, 60);
            this.btnRogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRogue.Size = new System.Drawing.Size(180, 55);
            this.btnRogue.Location = new System.Drawing.Point(540, 180);
            this.btnRogue.Click += new System.EventHandler(this.btnRogue_Click);

            this.lblRogueDesc.Text = "HP: 110\nAttack: 20\nDefence: 5\nSpecial: Sneak Attack";
            this.lblRogueDesc.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRogueDesc.ForeColor = System.Drawing.Color.LightGray;
            this.lblRogueDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblRogueDesc.Size = new System.Drawing.Size(180, 100);
            this.lblRogueDesc.Location = new System.Drawing.Point(540, 245);

            this.btnBack.Text = "BACK";
            this.btnBack.Font = new System.Drawing.Font("Arial", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.Location = new System.Drawing.Point(20, 430);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnWarrior);
            this.Controls.Add(this.lblWarriorDesc);
            this.Controls.Add(this.btnMage);
            this.Controls.Add(this.lblMageDesc);
            this.Controls.Add(this.btnRogue);
            this.Controls.Add(this.lblRogueDesc);
            this.Controls.Add(this.btnBack);
            this.Name = "CharacterSelectForm";
            this.Text = "Choose Your Hero";
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 40);
            this.ResumeLayout(false);
        }
    }
}
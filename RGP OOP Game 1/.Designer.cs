namespace RGP_OOP_Game_1
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnQuit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.Text = "RPG BATTLE GAME";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new System.Drawing.Size(760, 80);
            this.lblTitle.Location = new System.Drawing.Point(20, 80);

            this.lblSubtitle.Text = "Choose your hero and battle through enemies to defeat the Dragon!";
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtitle.Size = new System.Drawing.Size(760, 40);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 180);

            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(60, 120, 60);
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Size = new System.Drawing.Size(200, 55);
            this.btnNewGame.Location = new System.Drawing.Point(200, 280);
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            this.btnQuit.Text = "QUIT";
            this.btnQuit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(120, 40, 40);
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Size = new System.Drawing.Size(200, 55);
            this.btnQuit.Location = new System.Drawing.Point(420, 280);
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnQuit);
            this.Name = "MainMenuForm";
            this.Text = "RPG Battle Game";
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 40);
            this.ResumeLayout(false);
        }
    }
}
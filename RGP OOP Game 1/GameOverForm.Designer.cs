namespace RGP_OOP_Game_1
{
    partial class GameOverForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblResult
            this.lblResult.Text = "VICTORY!";
            this.lblResult.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Gold;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Size = new System.Drawing.Size(760, 120);
            this.lblResult.Location = new System.Drawing.Point(20, 60);

            // lblMessage
            this.lblMessage.Text = "Congratulations!";
            this.lblMessage.Font = new System.Drawing.Font("Arial", 14F);
            this.lblMessage.ForeColor = System.Drawing.Color.LightGray;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Size = new System.Drawing.Size(760, 80);
            this.lblMessage.Location = new System.Drawing.Point(20, 200);

            // btnPlayAgain
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(60, 120, 60);
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Size = new System.Drawing.Size(200, 55);
            this.btnPlayAgain.Location = new System.Drawing.Point(180, 330);
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);

            // btnQuit
            this.btnQuit.Text = "QUIT";
            this.btnQuit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(120, 40, 40);
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Size = new System.Drawing.Size(200, 55);
            this.btnQuit.Location = new System.Drawing.Point(420, 330);
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);

            // GameOverForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnQuit);
            this.Name = "GameOverForm";
            this.Text = "Game Over";
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 40);
            this.ResumeLayout(false);
        }
    }
}
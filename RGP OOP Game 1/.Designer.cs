namespace RGP_OOP_Game_1
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "MainMenuForm";
            this.Text = "RPG Battle Game";
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 40);
            this.ResumeLayout(false);
        }
    }
}
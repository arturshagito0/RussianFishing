
namespace pp3
{
    partial class MenuSettingsSaveFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.PictureBox();
            this.closeGame = new System.Windows.Forms.PictureBox();
            this.mainMenuButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pp3.Properties.Resources.layer8;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.closeGame);
            this.panel1.Controls.Add(this.mainMenuButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 228);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::pp3.Properties.Resources.exit_d1;
            this.exitButton.Location = new System.Drawing.Point(207, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Image = global::pp3.Properties.Resources.save_d;
            this.saveButton.Location = new System.Drawing.Point(28, 53);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 29);
            this.saveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.saveButton.TabIndex = 0;
            this.saveButton.TabStop = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseEnter += new System.EventHandler(this.saveButton_MouseEnter);
            this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
            // 
            // closeGame
            // 
            this.closeGame.BackColor = System.Drawing.Color.Transparent;
            this.closeGame.Image = global::pp3.Properties.Resources.exitw_d;
            this.closeGame.Location = new System.Drawing.Point(28, 158);
            this.closeGame.Name = "closeGame";
            this.closeGame.Size = new System.Drawing.Size(200, 29);
            this.closeGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeGame.TabIndex = 2;
            this.closeGame.TabStop = false;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            this.closeGame.MouseEnter += new System.EventHandler(this.closeGame_MouseEnter);
            this.closeGame.MouseLeave += new System.EventHandler(this.closeGame_MouseLeave);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuButton.Image = global::pp3.Properties.Resources.exitm_d;
            this.mainMenuButton.Location = new System.Drawing.Point(28, 123);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(200, 29);
            this.mainMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainMenuButton.TabIndex = 3;
            this.mainMenuButton.TabStop = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            this.mainMenuButton.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.mainMenuButton.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Image = global::pp3.Properties.Resources.set_d;
            this.settingsButton.Location = new System.Drawing.Point(28, 88);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 29);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.settingsButton.TabIndex = 4;
            this.settingsButton.TabStop = false;
            this.settingsButton.MouseEnter += new System.EventHandler(this.settingsButton_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            // 
            // MenuSettingsSaveFormcs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 228);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MenuSettingsSaveFormcs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuSettingsSaveFormcs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox saveButton;
        private System.Windows.Forms.PictureBox closeGame;
        private System.Windows.Forms.PictureBox mainMenuButton;
        private System.Windows.Forms.PictureBox settingsButton;
    }
}
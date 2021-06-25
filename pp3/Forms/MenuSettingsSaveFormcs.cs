using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp3
{
    public partial class MenuSettingsSaveFormcs : Form
    {
        Player currentPlayer;
        public MenuSettingsSaveFormcs(Player player)
        {
            InitializeComponent();
            this.currentPlayer = player;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            PlayersMenuHandler.SavePlayer(currentPlayer);
        }


        #region HoverEvents
        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exit_d;
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exit_a;
        }

       

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.save_d;
        }

        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.save_a;
        }

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.set_a;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.set_d;
        }

        private void mainMenuButton_MouseLeave(object sender, EventArgs e)
        {
            mainMenuButton.Image = Properties.Resources.exitm_d;
        }

        private void mainMenuButton_MouseEnter(object sender, EventArgs e)
        {
            mainMenuButton.Image = Properties.Resources.exitm_a;
        }

        private void closeGame_MouseEnter(object sender, EventArgs e)
        {
            closeGame.Image = Properties.Resources.exitw_a;
        }

        private void closeGame_MouseLeave(object sender, EventArgs e)
        {
            closeGame.Image = Properties.Resources.exitw_d;
        }
        #endregion

        private void closeGame_Click(object sender, EventArgs e)
        {
            PlayersMenuHandler.SavePlayer(currentPlayer);
            
            Application.Exit();
        }

        public static EventHandler OnMainMenuClick;

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            currentPlayer.UnsubscribeFromPlayerEvents();
            this.Close();
            OnMainMenuClick?.Invoke(null, null);
            //new SaveForm().Show();
            
            
        }
    }
}

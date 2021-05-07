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

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exit_d;
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exit_a;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EventHandlers.SavePlayerProfile(null, currentPlayer);
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.save_d;
        }

        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.save_a;
        }
    }
}

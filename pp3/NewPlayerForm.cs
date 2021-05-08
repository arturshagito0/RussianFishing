using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace pp3
{
    public partial class NewPlayerForm : Form
    {

       
        public NewPlayerForm()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)

        {

            string dir = Application.StartupPath + @"\Profiles";

            if (Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly).Select(Path.GetFileName).ToList().Contains(textBox1.Text + ".pp3profile"))
            {
                MessageBox.Show("Player with such name exists" );

            }

            else if ((textBox1.Text == "")) {
                MessageBox.Show("Please enter a name");
            }

            else
            {
               
                Player newPlayer = new Player(textBox1.Text);


                PlayersMenuHandler.SavePlayer(newPlayer);


                EventHandlers.NewPlayerCreated?.Invoke(null, null);

                exitButton_Click(null, null);
            }
                
                
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

        private void startGame_MouseEnter(object sender, EventArgs e)
        {
            startGame.Image = Properties.Resources.start_a;
        }

        private void startGame_MouseLeave(object sender, EventArgs e)
        {
            startGame.Image = Properties.Resources.start_d;
        }

        #endregion 

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

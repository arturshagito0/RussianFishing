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
using System.Runtime.Serialization.Formatters.Binary;

namespace pp3
{
    public partial class SaveForm : Form
    {
        private Player selectedPlayer;
        private List<Player> allPlayers = new List<Player>();
        Form newPlayerForm = new NewPlayerForm();
        PlayersMenuHandler handler;
        public SaveForm()
        {
            
            InitializeComponent();
            handler = new PlayersMenuHandler(dataGridView1);



            if (Directory.GetFiles(Application.StartupPath + @"\Profiles", "*", SearchOption.TopDirectoryOnly).Length == 0)
            {
                
                newPlayerForm.Show();
                newPlayerForm.BringToFront();
            }

            handler.ShowAllPlayers();

           // EventHandlers.NewPlayerCreated += UpdatePlayers;
            //UpdatePlayers(null, null);
        }

       

        #region HoverEvents
        private void loadButton_MouseEnter(object sender, EventArgs e)
        {
            loadButton.Image = Properties.Resources.load_a;
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.rem_a;
        }

        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.create_a;
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.create_d;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.rem_d;
        }

        private void loadButton_MouseLeave(object sender, EventArgs e)
        {
            loadButton.Image = Properties.Resources.load_d;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exit_d;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.exit_a;
        }

        #endregion

        private void loadButton_Click(object sender, EventArgs e)
        {


            new MainForm(selectedPlayer).Show();
            
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.allPlayers.ForEach(f => MessageBox.Show(f.player_name));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newPlayerForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)dataGridView1.CurrentRow.DataBoundItem;
            MessageBox.Show(selectedPlayer.money.ToString());
            
        }
    }
}

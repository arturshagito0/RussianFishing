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
        MainForm mf;
        Form newPlayerForm = new NewPlayerForm();
        PlayersMenuHandler handler;
        bool mainFormInitialized = false;
        public SaveForm()
        {
            
            InitializeComponent();

            handler = new PlayersMenuHandler(dataGridView1);

            MenuSettingsSaveFormcs.OnMainMenuClick += ShowSaveMenu;
           



            if (Directory.GetFiles(Application.StartupPath + @"\Profiles", "*", SearchOption.TopDirectoryOnly).Length == 0)
            {
                
                newPlayerForm.Show();
                newPlayerForm.BringToFront();
            }

            else
            {
                //dataGridView1_Click(null, null);
            }

            handler.ShowAllPlayers();
            

           // EventHandlers.NewPlayerCreated += UpdatePlayers;
            //UpdatePlayers(null, null);
        }

        private void ShowSaveMenu(object sender, EventArgs e)
        {
            this.Show();
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

            //if (!mainFormInitialized)
            //{
            //    mf = new MainForm(selectedPlayer);
            //    mainFormInitialized = true;
            //}

            //else
            //{
            //    mf.currentPlayer = this.selectedPlayer;
            //    mf.Update();
            //}

            selectedPlayer.SubscribeToPlayerEvents();

            mf = new MainForm(selectedPlayer);
            mf.Show();
            this.Hide();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows.Count.ToString());
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
            

            

           
            
        }
    }
}

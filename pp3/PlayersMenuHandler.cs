using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace pp3
{
    public  class PlayersMenuHandler
    {
        


        private string directory = Application.StartupPath + @"\Profiles";
        private List<Player> allPlayers = new List<Player>();
        private DataGridView datagrid;
        
        public PlayersMenuHandler(DataGridView datagrid)
        {
            EventHandlers.NewPlayerCreated += UpdatePlayers;
            this.datagrid = datagrid;
        }

        private void UpdatePlayers(object sender, EventArgs e)
        {
            ShowAllPlayers();
        }

        private List<Player> GetAllSavedPlayers()
        {

            string[] playerNames = Directory.GetFiles(directory, "*", SearchOption.TopDirectoryOnly);

        
            foreach (string player in playerNames)
            {
                Stream str = new FileStream(player, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Player loadedPlayer = (Player)formatter.Deserialize(str);

                if (!this.allPlayers.Select(p => p.player_name).Contains(loadedPlayer.player_name))
                {
                    MessageBox.Show("Added new plauer");
                    //this.allPlayers.Add(new Player(loadedPlayer.player_name));
                    this.allPlayers.Add(Player.copyPlayer(loadedPlayer));
                }


            }

            return this.allPlayers;
            
        }

        public void ShowAllPlayers()
        {

            GetAllSavedPlayers();

            datagrid.DataSource = allPlayers;
            datagrid.AutoGenerateColumns = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.Columns.Clear();

            if (datagrid.Columns.Count == 0)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.Name = "Игрок";
                column.DataPropertyName = "player_name";
                datagrid.Columns.Add(column);
            }
        }

        public static void SavePlayer(Player player)
        {
            string pathToPlayer = Application.StartupPath + @"\Profiles" + $@"\{player.player_name}.pp3profile";

            if (File.Exists(pathToPlayer))
            {
                File.Delete(pathToPlayer);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            MessageBox.Show($"{player.money}    {player.player_name}  { player.currentBase.displayName } ");
            
            Stream playerStream = new FileStream(pathToPlayer, FileMode.Create, FileAccess.Write);

            formatter.Serialize(playerStream, player);
            playerStream.Close();

            


        }

        


        
    }

    
}

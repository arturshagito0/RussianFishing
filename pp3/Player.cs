



using System;

namespace pp3
{
    [Serializable]
    public class Player
    {

        private int id { get; set; }
        private string player_name { get; set; }
        private int rank { get; set; } = 0;



        public Base currentBase { get; set; } 
        Location currentLocation { get; set; }

        public Inventory playerInventory { get; set; }
        public Backpack backpack { get; set; }

        public long money { get; set; } = 2000000000;
        public int karma { get; set; } = 0;






        public Player(string player_name)
        {
            this.player_name = player_name;
            playerInventory = new Inventory();
            backpack = new Backpack();
            EventHandlers.OnItemBought += PlayerBuysSomething;
            EventHandlers.ItemToBeAdded += PlayerBoughtItem;
            

        }

        private void PlayerBoughtItem(object sender, Object e)
        {
            this.playerInventory.addItem(e);
        }

        public void PlayerBuysSomething(object sender, int deducted)
        {
            this.money -= deducted;
        }



        




    }
}

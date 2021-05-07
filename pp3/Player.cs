



using System;
using System.Windows.Forms;

namespace pp3
{
    [Serializable]
    public class Player
    {

        private int id { get; set; }
        public string player_name { get; set; }
        public int rank { get; set; } = 50;



        public Base currentBase { get; set; } = ObjectInitializer.getDefaultBase();
        Location currentLocation { get; set; }

        public Inventory playerInventory { get; set; }
        public Backpack backpack { get; set; }

        public long money { get; set; } = 2200000000;
        public int karma { get; set; } = 30000;

        public Player()
        {
            EventHandlers.OnItemBought += PlayerBuysSomething;
            EventHandlers.ItemToBeAdded += PlayerBoughtItem;
            EventHandlers.OnTravelToAnotherBase += TravelToAnotherBase;
        }
        public static Player copyPlayer(Player other)
        {
            return new Player
            {
                id = other.id,
                player_name = other.player_name,
                rank = other.rank,
                currentBase = other.currentBase,
                currentLocation = other.currentLocation,
                playerInventory = other.playerInventory,
                backpack = other.backpack,
                money = other.money,
                karma = other.karma


                
        };

        }



        public Player(string player_name)
        {
            this.player_name = player_name;
            playerInventory = new Inventory();
            backpack = new Backpack();
            EventHandlers.OnItemBought += PlayerBuysSomething;
            EventHandlers.ItemToBeAdded += PlayerBoughtItem;
            EventHandlers.OnTravelToAnotherBase += TravelToAnotherBase;

            
            

        }

        private void TravelToAnotherBase(object sender, Base e)
        {
            this.currentBase = e;
        }

        private void PlayerBoughtItem(object sender, GameObject item)
        {
            if (this.playerInventory.count > this.playerInventory.capacity)
            {

                EventHandlers.OnCannotBeBought?.Invoke(this, "Inventory is Full!");


            }

            else if (item.price > this.money)
            {

                EventHandlers.OnCannotBeBought?.Invoke(this, "Not enough money!");


            }

            else
            {
                //MessageBox.Show(item.GetType().BaseType.Name + "   " + typeof(InventoryObject).ToString());

                if (item.GetType().BaseType == typeof(InventoryObject))
                {
                    this.playerInventory.addItem((InventoryObject) item);
                    
                }

                else if (item.GetType().BaseType == typeof(BackpackObject))
                {
                    this.backpack.addItem((BackpackObject) item);
                   
                }


                this.money -= item.price;

                //EventHandlers.OnItemBought(null, item.price);
                EventHandlers.OnCanBeBought(null, true);
            }
        }

        public void PlayerBuysSomething(object sender, int deducted)
        {
          
            this.money -= deducted;
        }



        




    }
}

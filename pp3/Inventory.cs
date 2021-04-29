using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pp3
{
    public class Inventory
    {

        public int capacity = 100;
        private List<Object> items = new List<Object>();
        public int count = 0;
        

        public void addItem(Object item, Player player)
        {
            if (this.count > this.capacity)
            {
      
                OnCannotBeBought?.Invoke(this, "Inventory is Full!");
               
                
            }

            else if (item.getPrice() > player.money)
            {
               
              OnCannotBeBought?.Invoke(this, "Not enough money!");
              
                
            }

            else
            {
                items.Add(item);
                count += 1;
                player.money -= item.getPrice();
                OnCanBeBought(null, null);
            }
           


        }

        public static EventHandler<String> OnCannotBeBought;
        public static EventHandler OnCanBeBought;

       

    }
}

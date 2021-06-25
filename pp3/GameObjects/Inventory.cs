using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pp3
{
    [Serializable]
    public class Inventory
    {

        public int capacity = 100;
        private List<InventoryObject> items = new List<InventoryObject>();
        public int count = 0;
        

        public void addItem(InventoryObject item)
        {

            this.items.Add(item);
            this.count += 1;
         
        }

        
        

       

    }
}

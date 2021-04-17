using System.Collections.Generic;

namespace pp3
{
    public class Inventory
    {

        public int capacity = 100;
        private List<Object> items = new List<Object>();
        public int count = 0;
        

        public void addItem(Object item)
        {
            items.Add(item);
            count += 1;
        }

       

    }
}

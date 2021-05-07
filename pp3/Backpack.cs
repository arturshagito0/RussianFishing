using System;
using System.Collections.Generic;

namespace pp3
{
    [Serializable]
    public class Backpack
    {
        private List<BackpackObject> items = new List<BackpackObject>();
        private int capacity { get; set; } = 150;
        public int count { get; set; } = 0;

        public void addItem(BackpackObject obj)
        {
            items.Add(obj);
            count += 1;
        }
    }
}

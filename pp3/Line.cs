
using System;

namespace pp3
{
    [Serializable]
    class Line : InventoryObject
    {
        private int id { get; set; }
        private string name { get; set; }
        private int maxWeight { get; set; }
        private int length { get; set; } = 150;

        public override int price { get; set; }

       

        
    }
}

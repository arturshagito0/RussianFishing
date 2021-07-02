using System.Collections.Generic;
using System;
using System.Drawing;

namespace pp3
{
    [Serializable]
    public class Rod : InventoryObject
    {
        public enum ROD_TYPE
        {
            POPLAVOK,
            SPINNING
        }

        

        public bool unique { get; } = false;

        private ROD_TYPE type { get; set; } = ROD_TYPE.POPLAVOK;
        public Image rodImage { get; set; }
        public string rodName { get; set; }
        public int maxWeight { get; set; }
        public override int price { get; set; }

        public Image icon { get; set; }

        public int condition { get; set; }
        public Reel installedReel { get; set; }
        public Line installedLine { get; set; }
        public Hook installedHook { get; set; }
        public Bait installedBait { get; set; }




        public bool getUniqueness()
        {
            return unique;
        }
        public ROD_TYPE getRodType()
        {
            return type;
        }

        public Rod(string name, int maxWeight, int price, ROD_TYPE type, bool unique, Image icon, Image rodImage)
        {
            this.rodName = name;
            this.icon = icon;
            this.maxWeight = maxWeight;
            this.price = price;
            this.type = type;
            this.unique = unique;
            this.rodImage = rodImage;
        }

       

        

        
    }


}

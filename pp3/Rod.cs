using System.Collections.Generic;

namespace pp3
{
    public class Rod : InventoryObject
    {
        public enum ROD_TYPE
        {
            POPLAVOK,
            SPINNING
        }

        protected List<Rod> gameRods = new List<Rod>();

        public bool unique { get; } = false;

        private ROD_TYPE type { get; set; } = ROD_TYPE.POPLAVOK;
        private int id { get; set; }
        public string rodName { get; set; }
        public int maxWeight { get; set; }
        public override int price { get; set; }

        public bool getUniqueness()
        {
            return unique;
        }
        public ROD_TYPE getRodType()
        {
            return type;
        }

        public Rod(string name, int maxWeight, int price, ROD_TYPE type, bool unique)
        {
            this.rodName = name;

            this.maxWeight = maxWeight;
            this.price = price;
            this.type = type;
            this.unique = unique;
        }

       

        

        
    }


}

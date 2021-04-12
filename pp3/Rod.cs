using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp3
{
    public class Rod
    {
        public enum ROD_TYPE
        {
            POPLAVOK,
            SPINNING
        }

        private List<Rod> gameRods;

        private ROD_TYPE type { get; set; } = ROD_TYPE.POPLAVOK;
        private int id { get; set; }
        public string name { get; set; }
        public int maxWeight { get; set; }
        public double price { get; set; }


        public ROD_TYPE getRodType()
        {
            return type;
        }

        public Rod(string name, int maxWeight, double price, ROD_TYPE type )
        {
            this.name = name;
            
            this.maxWeight = maxWeight;
            this.price = price;
            this.type = type;
        }

        public static void initialize()
        {

        }


    }

   
}

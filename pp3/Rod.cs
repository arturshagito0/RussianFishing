using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pp3
{
    public class Rod
    {
        public enum ROD_TYPE
        {
            POPLAVOK,
            SPINNING
        }

        protected List<Rod> gameRods = new List<Rod>();

        private ROD_TYPE type { get; set; } = ROD_TYPE.POPLAVOK;
        private int id { get; set; }
        public string rodName { get; set; }
        public int maxWeight { get; set; }
        public int price { get; set; }


        public ROD_TYPE getRodType()
        {
            return type;
        }

        public Rod(string name, int maxWeight, int price, ROD_TYPE type )
        {
            this.rodName = name;
            
            this.maxWeight = maxWeight;
            this.price = price;
            this.type = type;
        }

        public void initializeRods()
        {
            

        }

        public List<Rod> getAllRods()
        {
            return this.gameRods;
        }


    }

   
}

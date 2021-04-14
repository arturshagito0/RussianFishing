using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp3
{
    

    class GameRods
    {
        private List<Rod> gamerRods;

        public GameRods()
        {
            gamerRods = new List<Rod>();
        }

        public void InitializeAllRods()
        {
            Database1DataSet1TableAdapters.RodTableTableAdapter adapter = new Database1DataSet1TableAdapters.RodTableTableAdapter();
            foreach (System.Data.DataRow rod in adapter.GetData().Rows)
            {

                int price = (int)rod["price"];
                int maxWeight = (int)rod["maxWeight"];
                string name = rod["name"].ToString();
                Rod.ROD_TYPE ty = (Rod.ROD_TYPE)(Enum.Parse(typeof(Rod.ROD_TYPE), rod["type"].ToString()));
                bool unique = (bool)rod["isUnique"];

                gamerRods.Add(new Rod(name, maxWeight, price, ty, unique));

            }
        }

        public List<Rod> getAllRods()
        {
            return this.gamerRods;
        }



    }
}

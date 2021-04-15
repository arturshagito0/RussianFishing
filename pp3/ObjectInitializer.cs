using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp3
{
    

    class ObjectInitializer
    {
        private List<Rod> gamerRods;
        private List<Reel> gameReels;
        private List<Line> gameLines;
        

        public ObjectInitializer()
        {
            gamerRods = new List<Rod>();
            gameReels = new List<Reel>();
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

        public void InitializeAllReels()
        {
            Database1DataSet1TableAdapters.ReelTableTableAdapter adapter = new Database1DataSet1TableAdapters.ReelTableTableAdapter();

            foreach (System.Data.DataRow reel in adapter.GetData().Rows)
            {
                
                int price = (int) reel["price"];
                int power = (int)reel["power"];
                string name = (string)reel["name"];
                bool unique = (bool)reel["unique"];
                
                gameReels.Add(new Reel(name, power, price, unique));
            }

        }



        public List<Reel> getAllReels()
        {
            return this.gameReels;
        }

        public List<Rod> getAllRods()
        {
            return this.gamerRods;
        }



    }
}

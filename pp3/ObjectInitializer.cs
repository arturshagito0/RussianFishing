using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pp3
{

    public static class ObjectInitializer
    {
        
        public static List<Rod> InitializeAllRods()
        {
            List<Rod> gamerRods = new List<Rod>();
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

            return gamerRods;
        }

        public static List<Reel> InitializeAllReels()
        {
            List<Reel> gameReels = new List<Reel>();
            Database1DataSet1TableAdapters.ReelTableTableAdapter adapter = new Database1DataSet1TableAdapters.ReelTableTableAdapter();

            foreach (System.Data.DataRow reel in adapter.GetData().Rows)
            {

                int price = (int)reel["price"];
                int power = (int)reel["power"];
                string name = (string)reel["name"];
                bool unique = (bool)reel["unique"];

                gameReels.Add(new Reel(name, power, price, unique));
            }

            return gameReels;

        }

        public static List<Base> InitializeAllMaps()
        {
            List<Base> bases = new List<Base>();


            Database1DataSet1TableAdapters.MapsTableAdapter adapter = new Database1DataSet1TableAdapters.MapsTableAdapter();

            foreach (System.Data.DataRow map in adapter.GetData().Rows)

            {

                Database1DataSet1TableAdapters.LocationTableAdapter locAdapter = new  Database1DataSet1TableAdapters.LocationTableAdapter();

                List<Location> locs = new List<Location>();

                foreach (System.Data.DataRow loc in locAdapter.GetByBaseID((int)map["ID"]).Rows)
                {

                    string path = Application.StartupPath + @"\Locations\" + ((string)loc["Image"]).Remove(0, 12);
                    
                    Location l = new Location
                    {
                        locationNumer = (int)loc["Location Number"],
                        displayName = (string)loc["Display Name"],
                        locationImage = Image.FromFile(path)


                    };

                    locs.Add(l);

                }


                Base newBase = new Base
                {
                    id = (int)map["ID"],
                    displayName = (string)map["Display name"],
                    mapName = (string)map["Map name"],
                    rank = (int)map["Rank"],
                    karma = (int)map["Karma"],
                    price = (int)map["Price"],
                    locations = locs

                   
                };

                bases.Add(newBase);
            }



            MessageBox.Show("Done!");
                return bases;
        }

    }
}

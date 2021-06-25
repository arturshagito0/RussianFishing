using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pp3
{

    

    public class ObjectInitializer
    {


        public List<Rod> Rods { get; set; }
        public List<Reel> Reels { get; set; }
        public List<Base> Maps { get; set; }

        public static Base getDefaultBase()
        {
           return InitializeAllMaps().Find(e => e.mapName == "houm");
        }


        public ObjectInitializer()
        {
            EventHandlers.OnTravelToAnotherBase += InitializeMapLocations;
            EventHandlers.ClearOutBase += ClearOutBase;
            this.Rods = InitializeAllRods();
            this.Reels = InitializeAllReels();
           this.Maps = InitializeAllMaps();
            //this.Maps = new List<Base>();
        }


        private static List<Rod> InitializeAllRods()
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

        private static List<Reel> InitializeAllReels()
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

        private static List<Base> InitializeAllMaps()
        {
            List<Base> bases = new List<Base>();


            Database1DataSet1TableAdapters.MapsTableAdapter adapter = new Database1DataSet1TableAdapters.MapsTableAdapter();

            foreach (System.Data.DataRow map in adapter.GetData().Rows)

            {

               
                Base newBase = new Base
                {
                    id = (int)map["ID"],
                    displayName = (string)map["Display name"],
                    mapName = (string)map["Map name"],
                    rank = (int)map["Rank"],
                    karma = (int)map["Karma"],
                    price = (int)map["Price"],
                    locations = new List<Location>(),
                    indexImage = Image.FromFile(Application.StartupPath + @"\Locations\" + (string)map["Map name"] + @"\index.jpg"),
                    deselectedIcon = Image.FromFile(Application.StartupPath + @"\maps\" + $"{(string)map["Map name"]}_d.png"),
                    selectedIcon = Image.FromFile(Application.StartupPath + @"\maps\" + $"{(string)map["Map name"]}_a.png")

                };

                bases.Add(newBase);
            }



            
                return bases;
        }

        private void InitializeMapLocations(object sender, Base map)
        {
            Database1DataSet1TableAdapters.LocationTableAdapter locAdapter = new Database1DataSet1TableAdapters.LocationTableAdapter();



            if (!(map.isInitialized))
            {
                MessageBox.Show(map.locations.Count.ToString());


                foreach (System.Data.DataRow location in locAdapter.GetByBaseID(map.id))

                    {

                        int locNo = (int)location["Location Number"];
                        Location newLocation = new Location
                        {
                            id = (int)location["ID"],
                            displayName = (string)location["Display Name"],
                            locationNumber = locNo,
                            locationImage = Image.FromFile(Application.StartupPath + @"\Locations\" + map.mapName + $@"\Loc{locNo}" + @"\Scene.jpg")
                        };

                        map.locations.Add(newLocation);

                    }

                map.isInitialized = true;
            }

            
        }

        private void ClearOutBase(object sender, Base map)
        {
            map.isInitialized = false;
            map.locations.Clear();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pp3
{
    public class Base
    {
        public int id { get; set; }
        public string displayName { get; set; }
        public string mapName {get; set;}

        public int rank { get; set; }

        public int karma { get; set; }

        public int price { get; set; }

        public List<Location> locations { get; set;}
        public Image indexImage { get;  set; }

        public Base(int id, string displayName, string mapName, int rank, int karma, int price, List<Location> locations, Image index)
        {
            this.id = id;
            this.displayName = displayName;
            this.mapName = mapName;
            this.rank = rank;
            this.karma = karma;
            this.price = price;
            this.locations = locations;
            this.indexImage = index;
            
        }

        public Base()
        {

        }


    }
}

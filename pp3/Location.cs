using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace pp3
{
    public class Location
    {
        public int id { get; set; }
        
        public string displayName { get; set; }
        public Image locationImage { get; set; }

        public int locationNumber { get; set; }

        public Location() { }

    }
}

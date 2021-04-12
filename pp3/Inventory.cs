using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp3
{
    class Inventory
    {

        private int capacity;
        private List<Rod> rods;
        private List<Reel> reels;
        private List<Line> lines;

        public void addRod(Rod rod)
        {
            rods.Add(rod);
        }

        public void addReel(Reel reel)
        {
            reels.Add(reel);
        }

        public void addLine(Line line)
        {
            lines.Add(line);
        }

    }
}

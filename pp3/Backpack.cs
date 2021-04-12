using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp3
{
    class Backpack
    {
        private List<Object> items;

        public void addItem(Object obj)
        {
            items.Add(obj);
        }
    }
}

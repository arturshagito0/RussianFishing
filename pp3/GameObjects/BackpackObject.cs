using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp3
{
    [Serializable]
    public abstract class BackpackObject : GameObject
    {
        public abstract int price { get; set; }

    }
}

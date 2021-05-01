using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp3
{
    public static class EventHandlers
    {

        public static EventHandler<GameObject> ItemToBeAdded;
        public static EventHandler<String> OnCannotBeBought;
        public static EventHandler<bool> OnCanBeBought;
        public static EventHandler OnButtonClickSound;
        public static EventHandler OnMapButtonClick;
        public static EventHandler<int> OnItemBought;
        public static EventHandler<Base> OnTravelToAnotherBase;
        public static EventHandler<Base> ClearOutBase;

        
    }


}

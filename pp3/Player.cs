﻿



using System;

namespace pp3
{
    [Serializable]
    public class Player
    {

        private int id { get; set; }
        private string player_name { get; set; }
        private int rank { get; set; } = 0;



        public Base currentBase { get; set; } 
        Location currentLocation { get; set; }

        public Inventory playerInventory;
        public Backpack backpack;

        public long money { get; set; } = 2000000000;
        public int karma { get; set; } = 0;

        public Player(string player_name)
        {
            this.player_name = player_name;
            playerInventory = new Inventory();
            backpack = new Backpack();
            
        }

        




    }
}

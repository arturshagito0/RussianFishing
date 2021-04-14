﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pp3
{
    public class Rod
    {
        public enum ROD_TYPE
        {
            POPLAVOK,
            SPINNING
        }

        protected List<Rod> gameRods = new List<Rod>();

        private bool unique { get;  } = false;

        private ROD_TYPE type { get; set; } = ROD_TYPE.POPLAVOK;
        private int id { get; set; }
        public string rodName { get; set; }
        public int maxWeight { get; set; }
        public int price { get; set; }

        public bool getUniqueness()
        {
            return unique;
        }
        public ROD_TYPE getRodType()
        {
            return type;
        }

        public Rod(string name, int maxWeight, int price, ROD_TYPE type, bool unique )
        {
            this.rodName = name;
            
            this.maxWeight = maxWeight;
            this.price = price;
            this.type = type;
            this.unique = unique;
        }

        public void initializeRods()
        {
            

        }

        public List<Rod> getAllRods()
        {
            return this.gameRods;
        }


    }

   
}

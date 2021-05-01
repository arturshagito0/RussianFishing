namespace pp3
{
    class Potion : BackpackObject
    {
        enum PotionKind
        {
            LUCK, STRENGTH, WISDOM, LEVEL_INCREASE, FRESH, MASTER, SUPER_LUCK, TREASURE, WHALE
        }

        public override int price { get; set; }
        private string name;
        private int id;

       
    }
}

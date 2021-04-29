namespace pp3
{
    class Potion : Object
    {
        enum PotionKind
        {
            LUCK, STRENGTH, WISDOM, LEVEL_INCREASE, FRESH, MASTER, SUPER_LUCK, TREASURE, WHALE
        }

        public int price { get; set; }
        private string name;
        private int id;

        int Object.getPrice()
        {
            return this.price;
        }
    }
}

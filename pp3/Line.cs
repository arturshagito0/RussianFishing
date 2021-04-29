namespace pp3
{
    class Line : Object
    {
        private int id { get; set; }
        private string name { get; set; }
        private int maxWeight { get; set; }
        private int length { get; set; } = 150;

        private int price { get; set; }

        int Object.getPrice()
        {
            return this.price;
        }
    }
}

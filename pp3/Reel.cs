namespace pp3
{
    public class Reel : BackpackObject
    {
        public int id;
        public string name { get; set; }
        public int power { get; set; }
        public bool unique { get; set; }

        public override int price { get; set; }

        public Reel(string name, int power, int price, bool unique)
        {

            this.name = name;
            this.power = power;
            this.unique = unique;
            this.price = price;

        }

     
       

     
    }
}

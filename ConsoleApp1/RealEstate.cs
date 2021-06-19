namespace ConsoleApp1
{
    class RealEstate
    {
        public RealEstate(string estateType, double price, double size, string city)
        {
            this.estateType = estateType;
            this.price = price;
            this.size = size;
            this.city = city;
        }

        public string estateType { get; }
        public double price { get; }
        public double size { get; }
        public string city { get; }

        public override string ToString()
        {
            string str = "city " + this.city + " kaina " + this.price;
            return str;

        }

    }
}

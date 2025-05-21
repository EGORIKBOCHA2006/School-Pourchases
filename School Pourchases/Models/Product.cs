namespace Production
{
    public class Product
    {
        public int IdType { get; set; }
        public string ImageSource { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Product other)
                return other.Id==this.Id;
            else return false;  
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    /*
    public class Monitor : Product
    {
        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public Monitor(string name, int price, int width, int height) : base(name, price)
        {
            this.Width = width;
            this.Height = height;

        }
        public Monitor(string name, int price) : this(name, price, 1920, 1080) { }

        public override void PrintInfo()
        {
     
            base.PrintInfo();
            Console.WriteLine($"Разрешение: {Width}X{Height}");
        }

        
        public void CapitaliseFirstLetter()
        {
            Name = Name[0].ToString().ToUpper() + Name[1..].ToLower(); 
        }
    }*/
}

namespace Production
{
    public class Product
    {
        private int _idType;

        public int IdType
        {
            get { return _idType; }
            set { _idType = value; }
        }
        private string _imageSource;

        public string ImageSource
        {
            get { return _imageSource; }
            set { _imageSource = value; }
        }


        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string? _name;

        public string Name
        {
            get => _name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value)) { _name = value; }
                else
                {
                    _name = "N/D";
                }
            }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        virtual public void PrintInfo()
        {
            Console.WriteLine($"Товар: {Name}\nЦена: {Price}");
        }


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
    }
}

namespace Production
{
    public abstract class Product
    {
        private int _price;

        public int Price
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

        virtual public void PrintInfo()
        {
            Console.WriteLine($"Товар: {Name}\nЦена: {Price}");
        }

        public abstract IEnumerable<object> GetObjectFields();

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
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

        public override List<object> GetObjectFields()
        {
            return new List<object> { Price, Name, Width, Height };
        }
        
        public void CapitaliseFirstLetter()
        {
            Name = Name[0].ToString().ToUpper() + Name[1..].ToLower(); 
        }
    }
}

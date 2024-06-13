using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    /// <summary>
    /// Represents a refrigerator
    /// </summary>
    internal class Refrigerator : Appliance
    {
        /// <summary>
        /// Field that holds number of fridge doors
        /// </summary>
        private readonly short _doors;
        /// <summary>
        /// Width of fridge
        /// </summary>
        private readonly int _width;
        /// <summary>
        /// Height of fridge
        /// </summary>
        private readonly int _height;

        public const short Door1 = 1;
        public const short Door2 = 2;
        public const short Door3 = 3;
        public const short Door4 = 4;


        /// <summary>
        /// Property for doors
        /// </summary>
        public short Doors
        {
            get { return _doors; }
        }

        /// <summary>
        /// Property for width
        /// </summary>
        public int Width
        {
            get { return _width; }
        }

        /// <summary>
        /// Property for height
        /// </summary>
        public int Height
        {
            get { return _height; }
        }


        public string NumberOfDoors
        {
            get
            {
                switch (_doors)
                {
                    case Door1:
                        return "One Door";
                    case Door2:
                        return "Two Doors";
                    case Door3:
                        return "Three Doors";
                    case Door4:
                        return "Four Doors";
                    default:
                        return "(Unknown)";
                }
            }
        }

        /// <summary>
        /// Constructs Refrigerator object
        /// </summary>
        /// <param name="itemNumber">Item number</param>
        /// <param name="brand">Brand</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="wattage">Wattage</param>
        /// <param name="color">Color</param>
        /// <param name="price">Price</param>
        /// <param name="doors">Number of doors</param>
        /// <param name="width">Fridge width</param>
        /// <param name="height">Fridge height</param>
        public Refrigerator(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, short doors, int width, int height) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this._doors = doors;
            this._width = width;
            this._height = height;
        }

        public override string FormatForFile()
        {
            string commonFormatted = base.FormatForFile();
            string formatted = string.Join(';', commonFormatted, Doors, Width, Height);

            return formatted;
        }
        public override string ToString()
        {
            string display =
                string.Format("Item Number: {0}", ItemNumber) + "\n" +
                string.Format("Brand: {0}", Brand) + "\n" +
                string.Format("Quantity: {0}", Quantity) + "\n" +
                string.Format("Wattage: {0}", Wattage) + "\n" +
                string.Format("Color: {0}", Color) + "\n" +
                string.Format("Price: {0}", Price) + "\n" +
                string.Format("Number of Doors: {0}", NumberOfDoors) + "\n" +
                string.Format("Width: {0}", Width) + "\n" +
                string.Format("Height: {0}", Height);
                return display;
        }
    }
}

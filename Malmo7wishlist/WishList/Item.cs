namespace Malmo7wishlist
{
    /// <summary>
    /// Represents an item in the wishlist, containing details such as name, description, purchase location, and price.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the location where the item can be purchased.
        /// </summary>
        public string WhereToBuy { get; set; }

        /// <summary>
        /// Gets or sets the price of the item.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class with the specified details.
        /// </summary>

        public Item(string name, string description, string whereToBuy, decimal price)
        {
            Name = name;
            Description = description;
            WhereToBuy = whereToBuy;
            Price = price;
        }

        // Override ToString to format all details for display
        public override string ToString()
        {
            return $"{Name},{Description},{WhereToBuy},{Price:C}";
        }
    }
}


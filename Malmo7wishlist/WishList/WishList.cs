namespace Malmo7wishlist
{
    /// <summary>
    /// Represents a wishlist owned by a wisher, containing a collection of items.
    /// </summary>
    public class WishList
    {
        /// <summary>
        /// Gets or sets the owner of the wishlist.
        /// </summary>
        public Wisher Owner { get; set; }

        /// <summary>
        /// Gets the collection of items in the wishlist.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WishList"/> class with a specified owner.
        /// </summary>
        public WishList(Wisher owner)
        {
            Owner = owner;
            Items = new List<Item>();
        }

    }
}

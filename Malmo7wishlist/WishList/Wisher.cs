namespace Malmo7wishlist
{
    /// <summary>
    /// Represents a wisher with personal details and a list of their wishes.
    /// </summary>
    public class Wisher
    {
        /// <summary>
        /// Gets or sets the unique identifier for the wisher.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the wisher.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the wisher.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the relationship of the wisher to the user.
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// Gets the list of wishes associated with the wisher.
        /// </summary>
        public List<Item> WishList { get; set; } = new List<Item>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wisher"/> class.
        /// </summary>
        public Wisher() { }

        // Parameterized constructor
        public Wisher(string name, int age, string relationship)
        {
            Name = name;
            Age = age;
            Relationship = relationship;
        }

        /// <summary>
        /// Adds a wish to the wisher's wishlist.
        /// </summary>
        public void AddWish(Item wish)
        {
            WishList.Add(wish);
        }

        /// <summary>
        /// Removes a wish from the wisher's wishlist.
        /// </summary>
        public void RemoveWish(Item wish)
        {
            WishList.Remove(wish);
        }

        /// <summary>
        /// Returns a string that represents the current wisher, including  ID, name, age and relationship.
        /// </summary>
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Relationship: {Relationship}";
        }

    }
}

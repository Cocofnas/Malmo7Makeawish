namespace Malmo7wishlist
{
    /// <summary>
    /// Provides static methods for managing wishers and their wish lists.
    /// </summary>
    public static class WishManager
    {
        private static int currentId = 1; // Tracks the next ID to assign
        private static List<Wisher> wishers = new List<Wisher>(); // List to store all wishers


        /// <summary>
        /// Adds a new wisher to the list and assigns a unique ID.
        /// </summary>
        public static void AddWisher(Wisher wisher)
        {
            wisher.ID = currentId++;
            wishers.Add(wisher);
        }

        /// <summary>
        /// Retrieves the list of all wishers.
        /// </summary>
        public static List<Wisher> GetWishers() => new List<Wisher>(wishers);

        /// <summary>
        /// Updates an existing wisher's information.
        /// </summary>
        public static void UpdateWisher(Wisher updatedWisher)
        {
            var existingWisher = wishers.FirstOrDefault(w => w.ID == updatedWisher.ID);
            if (existingWisher != null)
            {
                existingWisher.Name = updatedWisher.Name;
                existingWisher.Age = updatedWisher.Age;
                existingWisher.Relationship = updatedWisher.Relationship;
            }
        }

        /// <summary>
        /// Removes a wisher from the list.
        /// </summary>
        public static void RemoveWisher(Wisher wisher)
        {
            wishers.Remove(wisher);
        }

        /// <summary>
        /// Clears all wishers from the list and resets the ID counter.
        /// </summary>
        public static void ClearAllWishers()
        {
            wishers.Clear();
            currentId = 1;
        }

        /// <summary>
        /// Saves the current list of wishers to a file.
        /// </summary>
        public static void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var wisher in wishers)
                {
                    writer.WriteLine($"{wisher.ID}|{wisher.Name}|{wisher.Age}|{wisher.Relationship}");
                }
            }
        }

        /// <summary>
        /// Loads a list of wishers from a file and restores the ID counter.
        /// </summary>
        public static void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("The specified file does not exist.");

            wishers.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4 &&
                        int.TryParse(parts[0], out var id) &&
                        int.TryParse(parts[2], out var age))
                    {
                        wishers.Add(new Wisher
                        {
                            ID = id,
                            Name = parts[1],
                            Age = age,
                            Relationship = parts[3]
                        });
                    }
                }
            }

            currentId = wishers.Any() ? wishers.Max(w => w.ID) + 1 : 1;
        }
    }
}

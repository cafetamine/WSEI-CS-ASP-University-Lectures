namespace NewBrandingStyle.Web.Models.Item
{
    public class ItemModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }

        // Serializer
        public ItemModel() { }

        private ItemModel(string name, string description, bool isVisible)
        {
            Name = name;
            Description = description;
            IsVisible = isVisible;
        }

        public static ItemModel Create(string name, string description, bool isVisible)
        {
            return new ItemModel(name, description, isVisible);
        }

        public override string ToString()
        {
            return "{\n"
                 +     $"\t\"name\": \"{Name}\",\n"
                 +     $"\t\"description\": \"{Description}\",\n"
                 +     $"\t\"isVisible\": {IsVisible}\n"
                 + "}";
        }
    }
}

namespace NewBrandingStyle.Web.Models.Company
{
    public class CompanyModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
        
        // Serializer
        public CompanyModel() { }

        private CompanyModel(string name, string description, bool isVisible)
        {
            Name = name;
            Description = description;
            IsVisible = isVisible;
        }

        public static CompanyModel Create(string name, string description, bool isVisible)
        {
            return new CompanyModel(name, description, isVisible);
        }
    }
}

namespace NewBrandingStyle.Web.Models.Company
{
    public class CompanyAddedViewModel
    {
        public int NumberOfCharsInName { get; set; }
        public int NumberOfCharsInDescription { get; set; }
        public bool IsHidden { get; set; }
        
        // Serializer
        public CompanyAddedViewModel() { }

        private CompanyAddedViewModel(int numberOfCharsInName, int numberOfCharsInDescription, bool isHidden)
        {
            NumberOfCharsInName = numberOfCharsInName;
            NumberOfCharsInDescription = numberOfCharsInDescription;
            IsHidden = isHidden;
        }

        public static CompanyAddedViewModel Create(int numberOfCharsInName, int numberOfCharsInDescription, bool isHidden)
        {
            return new CompanyAddedViewModel(numberOfCharsInDescription, numberOfCharsInDescription, isHidden);
        }
    }
}

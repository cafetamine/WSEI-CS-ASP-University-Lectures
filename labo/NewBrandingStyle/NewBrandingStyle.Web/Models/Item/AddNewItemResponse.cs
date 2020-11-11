namespace NewBrandingStyle.Web.Models.Item
{
    public class AddNewItemResponse
    {
        public string ItemName { get; }

        private AddNewItemResponse(string itemName)
        {
            ItemName = itemName;
        }

        public static AddNewItemResponse Create(ItemModel item)
        {
            return new AddNewItemResponse(item.Name);
        }
    }
}

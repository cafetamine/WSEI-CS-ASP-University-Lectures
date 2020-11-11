using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models.Item;

namespace NewBrandingStyle.Web.Controllers.Item
{
    [ApiController]
    [Route("api/item")]
    public class ItemRestController : ControllerBase
    {
        public AddNewItemResponse Post(ItemModel item)
        {
            return AddNewItemResponse.Create(item);
        }
    }
}

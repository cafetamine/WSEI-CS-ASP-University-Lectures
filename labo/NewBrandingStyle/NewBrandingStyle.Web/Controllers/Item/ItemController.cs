using Microsoft.AspNetCore.Mvc;

namespace NewBrandingStyle.Web.Controllers.Item
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

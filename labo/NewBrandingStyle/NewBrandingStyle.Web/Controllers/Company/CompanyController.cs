using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models.Company;

namespace NewBrandingStyle.Web.Controllers.Company
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            var viewModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible
            };
            return View("CompanyAdded", viewModel);
        }
    }
}

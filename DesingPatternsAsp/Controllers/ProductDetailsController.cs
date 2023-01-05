using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPatternsAsp.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index(decimal total)
        {
            // Factories
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            ForeingEarnFactory foreingEarnFactory = new ForeingEarnFactory(0.30m, 20);

            // Products
            var localEarn = localEarnFactory.GetEarn();
            var foreingEarn = foreingEarnFactory.GetEarn();

            // Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeing = total + foreingEarn.Earn(total);

            return View();
        }
    }
}

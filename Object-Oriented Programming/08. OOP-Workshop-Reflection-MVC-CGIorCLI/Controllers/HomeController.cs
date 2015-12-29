namespace WebPage.Controllers
{
    using Core.Attributes.HttpRequestMethods;
    using Core.Controllers;
    using Core.Interfaces;

    public class HomeController : Controller
    {
        [HttpPost]
        public IViewResult Index(
            int id)
        {
            return View();
        }

    }
}

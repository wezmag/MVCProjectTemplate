using ProjectTemplate.Service.Interface;
using System.Linq;
using System.Web.Mvc;

namespace ProjectTemplate.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISampleService _sampleService;

        public HomeController(ISampleService sampleService)
        {
            _sampleService = sampleService;

        }


        public ActionResult Index()
        {
            var samples = _sampleService.GetAll().ToList();
            return View(samples);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
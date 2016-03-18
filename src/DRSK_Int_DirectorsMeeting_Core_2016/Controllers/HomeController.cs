using Microsoft.AspNet.Mvc;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}

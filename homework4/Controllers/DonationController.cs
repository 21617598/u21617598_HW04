using System.Web.Mvc;

namespace homework4.Controllers
{
    public class DonationController : Controller
    {
        // GET: Donation
        public ActionResult Donate()
        {
            return View();
        }
    }
}
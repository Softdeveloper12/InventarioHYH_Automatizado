using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace CapaPresentacion.Controllers
{
    [OutputCache(Duration = 1)]
    public class HomeController : Controller
    {
        
        [Authorize]
        public ActionResult Index()
        {
            _DoBackEndStuff();
            return View();
        }
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Collections.Specialized.BitVector32;
using System.Web.Optimization;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Tiki.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TrangHome()
        {
            return View();
        }

    }
}

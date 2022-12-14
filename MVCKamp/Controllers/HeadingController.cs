using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKamp.Controllers
{
    public class HeadingController : Controller
    {

        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        // GET: Heading
        public ActionResult Index()
        {
            var result = headingManager.ListHeadings();
            return View(result);
        }
    }
}
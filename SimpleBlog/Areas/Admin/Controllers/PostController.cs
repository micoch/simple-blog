using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class PostController : Controller
    {
        public ActionResult Index()
        {
            return Content("This is where posts are listed in the admin area");
        }
    }
}
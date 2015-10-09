using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: login
        public ActionResult Login()
        {
            return Content("this is where we will login to our app");
        }
    }
}
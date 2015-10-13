using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModel;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult Login(AuthLogin form, string returnUrl)
        {

            if (!ModelState.IsValid)
                return View(form);
            

            FormsAuthentication.SetAuthCookie(form.Username, true);


            if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToRoute("home");
            
        }
    }
}
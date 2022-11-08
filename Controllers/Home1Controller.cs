using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using signup.Models;
using System.Linq;


namespace signup.Controllers
{
    public class Home1Controller : Controller
    {
        jaicsEntities cm=new jaicsEntities();
        // GET: Home1
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(loginviewmodel cr)
        {
            bool user = cm.usertbls.Any(x => x.email == cr.email && x.passcode == cr.password);
            usertbl u = cm.usertbls.FirstOrDefault(x => x.email == cr.email && x.passcode == cr.password);
           if(user)
            {
                FormsAuthentication.SetAuthCookie(u.username, false);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "username or password wrong");
            return View();
        }
        [HttpPost]
        public ActionResult Signup1(usertbl info)
        {
            cm.usertbls.Add(info);
            cm.SaveChanges();
            return RedirectToAction("Login");
            
        }
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
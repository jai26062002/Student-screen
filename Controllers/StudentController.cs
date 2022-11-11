using System;
using System.IO;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using signup.Models;
using System.Linq;


namespace signup.Controllers
{


    public class StudentController : Controller
    {

        // GET: Student
        public ActionResult Update()
        {
            studenttbl b1 = new studenttbl();
            return View(b1);


        }
    }
}

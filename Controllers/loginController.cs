﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Areas.Admin.Controllers
{
    public class loginController : Controller
    {
        // GET: Admin/login
        public ActionResult Dangnhap()
        {
            return View();
        }
    }
}
﻿using AttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            VajraEntities db = new VajraEntities();

            var listUser = db.Users;

            List<User> userList = db.Users.ToList();

            return View();
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
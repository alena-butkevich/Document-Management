﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocumentFlow.Models;

namespace DocumentFlow.Controllers
{
    public class MainController : Controller
    {
         // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        ApplicationContext db = new ApplicationContext();

        [HttpGet]
        public ViewResult Incoming()
        {
            List<Document> list = new List<Document>();
            using (ApplicationContext context = new ApplicationContext())
            {
                list = db.documents.Where(x => AccountController.UserId == x.userid).ToList();
            }
            return View(list);
 
        }


        [HttpGet]
        public ViewResult Outcoming()
        {
            List<Document> list = new List<Document>();
            using (ApplicationContext context = new ApplicationContext())
            {
                list = db.documents.Where(x => AccountController.UserId == x.currentid).ToList();
            }
            return View(list);
        }
    }
}
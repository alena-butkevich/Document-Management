using System;
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

        DocumentContext db = new DocumentContext();

        public List<Document> getInputDocuments(int userid)
        {
            List<Document> list = new List<Document>();
            
                foreach (Document d in db.documents)
                {
                    if (userid == d.userid)
                    {
                        list.Add(d);
                    }
                }
                return list;
      }

        public List<Document> getOutputDocuments(int currentid)
        {
            List<Document> list = new List<Document>();
            foreach (Document d in db.documents)
            {
                if (currentid == d.currentid)
                {
                    list.Add(d);
                }
            }
            return list;
        }
    }
}
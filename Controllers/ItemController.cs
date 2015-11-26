using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList05.Models;

namespace ToDoList05.Controllers
{
    public class ItemController : Controller
    {
        ToDoListContext db = new ToDoListContext();
        // GET: Item
        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }
    }
}
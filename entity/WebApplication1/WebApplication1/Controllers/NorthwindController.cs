using System.Web.Mvc;
using System.Web;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class NorthwindController : Controller
    {
        NorthWindContext db = new NorthWindContext();
        // GET: Northwind
        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.ProductsTable.ToList();
            return View();
        }
    }
}
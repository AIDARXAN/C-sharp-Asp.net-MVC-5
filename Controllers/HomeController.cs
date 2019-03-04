using MetanitASP_NET_MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MetanitASP_NET_MVC5.Util;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MetanitASP_NET_MVC5.Controllers
{
    public class HomeController : Controller
    {
        //creating data context
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            // taking from db all objects book
            IEnumerable<Book> books = db.Books;
            // passing all object into dynamic property of Books in ViewBag
            ViewBag.Books = books;
            //ViewBag.Message = "Это вызов частичного представления из обычного";

            return View();
        }

        //async method 
        //public async Task<ActionResult> BookList()
        //{
        //    IEnumerable<Book> books = await db.Books.ToListAsync();
        //    ViewBag.Books = books;
        //    return View("Index");
        //}



        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase, int id)
        {
            purchase.Date = DateTime.Now;
            // adding information about purchase
            db.Purchases.Add(purchase);
            // saving in db all changes
            Book book = db.Books.Find(id);
            if (book.InStock == 0)
            {
                db.Entry(book).State = EntityState.Deleted;
            }
            else
            {
                book.InStock = book.InStock - 1;
                db.Entry(book).State = EntityState.Modified;
            }
            db.SaveChanges();
            return "Thanks, " + purchase.Person + ", for purchase!";
        }

        public ActionResult EditBook(int id) {
            return null;
        }
        
        //public ActionResult Partial()
        //{
        //    ViewBag.Message = "Это частичное представление.";
        //    return PartialView();
        //}

        //public ActionResult GetHtml()
        //{
        //    return new HtmlResult("<h2>How are you my friend!</h2>");
        //}

        //public ActionResult GetImage()
        //{
        //    string path = "https://www.rankwatch.com/learning/sites/default/files/2.jpg";
        //    return new ImageResult(path);
        //}
    }
}
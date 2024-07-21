using DemoWebMVC.Areas.Admin.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DemoWebMVC.Areas.Admin.Controllers
{

    public class ProductController : Controller
    {
        private static List<Product> data = new List<Product>{
                new Product { STT = 1, Name = "Product A", Quantity = 10, Price = 100 },
                new Product { STT = 2, Name = "Product B", Quantity = 20, Price = 200 },
                new Product { STT = 3, Name = "Product C", Quantity = 15, Price = 150 }
            };
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoadData()
        {
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(string Name, double Price, int Quantity)
        {
            try
            {
                Product Product = new Product() { STT = data.Count + 1, Name = Name, Price = Price, Quantity = Quantity };
                data.Add(Product);
                return RedirectToAction("Index", "Product");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}

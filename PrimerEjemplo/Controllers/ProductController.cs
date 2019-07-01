using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PrimerEjemplo.Context;
using PrimerEjemplo.Models;

namespace PrimerEjemplo.Controllers
{
    public class ProductController : Controller
    {
        private DataStore db = new DataStore();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            Product pro = db.Products.Find(id);
            return View(pro);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product Product)
        {
            try
            {
                if (ModelState.IsValid){
                    db.Products.Add(Product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Product);
            }
            catch
            {
                return View(Product);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product pro = db.Products.Find(id);
            return View(pro);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product pro)
        {
            try
            {
                db.Entry(pro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(pro);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            Product pro = db.Products.Find(id);
            return View(pro);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product pro)
        {
            try
            {
                pro = db.Products.Find(id);
                db.Products.Remove(pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(pro);
            }
        }
    }
}

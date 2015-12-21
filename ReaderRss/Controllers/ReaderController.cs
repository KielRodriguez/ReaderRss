using ReaderRss.Models;
using ReaderRss.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReaderRss.Controllers
{
    public class ReaderController : Controller
    {
        private ReadFeedService service;

        // GET: Reader
        public ActionResult Index()
        {

            Feed model = new Feed();
            return View(model);
        }

        // GET: Reader/Details
        [HttpPost]
        public ActionResult Details(Feed feed)
        {
            this.service = new ReadFeedService();
            this.service.consultaFeedRss(feed);
            
            return View("Index", feed);
        }

        // GET: Reader/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reader/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reader/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reader/Edit/5
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

        // GET: Reader/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reader/Delete/5
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

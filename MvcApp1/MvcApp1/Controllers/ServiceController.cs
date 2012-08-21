using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcApp1.Controllers
{
    public class ServiceController : AsyncController 
    {
        //
        // GET: /Service/

        public async Task<ActionResult> Index()
        {


            var client = new WebClient();
            var oLocations = client.DownloadStringTaskAsync("http://localhost:36972/api/Location");
            var oTemperatures = client.DownloadStringTaskAsync("http://localhost:36972/api/Temperature");

            var oContacts = client.DownloadStringTaskAsync("http://localhost:36972/api/Contacts");
            
            await Task.WhenAll(oContacts, oLocations, oTemperatures);

            ViewBag.Contacts = oContacts;
            ViewBag.Locations = oLocations;
            ViewBag.Temperatures = oTemperatures;


            return View();
        }

        //
        // GET: /Service/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Service/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Service/Create

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

        //
        // GET: /Service/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Service/Edit/5

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

        //
        // GET: /Service/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Service/Delete/5

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

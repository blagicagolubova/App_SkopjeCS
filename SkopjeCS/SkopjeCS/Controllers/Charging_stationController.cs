using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SkopjeCS.Models;

namespace SkopjeCS.Controllers
{
    [Authorize]
    public class Charging_stationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Charging_station
        public ActionResult Index()
        {
            return View(db.Charging_station.ToList());
        }

        // GET: Charging_station/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Charging_station charging_station = db.Charging_station.Find(id);
            if (charging_station == null)
            {
                return HttpNotFound();
            }
            return View(charging_station);
        }

        public ActionResult Detali(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Charging_station charging_station = db.Charging_station.Find(id);
            if (charging_station == null)
            {
                return HttpNotFound();
            }
            return View(charging_station);
        }

        // GET: Charging_station/Create
        public ActionResult TabularView()
        {
            return View(db.Charging_station.ToList());
        }
        public ActionResult Map()
        {
            return View(db.Charging_station.ToList());
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

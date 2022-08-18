using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocios;
using System.Net;
using Microsoft.AspNet.Identity.EntityFramework;
using CapaPresentacion.Models;
using Microsoft.AspNet.Identity;
using System.Threading;
namespace CapaPresentacion.Controllers
{
    [OutputCache(Duration = 1)]
    public class Modulo_MonitoresController : Controller
    { 
        private ApplicationDbContext db = new ApplicationDbContext();
        CMonitores_negocios monitor_negocio = new CMonitores_negocios();

        // GET: Modulo_Monitores
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var monitor = CMonitores_negocios.IndexMonitor();
            return View(monitor);

        }

        // GET: Modulo_Monitores/Details/5
        public ActionResult MonitorDetail(int id)
        {

            var dpto = monitor_negocio.MonitorDetail(id);
            _DoBackEndStuff();
            return View(dpto);
            ;
        }

        // GET: Modulo_Monitores/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();
            return View();
        }

        // POST: Modulo_Laptops/Create
        [HttpPost]
        public ActionResult Create(Monitore element)
        {

            if (element.Brand == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Description == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Model == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }

            monitor_negocio.InsertMonitores(element);
            _DoBackEndStuff();
            return RedirectToAction("Index");




        }


        // GET: Modulo_Monitores/Edit/5
        public ActionResult Editar(int id)
        {
            var dpto = monitor_negocio.MonitorDetail(id);
            _DoBackEndStuff();
            return View(dpto);
        }

        // POST: Modulo_Laptops/Edit/5
        [HttpPost]
        public ActionResult Editar(Monitore dpto)
        {
            try
            {
                if (dpto.Brand == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Description == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Model == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                
                monitor_negocio.UpdateMonitores(dpto);
                _DoBackEndStuff();
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to update a department");
                return View(dpto);

            }
        }

        // GET: Modulo_Laptops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = monitor_negocio.MonitorDetail(id.Value);
            return View(dpto);
        }

        // POST: Modulo_Laptops/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                monitor_negocio.DeleteMonitores(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to delete a department");
                return View();
            }


        }
        


    }
}
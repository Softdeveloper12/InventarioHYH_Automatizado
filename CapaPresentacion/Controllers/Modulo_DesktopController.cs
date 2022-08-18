using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocios;
using System.Net;
using System.Threading;
namespace CapaPresentacion.Controllers
{
    [OutputCache(Duration = 1)]
    public class Modulo_DesktopController : Controller
    {
        CDesktops_negocio desktops_negocio = new CDesktops_negocio();
        // GET: Modulo_Desktop
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var desktop = CDesktops_negocio.IndexDesktop();
            return View(desktop);
           
        }
        // GET: Modulo_Monitores/Details/5
        public ActionResult DesktopDetail(int id)
        {
            _DoBackEndStuff();
            var dpto = desktops_negocio.DesktopDetail(id);
            return View(dpto);
        }

        // GET: Modulo_Desktop/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();
            return View();
        }

        // POST: Modulo_Desktop/Create
        [HttpPost]
        public ActionResult Create(Desktop element)
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
            else if (element.ModelNumber == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            _DoBackEndStuff();
            desktops_negocio.InsertDesktops(element);
            return RedirectToAction("Index");





        }


        // GET: Modulo_Desktop/Edit/5
        public ActionResult Editar(int id)
        {
            _DoBackEndStuff();
            var dpto = desktops_negocio.DesktopDetail(id);
            return View(dpto);
        }

        // POST: Modulo_Desktop/Edit/5
        [HttpPost]
        public ActionResult Editar(Desktop dpto)
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
                else if (dpto.ModelNumber == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                _DoBackEndStuff();
                desktops_negocio.UpdateDesktops(dpto);
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
            var dpto = desktops_negocio.DesktopDetail(id.Value);
            return View(dpto);
        }

        // POST: Modulo_Laptops/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                desktops_negocio.DeleteDesktops(id);
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
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
    public class Modulo_MemoriaRamController : Controller
    {
        CMemoriaRam_negocio memoriaram_negocio = new CMemoriaRam_negocio();
        // GET: Modulo_MemoriaRam
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var ram = CMemoriaRam_negocio.IndexMemoriaRam();
            return View(ram);
        }
        // GET: Modulo_Memoria Ram/Details/5
        public ActionResult MemoriaRamDetail(int id)
        {
            _DoBackEndStuff();
            var dpto = memoriaram_negocio.MemoriaRamDetail(id);
            return View(dpto);
        }

        // GET: Modulo_Memoria Ram/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();
            return View();
        }

        // POST: Modulo_Memoria Ram/Create
        [HttpPost]
        public ActionResult Create(datos_Ram element)
        {

            if (element.Capacity == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Frequency == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.FormFactor == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Slot == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Quantity == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Observacion == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }


            memoriaram_negocio.InsertMemoriaRam(element);
            _DoBackEndStuff();
            return RedirectToAction("Index");


        }


        // GET: Modulo_Memoria Ram/Edit/5
        public ActionResult Editar(int id)
        {
            _DoBackEndStuff();
            var dpto = memoriaram_negocio.MemoriaRamDetail(id);
            return View(dpto);
        }

        // POST: Modulo_Memoria Ram/Edit/5
        [HttpPost]
        public ActionResult Editar(datos_Ram dpto)
        {
            try
            {
                if (dpto.Capacity == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Frequency == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.FormFactor == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Slot == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Quantity == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Observacion == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                memoriaram_negocio.UpdateMemoriaRam(dpto);
                _DoBackEndStuff();
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to update a department");
                return View(dpto);

            }
        }

        // GET: Modulo_Memoria Ram/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = memoriaram_negocio.MemoriaRamDetail(id.Value);
            return View(dpto);
        }

        // POST: Modulo_Memoria Ram/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                memoriaram_negocio.DeleteMemoriaRam(id);
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
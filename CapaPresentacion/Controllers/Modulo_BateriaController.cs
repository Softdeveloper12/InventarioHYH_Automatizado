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
    public class Modulo_BateriaController : Controller
    {
        CBateria_negocio bateria_negocio = new CBateria_negocio();
        // GET: Modulo_Bateria
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var bateria = CBateria_negocio.IndexBateria();
            return View(bateria);
        }
        // GET: Modulo_Bateria/Details/5
        public ActionResult BateriaDetail(int id)
        {
            _DoBackEndStuff();
            var dpto = bateria_negocio.BateriaDetail(id);
            return View(dpto);
        }

        // GET: Modulo_Bateria/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();

            return View();
        }

        // POST: Modulo_Bateria/Create
        [HttpPost]
        public ActionResult Create(Bateria element)
        {

            if (element.Model == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Type == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Quantity == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            _DoBackEndStuff();
            bateria_negocio.InsertBateria(element);
            return RedirectToAction("Index");





        }


        // GET: Modulo_Bateria/Edit/5
        public ActionResult Editar(int id)
        {
            _DoBackEndStuff();
            var dpto = bateria_negocio.BateriaDetail(id);
            return View(dpto);
        }

        // POST: Modulo_Bateria/Edit/5
        [HttpPost]
        public ActionResult Editar(Bateria dpto)
        {
            try
            {
                if (dpto.Model == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Type == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Quantity == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                _DoBackEndStuff();
                bateria_negocio.UpdateBateria(dpto);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to update a department");
                return View(dpto);

            }
        }

        // GET: Modulo_Bateria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = bateria_negocio.BateriaDetail(id.Value);
            _DoBackEndStuff();
            return View(dpto);
        }

        // POST: Modulo_Bateria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                bateria_negocio.DeleteBateria(id);
                _DoBackEndStuff();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to delete a department");
                _DoBackEndStuff();
                return View();
            }
        }
    }
}

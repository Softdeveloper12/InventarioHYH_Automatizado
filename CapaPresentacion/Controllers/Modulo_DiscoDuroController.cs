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
    public class Modulo_DiscoDuroController : Controller
    {
        CDiscosDuros_negocio discoduro_negocio = new CDiscosDuros_negocio();
        // GET: Modulo_DiscoDuro
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var disco = CDiscosDuros_negocio.IndexDiscosDuros();
            return View(disco);
        }
        // GET: Modulo_Disco Duro/Details/5
        public ActionResult DiscoDuroDetail(int id)
        {
            _DoBackEndStuff();
            var dpto = discoduro_negocio.DiscosDurosDetail(id);
            return View(dpto);
        }

        // GET: Modulo_Disco Duro/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();
            return View();
        }

        // POST: Modulo_Disco Duro/Create
        [HttpPost]
        public ActionResult Create(DiscosDuro element)
        {

            if (element.Capacity == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Type == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Size == null)
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
            discoduro_negocio.InsertDiscosDuros(element);
            return RedirectToAction("Index");

        }


        // GET: Modulo_Disco Duro/Edit/5
        public ActionResult Editar(int id)
        {
            _DoBackEndStuff();
            var dpto = discoduro_negocio.DiscosDurosDetail(id);
            return View(dpto);
        }

        // POST: Modulo_Disco Duro/Edit/5
        [HttpPost]
        public ActionResult Editar(DiscosDuro dpto)
        {
            try
            {
                if (dpto.Capacity == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Type == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Size == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Quantity == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }

                discoduro_negocio.UpdateDiscosDuros(dpto);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                _DoBackEndStuff();
                ModelState.AddModelError("", "System error, an error occurred while trying to update a department");
                return View(dpto);

            }
        }

        // GET: Modulo_Disco Duro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = discoduro_negocio.DiscosDurosDetail(id.Value);
            return View(dpto);
        }

        // POST: Modulo_Disco Duro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                discoduro_negocio.DeleteDiscosDuros(id);
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
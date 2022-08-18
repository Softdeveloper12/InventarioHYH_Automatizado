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
    public class Modulo_CargadoresController : Controller
    {
        CCargadores_negocio cargadores_negocio = new CCargadores_negocio();
        // GET: Modulo_Cargadores
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var cargador = CCargadores_negocio.IndexCargadores();
            return View(cargador);
        }
        // GET: Modulo_Cargadores/Details/5
        public ActionResult CargadorDetail(int id)
        {
            _DoBackEndStuff();
            var dpto = cargadores_negocio.CargadoresDetail(id);
            return View(dpto);
        }

        // GET: Modulo_Cargadores/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();
            return View();
        }

        // POST: Modulo_Cargadores/Create
        [HttpPost]
        public ActionResult Create(datos_Cargadores element)
        {

            if (element.Brand == null)
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
            cargadores_negocio.InsertCargadores(element);
            return RedirectToAction("Index");





        }


        // GET: Modulo_Cargadores/Edit/5
        public ActionResult Editar(int id)
        {
            _DoBackEndStuff();
            var dpto = cargadores_negocio.CargadoresDetail(id);
            return View(dpto);
        }

        // POST: Modulo_Laptops/Edit/5
        [HttpPost]
        public ActionResult Editar(datos_Cargadores dpto)
        {
            try
            {
                if (dpto.Brand == null)
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
                cargadores_negocio.UpdateCargadores(dpto);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to update a department");
                return View(dpto);

            }
        }

        // GET: Modulo_Cargadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = cargadores_negocio.CargadoresDetail(id.Value);
            _DoBackEndStuff();
            return View(dpto);
        }

        // POST: Modulo_Cargadores/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _DoBackEndStuff();
                cargadores_negocio.DeleteCargadores(id);
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
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
    public class Modulo_AccesoriosController : Controller
    {
        CAccesories_negocio accesories_negocio = new CAccesories_negocio();
        // GET: Modulo_Accesorios
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var accesorio = CAccesories_negocio.IndexAccesorios();
            return View(accesorio);
        }
        // GET: Modulo_Accesorios/Details/5
        public ActionResult AccesoriesDetail(int id)
        {
            _DoBackEndStuff();
            var dpto = accesories_negocio.AccesoriesDetail(id);
            return View(dpto);
        }

        // GET: Modulo_Accesorios/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();
            return View();
        }

        // POST: Modulo_Accesorios/Create
        [HttpPost]
        public ActionResult Create(datos_Accesories element)
        {

            if (element.Brand == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Descripcion == null)
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
            accesories_negocio.InsertAccesories(element);
            return RedirectToAction("Index");





        }


        // GET: Modulo_Accesorios/Edit/5
        public ActionResult Editar(int id)
        {

            var dpto = accesories_negocio.AccesoriesDetail(id);
            _DoBackEndStuff();
            return View(dpto);
        }

        // POST: Modulo_Accesorios/Edit/5
        [HttpPost]
        public ActionResult Editar(datos_Accesories dpto)
        {
            try
            {
                if (dpto.Brand == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.Descripcion == null)
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
                accesories_negocio.UpdateAccesories(dpto);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to update a department");
                return View(dpto);

            }
        }

        // GET: Modulo_Accesorios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = accesories_negocio.AccesoriesDetail(id.Value);
            _DoBackEndStuff();
            return View(dpto);
        }

        // POST: Modulo_Bateria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                accesories_negocio.DeleteAccesories(id);
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
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
    public class Modulo_LaptopsController : Controller
    {

        CLaptops_negocio laptops_Negocio = new CLaptops_negocio();
        // GET: Modulo_Laptops
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            _DoBackEndStuff();
            var laptop = CLaptops_negocio.IndexLaptop();
            return View(laptop);
        }

        // GET: Modulo_Laptops/Details/5
        public ActionResult LaptopDetail(int id)
        {
            _DoBackEndStuff();
            var dpto = laptops_Negocio.LaptopDetail(id);
            return View(dpto);
        }

        // GET: Modulo_Laptops/Create
        public ActionResult Create()
        {
            _DoBackEndStuff();
            return View();
        }

        // POST: Modulo_Laptops/Create
        [HttpPost]
        public ActionResult Create(laptop element)
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
            else if (element.ModelNumber == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }
            else if (element.Model == null)
            {
                ModelState.AddModelError("", "Este campo es obligatorio");
                return View(element);
            }

            _DoBackEndStuff();
            laptops_Negocio.InsertLaptops(element);
            return RedirectToAction("Index");





        }


        // GET: Modulo_Laptops/Edit/5
        public ActionResult Editar(int id)
        {
            _DoBackEndStuff();
            var dpto = laptops_Negocio.LaptopDetail(id);
            return View(dpto);
        }

        // POST: Modulo_Laptops/Edit/5
        [HttpPost]
        public ActionResult Editar(laptop dpto)
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
                laptops_Negocio.UpdateLaptop(dpto);
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
            var dpto = laptops_Negocio.LaptopDetail(id.Value);
            return View(dpto);
        }

        // POST: Modulo_Laptops/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                laptops_Negocio.DeleteLaptop(id);
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
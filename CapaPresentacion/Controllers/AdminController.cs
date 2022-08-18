
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
    [Authorize(Users = "admininventario@hyhsolutions.com.do, eacosta@hyhsolutions.com.do, hmondesi@hyhsolutions.com.do, mfernandez@hyhsolutions.com.do")]
    public class AdminController : Controller
    {
        CAdministrador_negocio administrador_negocio = new CAdministrador_negocio();
        // GET: Admin
        private void _DoBackEndStuff()
        {
            Thread.Sleep(100);
        }
        public ActionResult Index()
        {
            
            var admin = CAdministrador_negocio.AdministracionIndex();
            _DoBackEndStuff();
            return View(admin);
        }
        // GET: Modulo_Administrador/Details/5
        public ActionResult AdminDetail(string id)
        {
            _DoBackEndStuff();
            var dpto = administrador_negocio.AdministracionDetail(id);
            return View(dpto);
        }


        // GET: Modulo_Administrador/Edit/5
        public ActionResult Editar(string id)
        {
            var dpto = administrador_negocio.AdministracionDetail(id);
            _DoBackEndStuff();
            return View(dpto);
        }

        // POST: Modulo_Administrador/Edit/5
        [HttpPost]
        public ActionResult Editar(AspNetUser dpto)
        {
            try
            {
                if (dpto.Email == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }
                else if (dpto.UserName == null)
                {
                    ModelState.AddModelError("", "Este campo es obligatorio");
                    return View(dpto);
                }

                administrador_negocio.AdministracionUpdate(dpto);
                _DoBackEndStuff();
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "System error, an error occurred while trying to update a department");
                _DoBackEndStuff();
                return View(dpto);

            }
        }

        // GET: Modulo_Administrador/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = administrador_negocio.AdministracionDetail(id);
            _DoBackEndStuff();

            administrador_negocio.AdministracionDelete(id); ;
            return RedirectToAction("Index");
        }

        // POST: Modulo_Administrador/Delete/5
        [HttpPost]
        public ActionResult Deletec(string id)
        {
            try
            {
                administrador_negocio.AdministracionDelete(id);
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
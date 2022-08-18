using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CAdministrador_Datos
    {
        private Entities dbp = new Entities();

        public List<AspNetUser> Index()
        {
            using (var dbp = new Entities())
            {
                return dbp.AspNetUsers.ToList();
            }
        }

        public List<AspNetRole> PerfilUser()
        {
            using (var dbp = new Entities()) 
            { 
                return dbp.AspNetRoles.ToList();
            }  
        }

        public void Update(AspNetUser aspNetUser)
        {
            var registro = dbp.AspNetUsers.First(a => a.Id == aspNetUser.Id);
            registro.UserName = aspNetUser. UserName;
            registro.Email = aspNetUser.Email;
            registro.Perfil = aspNetUser.Perfil;    

            dbp.SaveChanges();
        }
        public void Delete(string id)
        {
            var registro = dbp.AspNetUsers.Where(set => set.Id == id).FirstOrDefault();
            dbp.AspNetUsers.Remove(registro);
            dbp.SaveChanges();

        }

        public AspNetUser Detail(string id)
        {
            using (var dbp = new Entities())
            {
                return dbp.AspNetUsers.Where(d => d.Id == id).FirstOrDefault();
            }

        }
    }
}

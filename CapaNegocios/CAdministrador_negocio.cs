using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CAdministrador_negocio
    {
        static CAdministrador_Datos executer = new CAdministrador_Datos();
        public void AdministracionUpdate(AspNetUser aspNetUser)
        {
            executer.Update(aspNetUser);
        }
        public void AdministracionDelete(string id)
        {
            executer.Delete(id);

        }
        private static CAdministrador_Datos data = new CAdministrador_Datos();
        public static List<AspNetUser> AdministracionIndex()
        {
            return data.Index();
        }
        public static List<AspNetRole> PerfilUsuarios()
        {
            return data.PerfilUser();
        }
        public AspNetUser AdministracionDetail(string id)
        {
            return executer.Detail(id);
        }
    }
}

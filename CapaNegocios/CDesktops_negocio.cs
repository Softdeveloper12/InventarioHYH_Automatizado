using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;


namespace CapaNegocios
{
    public class CDesktops_negocio
    {
        static CDesktop_Datos executer = new CDesktop_Datos();
        public void InsertDesktops(Desktop desktop)
        {
            executer.InsertDesktop(desktop);
        }
        public List<Desktop> MostrarDesktop()
        {
            return executer.MostrarDesktop();
        }
        public void UpdateDesktops(Desktop desktop)
        {
            executer.UpdateDesktop(desktop);
        }
        public void DeleteDesktops(int id)
        {
            executer.DeleteDesktop(id);

        }
        private static CDesktop_Datos data = new CDesktop_Datos();
        public static List<Desktop> IndexDesktop()
        {
            return data.IndexDesktop();
        }
        public Desktop DesktopDetail(int id)
        {
            return executer.DesktopDetail(id);
        }
    }
}

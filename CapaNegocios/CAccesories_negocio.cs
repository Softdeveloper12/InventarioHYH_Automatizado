using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CAccesories_negocio
    {
        static CAccesories_Datos executer = new CAccesories_Datos();
        public void InsertAccesories(datos_Accesories accesories)
        {
            executer.InsertAccesorios(accesories);
        }
        public List<datos_Accesories> MostrarAccesorios()
        {
            return executer.MostrarAccesorios();
        }
        public void UpdateAccesories(datos_Accesories accesories)
        {
            executer.UpdateAccesorios(accesories);
        }
        public void DeleteAccesories(int id)
        {
            executer.DeleteAccesorios(id);

        }
        private static CAccesories_Datos data = new CAccesories_Datos();
        public static List<datos_Accesories> IndexAccesorios()
        {
            return data.IndexAccesories();
        }
        public datos_Accesories AccesoriesDetail(int id)
        {
            return executer.AccesoriesDetail(id);
        }
    }
}

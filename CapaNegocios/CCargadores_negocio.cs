using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CCargadores_negocio
    {
        static CCargadores_Datos executer = new CCargadores_Datos();
        public void InsertCargadores(datos_Cargadores cargadores)
        {
            executer.Insertcargadores(cargadores);
        }
        public List<datos_Cargadores> MostrarCargadores()
        {
            return executer.MostrarCargadores();
        }
        public void UpdateCargadores(datos_Cargadores cargadores)
        {
            executer.UpdateCargadores(cargadores);
        }
        public void DeleteCargadores(int id)
        {
            executer.DeleteCargadores(id);

        }
        private static CCargadores_Datos data = new CCargadores_Datos();
        public static List<datos_Cargadores> IndexCargadores()
        {
            return data.IndexCargadores();
        }
        public datos_Cargadores CargadoresDetail(int id)
        {
            return executer.CargadoresDetail(id);
        }
    }
}

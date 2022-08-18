using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CMemoriaRam_negocio
    {
        static CMemoriaRam_Datos executer = new CMemoriaRam_Datos();
        public void InsertMemoriaRam(datos_Ram ram)
        {
            executer.InsertMemoriaRam(ram);
        }
        public List<datos_Ram> MostrarMemoriaRam()
        {
            return executer.MostrarMemoriaRam();
        }
        public void UpdateMemoriaRam(datos_Ram ram)
        {
            executer.UpdateMemoriaRam(ram);
        }
        public void DeleteMemoriaRam(int id)
        {
            executer.DeleteMemoriaRam(id);

        }
        private static CMemoriaRam_Datos data = new CMemoriaRam_Datos();
        public static List<datos_Ram> IndexMemoriaRam()
        {
            return data.IndexMemoriaRam();
        }
        public datos_Ram MemoriaRamDetail(int id)
        {
            return executer.MemoriaRamDetail(id);
        }
    }
}

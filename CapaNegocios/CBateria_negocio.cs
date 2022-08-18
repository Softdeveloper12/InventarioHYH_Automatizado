using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CBateria_negocio
    {
        static CBateria_Datos executer = new CBateria_Datos();
        public void InsertBateria(Bateria bateria)
        {
            executer.InsertBateria(bateria);
        }
        public List<Bateria> MostrarBateria()
        {
            return executer.MostrarBateria();
        }
        public void UpdateBateria(Bateria bateria)
        {
            executer.UpdateBateria(bateria);
        }
        public void DeleteBateria(int id)
        {
            executer.DeleteBateria(id);

        }
        private static CBateria_Datos data = new CBateria_Datos();
        public static List<Bateria> IndexBateria()
        {
            return data.IndexBateria();
        }
        public Bateria BateriaDetail(int id)
        {
            return executer.BateriaDetail(id);
        }
    }
}

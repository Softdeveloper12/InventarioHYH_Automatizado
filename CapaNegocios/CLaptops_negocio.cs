using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CLaptops_negocio
    {
        static CLaptops_Datos executer = new CLaptops_Datos();
        public void InsertLaptops(laptop laptop)
        {
            executer.InsertLaptop(laptop);
        }
        public static List<laptop> MostrarLaptop()
        {
            return executer.MostrarLaptop();
        }
        public void UpdateLaptop(laptop laptop)
        {
            executer.UpdateLaptop(laptop);
        }
        public void DeleteLaptop(int id)
        {
            executer.DeleteLaptop(id);

        }
        private static CLaptops_Datos data = new CLaptops_Datos();
        public static List<laptop> IndexLaptop()
        {
            return data.IndexLaptop();
        }
        public laptop LaptopDetail(int id)
        {
            return executer.LaptopDetail(id);
        }
    }
}

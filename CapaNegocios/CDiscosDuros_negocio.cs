using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;



namespace CapaNegocios
{
    public class CDiscosDuros_negocio
    {
        static CDiscosDuros_Datos executer = new CDiscosDuros_Datos();
        public void InsertDiscosDuros(DiscosDuro discosDuro)
        {
            executer.InsertDiscosDuros(discosDuro);
        }
        public List<DiscosDuro> MostrarDiscosDuros()
        {
            return executer.MostrarDiscosDuros();
        }
        public void UpdateDiscosDuros(DiscosDuro discosDuro)
        {
            executer.UpdateDiscosDuros(discosDuro);
        }
        public void DeleteDiscosDuros(int id)
        {
            executer.DeleteDiscosDuros(id);

        }
        private static CDiscosDuros_Datos data = new CDiscosDuros_Datos();
        public static List<DiscosDuro> IndexDiscosDuros()
        {
            return data.IndexDiscosDuros();
        }
        public DiscosDuro DiscosDurosDetail(int id)
        {
            return executer.DiscosDurosDetail(id);
        }
    }
}

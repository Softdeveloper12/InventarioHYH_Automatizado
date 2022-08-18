using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CMonitores_negocios
    {
        static CMonitores executer = new CMonitores();
        public void InsertMonitores(Monitore monitore)
        {
            executer.InsertMonitor(monitore);
        }
        public List<Monitore> MostrarMonitores()
        {
            return executer.MostrarMonitor();
        }
        public void UpdateMonitores(Monitore monitore)
        {
            executer.UpdateMonitor(monitore);
        }
        public void DeleteMonitores(int id)
        {
            executer.DeleteMonitor(id);

        }
        private static CMonitores data = new CMonitores();
        public static List<Monitore> IndexMonitor()
        {
            return data.IndexMonitor();
        }
        public Monitore MonitorDetail(int id)
        {
            return executer.MonitorDetail(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CMonitores
    {
        private Entities dbp = new Entities();

        public void InsertMonitor(Monitore Monitores)
        {
            dbp.Monitores.Add(Monitores);
            dbp.SaveChanges();
        }
        public List<Monitore> MostrarMonitor()
        {
            return dbp.Monitores.ToList();
        }
        public void UpdateMonitor(Monitore Monitores)
        {
            var registro = dbp.Monitores.First(a => a.id == Monitores.id);
            registro.Description = Monitores.Description;
            registro.Brand = Monitores.Brand;
            registro.Model = Monitores.Model;
            registro.Serial = Monitores.Serial;
            registro.Price = Monitores.Price;
            registro.ReservadoPor = Monitores.ReservadoPor;
            
            dbp.SaveChanges();
        }
        public void DeleteMonitor(int id)
        {
            var registro = dbp.Monitores.Where(set => set.id == id).FirstOrDefault();
            dbp.Monitores.Remove(registro);
            dbp.SaveChanges();

        }
        public List<Monitore> IndexMonitor()
        {
            using (var dbp = new Entities())
            {
                return dbp.Monitores.ToList();
            }
        }
        public Monitore MonitorDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.Monitores.Where(d => d.id == id).FirstOrDefault();
            }


        }
    }
}

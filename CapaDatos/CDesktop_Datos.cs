using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CDesktop_Datos
    {
        private Entities dbp = new Entities();

        public void InsertDesktop(Desktop desktop)
        {
            dbp.Desktops.Add(desktop);
            dbp.SaveChanges();
        }
        public List<Desktop> MostrarDesktop()
        {
            return dbp.Desktops.ToList();
        }
        public void UpdateDesktop(Desktop desktop)
        {
            var registro = dbp.Desktops.First(a => a.id == desktop.id);
            registro.Description = desktop.Description;
            registro.Brand = desktop.Brand;
            registro.Model = desktop.Model;
            registro.Serial = desktop.Serial;
            registro.ModelNumber = desktop.ModelNumber;
            registro.Price = desktop.Price;
            registro.ReservadoPor = desktop.ReservadoPor;   
            dbp.SaveChanges();
        }
        public void DeleteDesktop(int id)
        {
            var registro = dbp.Desktops.Where(set => set.id == id).FirstOrDefault();
            dbp.Desktops.Remove(registro);
            dbp.SaveChanges();

        }
        public List<Desktop> IndexDesktop()
        {
            using (var dbp = new Entities())
            {
                return dbp.Desktops.ToList();
            }
        }
        public Desktop DesktopDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.Desktops.Where(d => d.id == id).FirstOrDefault();
            }


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CAccesories_Datos
    {
        private Entities dbp = new Entities();

        public void InsertAccesorios(datos_Accesories accesories)
        {
            dbp.datos_Accesories.Add(accesories);
            dbp.SaveChanges();
        }
        public List<datos_Accesories> MostrarAccesorios()
        {
            return dbp.datos_Accesories.ToList();
        }
        public void UpdateAccesorios(datos_Accesories accesories)
        {
            var registro = dbp.datos_Accesories.First(a => a.id == accesories.id);
            registro.Brand = accesories.Brand;
            registro.Descripcion = accesories.Descripcion;
            registro.Serial = accesories.Serial;
            registro.Quantity = accesories.Quantity;
            registro.Price = accesories.Price;
            registro.ReservadoPor = accesories.ReservadoPor;

            dbp.SaveChanges();
        }
        public void DeleteAccesorios(int id)
        {
            var registro = dbp.datos_Accesories.Where(set => set.id == id).FirstOrDefault();
            dbp.datos_Accesories.Remove(registro);
            dbp.SaveChanges();

        }
        public List<datos_Accesories> IndexAccesories()
        {
            using (var dbp = new Entities())
            {
                return dbp.datos_Accesories.ToList();
            }
        }
        public datos_Accesories AccesoriesDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.datos_Accesories.Where(d => d.id == id).FirstOrDefault();
            }


        }
    }
}

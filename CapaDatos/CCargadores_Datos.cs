using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CCargadores_Datos
    {
        private Entities dbp = new Entities();

        public void Insertcargadores(datos_Cargadores cargadores)
        {
            dbp.datos_Cargadores.Add(cargadores);
            dbp.SaveChanges();
        }
        public List<datos_Cargadores> MostrarCargadores()
        {
            return dbp.datos_Cargadores.ToList();
        }
        public void UpdateCargadores(datos_Cargadores cargadores)
        {
            var registro = dbp.datos_Cargadores.First(a => a.id == cargadores.id);
            registro.Brand = cargadores.Brand;
            registro.Type = cargadores.Type;
            registro.Quantity = cargadores.Quantity;
            registro.Price = cargadores.Price;
            registro.ReservadoPor = cargadores.ReservadoPor;    
            dbp.SaveChanges();
        }
        public void DeleteCargadores(int id)
        {
            var registro = dbp.datos_Cargadores.Where(set => set.id == id).FirstOrDefault();
            dbp.datos_Cargadores.Remove(registro);
            dbp.SaveChanges();

        }
        public List<datos_Cargadores> IndexCargadores()
        {
            using (var dbp = new Entities())
            {
                return dbp.datos_Cargadores.ToList();
            }
        }
        public datos_Cargadores CargadoresDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.datos_Cargadores.Where(d => d.id == id).FirstOrDefault();
            }


        }
    }
}

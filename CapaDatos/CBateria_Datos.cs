using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CBateria_Datos
    {
        private Entities dbp = new Entities();

        public void InsertBateria(Bateria bateria)
        {
            dbp.Baterias.Add(bateria);
            dbp.SaveChanges();
        }
        public List<Bateria> MostrarBateria()
        {
            return dbp.Baterias.ToList();
        }
        public void UpdateBateria(Bateria bateria)
        {
            var registro = dbp.Baterias.First(a => a.id == bateria.id);
            registro.Quantity = bateria.Quantity;
            registro.Type = bateria.Type;
            registro.Model = bateria.Model;
            registro.Price = bateria.Price;
            registro.ReservadoPor = bateria.ReservadoPor;   
            dbp.SaveChanges();
        }
        public void DeleteBateria(int id)
        {
            var registro = dbp.Baterias.Where(set => set.id == id).FirstOrDefault();
            dbp.Baterias.Remove(registro);
            dbp.SaveChanges();

        }
        public List<Bateria> IndexBateria()
        {
            using (var dbp = new Entities())
            {
                return dbp.Baterias.ToList();
            }
        }
        public Bateria BateriaDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.Baterias.Where(d => d.id == id).FirstOrDefault();
            }


        }
    }
}

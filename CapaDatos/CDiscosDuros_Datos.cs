using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CDiscosDuros_Datos
    {
        private Entities dbp = new Entities();

        public void InsertDiscosDuros(DiscosDuro discosDuro)
        {
            dbp.DiscosDuros.Add(discosDuro);
            dbp.SaveChanges();
        }
        public List<DiscosDuro> MostrarDiscosDuros()
        {
            return dbp.DiscosDuros.ToList();
        }
        public void UpdateDiscosDuros(DiscosDuro discosDuro)
        {
            var registro = dbp.DiscosDuros.First(a => a.id == discosDuro.id);
            registro.Capacity = discosDuro.Capacity;
            registro.Type = discosDuro.Type;
            registro.Quantity = discosDuro.Quantity;
            registro.Size = discosDuro.Size;
            registro.Price = discosDuro.Price;
            registro.ReservadoPor = discosDuro.ReservadoPor;    

            dbp.SaveChanges();
        }
        public void DeleteDiscosDuros(int id)
        {
            var registro = dbp.DiscosDuros.Where(set => set.id == id).FirstOrDefault();
            dbp.DiscosDuros.Remove(registro);
            dbp.SaveChanges();

        }
        public List<DiscosDuro> IndexDiscosDuros()
        {
            using (var dbp = new Entities())
            {
                return dbp.DiscosDuros.ToList();
            }
        }
        public DiscosDuro DiscosDurosDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.DiscosDuros.Where(d => d.id == id).FirstOrDefault();
            }


        }
    }
}

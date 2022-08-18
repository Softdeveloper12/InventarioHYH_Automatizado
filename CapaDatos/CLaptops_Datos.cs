using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CLaptops_Datos
    {
        private Entities dbp = new Entities();

        public void InsertLaptop(laptop laptop)
        {
            dbp.laptops.Add(laptop);
            dbp.SaveChanges();
        }
        public List<laptop> MostrarLaptop()
        {
            return dbp.laptops.ToList();
        }
        public void UpdateLaptop(laptop laptop)
        {
            var registro = dbp.laptops.First(a => a.id == laptop.id);
            registro.Description = laptop.Description;
            registro.Brand = laptop.Brand;
            registro.Model = laptop.Model;
            registro.Serial = laptop.Serial;
            registro.ModelNumber = laptop.ModelNumber;
            registro.Price = laptop.Price;
            registro.ReservadoPor = laptop.ReservadoPor;  
            dbp.SaveChanges();
        }
        public void DeleteLaptop(int id)
        {
            var registro = dbp.laptops.Where(set => set.id == id).FirstOrDefault();
            dbp.laptops.Remove(registro);
            dbp.SaveChanges();

        }
        public List<laptop> IndexLaptop()
        {
            using (var dbp = new Entities())
            {
                return dbp.laptops.ToList();
            }
        }
        public laptop LaptopDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.laptops.Where(d => d.id == id).FirstOrDefault();
            }


        }
    }
}

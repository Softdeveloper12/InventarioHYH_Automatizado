using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDatos
{
    public class CMemoriaRam_Datos
    {
        private Entities dbp = new Entities();

        public void InsertMemoriaRam(datos_Ram datos_Ram)
        {
            dbp.datos_Ram.Add(datos_Ram); 
            dbp.SaveChanges();
        }
        public List<datos_Ram> MostrarMemoriaRam()
        {
            return dbp.datos_Ram.ToList();
        }
        public void UpdateMemoriaRam(datos_Ram datos_Ram)
        {
            var registro = dbp.datos_Ram.First(a => a.id == datos_Ram.id);
            registro.Descripcion = datos_Ram.Descripcion;
            registro.Capacity = datos_Ram.Capacity;
            registro.FormFactor = datos_Ram.FormFactor;
            registro.Frequency = datos_Ram.Frequency;
            registro.Price = datos_Ram.Price;
            registro.Slot = datos_Ram.Slot;
            registro.Quantity = datos_Ram.Quantity;
            registro.Observacion = datos_Ram.Observacion;
            registro.ReservadoPor = datos_Ram.ReservadoPor;   
            dbp.SaveChanges();
        }
        public void DeleteMemoriaRam(int id)
        {
            var registro = dbp.datos_Ram.Where(set => set.id == id).FirstOrDefault();
            dbp.datos_Ram.Remove(registro);
            dbp.SaveChanges();

        }
        public List<datos_Ram> IndexMemoriaRam()
        {
            using (var dbp = new Entities())
            {
                return dbp.datos_Ram.ToList();
            }
        }
        public datos_Ram MemoriaRamDetail(int id)
        {
            using (var dbp = new Entities())
            {
                return dbp.datos_Ram.Where(d => d.id == id).FirstOrDefault();
            }


        }
    }
}

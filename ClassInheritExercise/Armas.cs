using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Armas : IEscopeta
    {
        public double cadencia;
        public double retroceso;
        public double distancia;
        public int daño;
        public int manejabilidad;

        public Armas(double cadencia, double retroceso,double distancia, int daño, int manejabilidad)
        {
            this.cadencia = cadencia;
            this.retroceso = retroceso;
            this.daño = daño;
            this.distancia = distancia;
            this.manejabilidad = manejabilidad;
        }
        
        public void ejemploherenciaarmas1()
        {
            //vacio
        }
    }
}

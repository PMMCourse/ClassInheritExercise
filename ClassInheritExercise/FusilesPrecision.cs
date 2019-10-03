
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
   public  class FusilesPrecision : Armas, ISecundarias
    {
        public string Fusilp;

        FusilesPrecision(string fusilp, double cadencia, double retroceso, double distancia, int daño, int manejabilidad) : base(cadencia, retroceso, distancia, daño, manejabilidad)
        {
            //vacio
        }
        public static void FusilesPrecisionBo2()
        {
            FusilesPrecision fp = new FusilesPrecision("DSR-50", 3.56, 17.67, 19.67, 10, 9);

            //Console.WriteLine("Arma= " + fp.Fusilp, fp.cadencia, fp.retroceso, fp.distancia, fp.daño, fp.manejabilidad);
        }

        public void IntroduccionDeArmasSecundarias()
        {
            //Con un francotirador siempre es importante llevar una secundaria, para el cuerpo a cuerpo
        }
    }
}

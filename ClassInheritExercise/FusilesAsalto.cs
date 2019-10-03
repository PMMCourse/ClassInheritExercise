using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class FusilesAsalto : Armas
    {
        public string Armafusil;

        FusilesAsalto(string armafusil, double cadencia, double retroceso, double distancia, int daño, int manejabilidad) : base(cadencia, retroceso, distancia, daño, manejabilidad)
        {
            //vacio
        }

        public static void FusilesBo2()
        {
            FusilesAsalto fa = new FusilesAsalto("SCAR-H", 12.45, 16.89, 14.56, 8, 8);

            /*Console.WriteLine("Arma= " + fa.Armafusil, fa.cadencia, fa.retroceso, fa.distancia, fa.daño, fa.manejabilidad);
            Console.ReadKey();*/
        }
    }
}

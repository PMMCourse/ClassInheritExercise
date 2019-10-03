using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{

    public class Subfusiles : Armas
    {
        public string Armasubf;

        Subfusiles(string armasubf, double cadencia, double retroceso, double distancia, int daño, int manejabilidad) : base(cadencia, retroceso, distancia, daño, manejabilidad)
        {
            //vacio
        }
       public static void SubfusilesBo2()
        {
            Subfusiles sbf = new Subfusiles("MP7", 16.76, 13.65, 7.56, 6, 7);
            Subfusiles sbf1 = new Subfusiles("Peaceekeaper", 17.89, 10.56, 13.23, 7, 8);
            Subfusiles sbf2 = new Subfusiles("Skorpion EVO", 16.76, 13.65, 7.56, 5, 7);

            /*Console.WriteLine("Arma= " + sbf.Armasubf, sbf.cadencia, sbf.retroceso, sbf.distancia, sbf.daño, sbf.manejabilidad);
            Console.WriteLine("Arma= " + sbf1.Armasubf, sbf1.cadencia, sbf1.retroceso, sbf1.distancia, sbf1.daño, sbf1.manejabilidad);
            Console.WriteLine("Arma= " + sbf2.Armasubf, sbf2.cadencia, sbf2.retroceso, sbf2.distancia, sbf2.daño, sbf2.manejabilidad);
            Console.ReadKey();*/

        }
                                                                                 

    }
}


  /*  La cadencia, el retroceso y la distancia van en un intervalo entre 0 y 20       
    decimales incluidos, a mayor sea el número, mayor es la cadencia del arma en disparos.
    La manejabilidad y el daño (agilidad del arma al jugar con ella, más tu habilidad), son de tipo entero
    y va del 1 al 10, mientras más manejabilidad, el arma es más ágil y fácil de manejar. 
    Son todos subfusiles del Black Ops II, el CoD al que más horas he jugado.*/
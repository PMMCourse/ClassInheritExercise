using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Campesino jugador1 = new Mago("mago",12,1000,1000,25);
            Campesino jugador2 = new Mago("mago2", 21, 1500, 1500, 50);
            Campesino jugador3 = new Guerrero("guerrero",5,800,800,60);
            Campesino jugador4 = new Guerrero("guerrero2",10,900,900,180);
            Campesino jugador5 = new Arquero("arquero",200,200,1,190);
            Campesino jugador6 = new Arquero("arquero2",600,550,30,168);

         
            jugador1.unirseFiesta();
            jugador2.unirseFiesta();
            jugador3.unirseFiesta();
            jugador4.unirseFiesta();
            jugador5.unirseFiesta();
            jugador6.unirseFiesta();

            jugador1.SubirNIvel();
            jugador3.SubirNIvel();
            jugador6.SubirNIvel();

        }
    }
}

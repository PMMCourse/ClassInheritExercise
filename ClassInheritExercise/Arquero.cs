using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Arquero:Campesino,IArquero
    {
        private int nivelataque;
        public int nivelAtaque { get; set; }
        
        public int velocidadAtacando { get; set; }

        public Arquero(String nombre, int hpTotal, int mpTotal, int nivel, int nivelAtaque) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.nivelataque = nivelAtaque;
        }
        public override void unirseFiesta()
        {
            Console.WriteLine("bienvenido a la fiesta Arquero");
        }
        public void subirNivel() {
            nivel = nivel += 1;
         }
    }
}

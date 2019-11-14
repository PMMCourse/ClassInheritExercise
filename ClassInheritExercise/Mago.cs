using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
   public class Mago:Campesino,ICampesinos
    {
        public int hp { get; set; }

        public int mp { get; set; }
       
        public int nivel { get; set; }
       
        public int poder { get; set; }

        public Mago(string nombre, int nivel, int hpTotal, int mpTotal, int poderHabilidad) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.poder = poderHabilidad;

        }
        public override void unirseFiesta()
        {
            Console.WriteLine("bienvenido a la fiesta Mago");
        }

        

        public void UnirseGremio()
        {
            Console.WriteLine("bienvenido al Gremio Mago");
        }
    }
}

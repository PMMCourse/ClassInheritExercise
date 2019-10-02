using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Asesino:Campesino, IAtaque_Furia
    {
        public int Agilidad { get; set; }
        public Asesino(string nombre, int salud): base(nombre, salud)
        {
            Agilidad = 200;
        }
        public void Sigilo()
        {

        }
        public override void Subir_Estadistica()
        {
            Salud += 10;
            Pa += 20;
            Pd += 10;
            Agilidad += 20;
        }
        public void Ataque_final()
        {

        }
    }
}

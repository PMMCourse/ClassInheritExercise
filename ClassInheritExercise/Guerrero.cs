using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Guerrero : Campesino, IAtaque_Furia
    {
        public int Energia { get; set; }
        public Guerrero(string nombre, int salud) : base(nombre,salud)
        {
            Energia = 120;
        }
        public void Proteger()
        {
        }
        public override void Subir_Estadistica()
        {
            Salud += 10;
            Pa += 10;
            Pd += 20;
            Energia += 20;
        }

        public void Ataque_final()
        {
        }
    }
    
}

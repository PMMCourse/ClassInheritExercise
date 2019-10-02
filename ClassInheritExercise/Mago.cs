using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Mago: Campesino,IAtaque_Hechizo, IGremioMagos
    {
        public int Mana { get; set; }
        public Mago(string nombre, int salud): base(nombre, salud)
        {
            Mana = 150;
        }
        public void Curacion()
        {
        }
        public override void Subir_Estadistica()
        {
            Salud += 10;
            Pa += 15;
            Pd += 15;
            Mana += 20;
        }
        public void Hechizo_final()
        {
        }
        public void Crear_Gremio()
        {
        }
        public void Unirse_Gremio()
        {
        }
    }
}

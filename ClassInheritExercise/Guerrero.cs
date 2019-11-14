using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Guerrero : Campesino,IGuerrero
    {
        private int nDefensa;
       
        public int ndefensa { get; set; }
        
        public string NombreMochila { get; set; }
       
        public Guerrero(string nombre, int nivel, int hpTotal, int mpTotal, int defensa) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.ndefensa = defensa;
        }

        public override void unirseFiesta()
        {
            Console.WriteLine("bienvenido a la fiesta Guerrero");
        }
        public void CrearFiesta()
        {
            Console.WriteLine("has creado una partida");
        }
    }
}

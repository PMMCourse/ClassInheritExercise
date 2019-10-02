using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Guerrero : Campesino
    {
        //Atributos

        int fuerza { get; protected set; }
        int aguante { get; protected set; }
        int vitalidad { get; protected set; }

        //Contructor

        public Guerrero(int f,int a, int v) : base(HP, MP, EXP, n, nivel)
        {
            this.fuerza = f;
            this.aguante = a;
            this.vitalidad = v;
        }

        //Metodos

        private void Defenderse();
        private void Cargar();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Picaro : Campesino
    {
        //Atributos

        int evasion { get; protected set; }
        int velocidad { get; protected set; }

        //Contructor

        public Picaro (int e,int v) : base(HP, MP, EXP, n, nivel)
        {
            this.evasion = e;
            this.velocidad = v;

        }

        //Metodos

        private void Robar();
        private void Invisible();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Sacedorte : Campesino, Ihechizos

    {
        //Atributos

        int espiritu;

        //Constructor
        public Sacerdote (int esp) : base (HP, MP,  EXP,n,nivel)
        {
            this.espiritu = esp;
        }

        //Metodos

        private void Curar();
        private void Revivir();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class  Mago : Campesino, Ihechizos
    {
        //Atributos
        int intelecto { get; protected set; }
        int AP { get; protected set; }



        //Contructor

        public Mago (int ci,int AP) : base(HP, MP, EXP, n, nivel)
        {
            this.intelecto = ci;
            this.AP = AP;
        }

        //Metodos

        private void Regenerar_mana();
        private void Meditar();
        public void UnirseGremio();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
  public abstract class Campesino
    {
        public string nombre { get; set; }
        public int HP
        {

            get => HP;
            set
            {
                this.HP = value;
            }
        }
        public int MP
        {
            get => MP;
            set
            {
                this.MP = value;
            }
        }
        public int nivel
        {
            get => nivel;
            set
            {
                this.nivel = value;
            }
        }
        public Campesino(string nombre, int nivel, int hpTotal, int mpTotal)
        {
            this.nombre = nombre;
            this.HP = hpTotal;
            this.MP = mpTotal;
            this.nivel = nivel;
        }
        public int  SubirNIvel()
        {
            return nivel +=1;
        }
        public abstract void unirseFiesta();

    }
    
}

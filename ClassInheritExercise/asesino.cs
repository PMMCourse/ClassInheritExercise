using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class asesino:campesino, Iexplorador
    {
        public int ad { set; get; }
        public Boolean invisible { set; get; }
        public asesino(int hp, int mp, int exp)
        {
            this.hp = hp;
            this.mp = mp + 200;
            this.exp = exp;
        }

        public void brujula()
        {
            throw new NotImplementedException();
        }

        public void mapa()
        {
            throw new NotImplementedException();
        }
    }
}

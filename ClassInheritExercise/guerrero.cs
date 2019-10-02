using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class guerrero : campesino , Iexplorador
    {
        public int ad { set; get; }
        public int defensa { set; get; }
        public guerrero(int hp, int mp, int exp){
            this.hp = hp + 200;
            this.mp = mp;
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

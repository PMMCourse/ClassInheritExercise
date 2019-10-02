using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class mago:campesino , Icurandero
    {
        public int ap { set; get; }
        public mago(int hp, int mp, int exp) {
            this.hp = hp;
            this.mp = mp + 200;
            this.exp = exp;
        }

        public void curar()
        {
            this.hp = hp + 200;
            throw new NotImplementedException();
        }

        public void reanimar()
        {
            this.hp = 500;
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    // Interfaz Tanque
    interface Tank
    {
        // Metodo Bloquear
        void Block();
        // Metodo Provocar Enemigo
        void Provoke();
        // Metodo Enfurecerse (Buff Hp, Def, Mdef)
        void Berseker();
    }
}

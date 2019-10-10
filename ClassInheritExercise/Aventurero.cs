using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise {
    //Esta interfaz está metido un poco obligada, la idea
    //es crear un guerrero que pueda obtener los métodos
    //de un aventurero. Básicamente por darle uso.
    interface Aventurero {
        void CorrerRapido();
        void DescubrirObjeto();
    }
}

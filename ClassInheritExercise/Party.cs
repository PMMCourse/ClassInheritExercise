using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise {
    //He mirado un poco por Internet
    //el rollo Party de los juegos de MMO
    //y no encuentro unas propiedades fijas.
    //Me hago la idea de que tendrán un server y un límite de usuarios.
    class Party {
        private string nombre;
        private int maxJugadores;

        public string Nombre { get => nombre; set => nombre = value; }
        public int MaxJugadores { get => maxJugadores; set => maxJugadores = value; }
    }
}

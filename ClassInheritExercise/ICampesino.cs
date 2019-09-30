using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    interface ICampesino
    {
        //Metodos Basicos
        string Nombre { get;}
        int Vida {get;}
        int Aguante {get;}
        int Nivel {get;}
        int XP { get; }
        int Dinero {get;}

        //Metodos de comercio
        void ComprarItem();
        void VenderItem();
        void Tradear();

        //Metodos de Equipo
        void crearPartie();
        void unirsePartie();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    // Clase Sacerdote que Hereda de Campesino
    class Priest : Campesino
    {
        //A
        protected short mp;
        protected byte lvlCure;

        //C
        public Priest()
        {
            // Por Defecto...
        }
        public Priest(string nick, short hp, int exp, byte atk, byte def, byte mdef, byte aspd, byte crit, short mp) : base(nick, hp, exp, atk, mdef, def, aspd, crit)
        {
            this.hp *= lvlCure;
            this.atk *= lvlCure;
            this.def *= lvlCure;
            this.mdef *= lvlCure;
            this.mp = mp;
        }

        //M
        void Heal()
        {
            Console.WriteLine("Te Curo solo un poquito");
        }
        void Levetation()
        {
            Console.WriteLine("'Poh vuelo un poco'");
        }
        protected void AddToGuild(string guild)
        {

        }
    }

    // Clase Sacerdote1 que Hereda de Campesino e implementa la Interfaz ArzoBispo
    class Priest1 : Priest, ArchBishop
    {
        //A


        //C
        public Priest1()
        {
            // Por Defecto...
        }

        //M
        void ArchBishop.Buff()
        {
            Console.WriteLine("Buff");
        }

        void ArchBishop.HolyRain()
        {
            Console.WriteLine("Lluvia Celestial");
        }

        void ArchBishop.Resurrect()
        {
            Console.WriteLine("Resucitar");
        }
    }

    // Clase Sacerdote2 que Hereda de Campesino e implementa la Interfaz ArzoBispo
    class Priest2 : Priest, Sura
    {
        //A


        //C
        public Priest2()
        {
            // Por Defecto...
        }

        //M
        void Sura.AsuraStrike()
        {
            Console.WriteLine("Asura Strike");
        }
        void Sura.CallSpirits()
        {
            Console.WriteLine("Llamar Espiritus");
        }
        void Sura.PalmStrike()
        {
            Console.WriteLine("Palm Strike");
        }
    }
}

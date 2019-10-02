using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    // Clase Caballero que Hereda de Campesino
    class Knight : Campesino
    {
        //A
        protected short fury;

        //C
        public Knight()
        {
            // Por Defecto...
        }
        public Knight(string nick, short hp, int exp, byte atk, byte def, byte mdef, byte aspd, byte crit, short fury) : base(nick, hp, exp, atk, mdef, def, aspd, crit)
        {
            this.hp += 20;
            this.def += 20;
            this.fury = fury;
        }

        //M
        protected void Charge()
        {
            Console.WriteLine("Cargar");
        }
        protected void SwordSwirl()
        {
            Console.WriteLine("Remolino de Espada");
        }
        protected void AddToGuild(string guild)
        {

        }
    }

    // Clase Caballero1 que Hereda de Campesino e implementa la Interfaz Tank
    class Knight1 : Knight, Tank
    {
        //A


        //C
        public Knight1()
        {
            // Por Defecto...
        }

        //M
        void Tank.Berseker()
        {
            Console.WriteLine("Enfurecerse");
        }
        void Tank.Block()
        {
            Console.WriteLine("Bloquear");
        }
        void Tank.Provoke()
        {
            Console.WriteLine("Provocar");
        }
    }

    // Clase Caballero2 que Hereda de Campesino e implementa la Interfaz Paladin
    class Knight2 : Knight, Paladin
    {
        //A


        //C
        public Knight2()
        {
            // Por Defecto...
        }

        //M
        void Paladin.Consagration()
        {
            Console.WriteLine("Consagración");
        }
        void Paladin.HolyCross()
        {
            Console.WriteLine("Cruz Sagrada");
        }

    }
}

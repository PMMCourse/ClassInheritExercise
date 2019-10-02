using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    // Clase Mago que Hereda de Campesino
    public class Mage : Campesino
    {

        //A
        protected short mp;
        protected byte matk;

        //C
        public Mage()
        {
            // Por Defecto...
        }
        public Mage(string nick, short hp, int exp, byte atk, byte def, byte mdef, byte aspd, byte crit, short mp, byte matk) : base(nick, hp, exp, atk, mdef, def, aspd, crit)
        {
            this.mdef = Convert.ToByte(mdef * 2);
            this.mp = mp;
            this.matk = matk;
        }

        //M
        protected void RangedAttack()
        {
            // Algoritmo Lógico
            Console.WriteLine("Te pego de lejos 'suh primoh'");
        }
        protected void ArcaneImpulse()
        {
            // Algoritmo Lógico
            Console.WriteLine("Impulso Arcano");
        }
        protected void AddToGuild(string guild)
        {

        }
    }

    // Clase Mago1 que Hereda de Campesino e implementa la Interfaz Sorcerer
    public class Mage1 : Mage, Sorcerer
    {

        //A


        //C
        public Mage1()
        {
            // Por Defecto...
        }

        //M
        void Sorcerer.Cyclone()
        {
            Console.WriteLine("Ciclón");
        }

        void Sorcerer.EarthSpike()
        {
            Console.WriteLine("Pincho de Tierra");
        }

        void Sorcerer.FireBolt()
        {
            Console.WriteLine("Rayo de Fuego");
        }
    } 

    // Clase Mago2 que Hereda de Campesino e implementa la Interfaz Warlock
    public class Mage2 : Mage, Warlock
    {

        //A


        //C
        public Mage2()
        {
            // Por Defecto...
        }

        //M
        void Warlock.DesperateCurse()
        {
            Console.WriteLine("Maldición de Agonía");
        }

        void Warlock.SoulDrain()
        {
            Console.WriteLine("Drenaje de Alma");
        }

        void Warlock.SummonVoidPet()
        {
            Console.WriteLine("Invocación de Mascota del Vacio");
        }
    }
}

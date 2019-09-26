using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseRelations
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }


    public abstract class Campesino
    {
        //ATRIBUTOS PRINCIPALES:

        int hpTotal, mpTotal, nivel;
        string nombre;

        public abstract Campesino(string nombre, int nivel, int hpTotal, int mpTotal)
        {
            this.nombre = nombre;
            this.nivel = nivel;
            this.hpTotal = hpTotal;
            this.mpTotal = mpTotal;
        }

        //SET Y GET

        public int hpTotal { get; set; }
        public int mpTotal { get; set; }
        public int nivel { get; set; }
        public string nombre { get; set; }

        //METODOS:

        public abstract void unirseMazmorra()
        {

        }

    }

    public class Mago : Campesino
    {
        private int poderHabilidad;

        public Mago(string nombre, int nivel, int hpTotal, int mpTotal, int poderHabilidad) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.poderHabilidad = poderHabilidad;

        }
        public int poderHabilidad { get; set; }
    }


    public class Guerrero : Campesino
    {
        private int defensa;

        public Guerrero(string nombre, int nivel, int hpTotal, int mpTotal, int defensa) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.defensa = defensa;
        }

        public int defensa { get; set; }
    }

    public class Arquero : Campesino
    {
        private int ataque;

        public Arquero(string nombre, int nivel, int hpTotal, int mpTotal, int ataque) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.ataque = ataque;
        }

        public int ataque { get; set; }
    }


}

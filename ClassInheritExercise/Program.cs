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
            Campesino pj1 = new Arquero("Arquero1",70,700,1200,1900);
            Campesino pj2 = new Mago("Mago1", 34, 600, 2500, 670);
            Campesino pj3 = new Guerrero("Guerrero1", 98, 5000, 3000, 890);

            pj1.UnirseFiesta();
            pj2.UnirseFiesta();
            pj3.UnirseFiesta();

        }
    }

    public abstract class Campesino
    {
        public int HpTotal { get; set; }
        public int MpTotal { get; set; }
        public int Nivel { get; set; }
        public string Nombre { get; set; }

        public abstract Campesino(string nombre, int nivel, int hpTotal, int mpTotal)
        {
            this.nombre = nombre;
            this.nivel = nivel;
            this.hpTotal = hpTotal;
            this.mpTotal = mpTotal;
        }

        public abstract void UnirseFiesta();
    }

    public class Mago : Campesino, Sanador
    {
        public bool Pociones { get; set; }
        public int PoderHabilidad { get; set; }

        public Mago(string nombre, int nivel, int hpTotal, int mpTotal, int poderHabilidad) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.poderHabilidad = poderHabilidad;
        }
        public void Revivir()
        {
            Console.WriteLine("Has revivido a tus aliados");
        }

        public void UnirseFiesta()
        {
            Console.WriteLine("!Mago!, Te has unido a una fiesta");
        }

    }

    public class Guerrero : Campesino, Explorador
    {
        public int Defensa { get; set; }
        public string Mochila { get; set; }

        public Guerrero(string nombre, int nivel, int hpTotal, int mpTotal, int defensa) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.defensa = defensa;
        }

        public void UnirseGremio()
        {
            Console.WriteLine("Guerrero. Acabas de unirte a un GREMIO.");
        }

        public void UnirseFiesta()
        {
            Console.WriteLine("!Gurerrero!, Te has unido a una fiesta");
        }
    }

    public class Arquero : Campesino, Asesino
    {
        public int Ataque { get; set; }
        public int VelocidadAtaque { get; set; }

        public Arquero(string nombre, int nivel, int hpTotal, int mpTotal, int ataque) : base(nombre, nivel, hpTotal, mpTotal)
        {
            this.ataque = ataque;
        }

        public void HacerseInvisible()
        {
            Console.WriteLine("Ahora eres invisible");
        }

        public void UnirseFiesta()
        {
            Console.WriteLine("!Arquero!, Te has unido a una fiesta");
        }
    }

    public interface Explorador
    {
        string Mochila { get; set; }
        void UnirseGremio();
    }

    public interface Sanador
    {
        public bool Pociones { get; set; }
        void Revivir();
    }

    public interface Asesino
    {
        public int VelocidadAtaque { get; set; }
        void HacerseInvisible();
    }
}

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

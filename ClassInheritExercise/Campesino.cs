using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public abstract class Campesino
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Salud { get; set; }
        public int Pa { get; set; }
        public int Pd { get; set; }
        public string Mascota { get; set; }
        public Campesino(string nombre, int salud)
        {
            Nombre = nombre;
            Salud = salud;
            Nivel = 1;
        }
        public void Unirse_Party()
        {
        }
        public void Crear_Party()
        {
        }
        public void añadir_mascota(string mascota)
        {
            Mascota = mascota;
        }
        public void Subir_nivel()
        {
            Nivel++;
            Console.WriteLine(Nombre+" ha subido de nivel");
        }
        public virtual void Subir_Estadistica()
        {
            Salud += 10;
        }
    }


    public interface IAtaque_Hechizo
    {
        void Hechizo_final();
    }
    public interface IAtaque_Furia
    {
        void Ataque_final();
    }
    public interface IGremioMagos
    {
        void Crear_Gremio();
        void Unirse_Gremio();
    }
}



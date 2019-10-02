using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Tanque : ICampesino
    {
        private string Nombre;

        private int Vida;

        private int Aguante;

        private int Nivel;

        private int XP;

        private int Dinero;

        public Tanque(string nombre, int vida, int aguante, int nivel, int XP, int dinero)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Aguante = aguante;
            this.Nivel = nivel;
            this.XP = XP;
            this.Dinero = dinero;
        }
        public Tanque()
        {
            this.Nombre = "";
            this.Vida = 100;
            this.Aguante = 100;
            this.Nivel = 1;
            this.XP = 0;
            this.Dinero = 0;
        }
        //Metodos Basicos
        string ICampesino.Nombre { get;}
         int ICampesino.Vida { get; }
         int ICampesino.Aguante { get; }
         int ICampesino.Nivel { get; }
         int ICampesino.XP { get; }
         int ICampesino.Dinero { get; }

        //Metodos de comercio
        public void ComprarItem(){}
        public void Tradear(){}
        public void VenderItem(){}

        //Metodos propios del tanque
        public void UsarHabilidad(){}
        public void Defender(){}

        //Metodos de Equipo
        public void crearPartie() { }
        public void unirsePartie() { }
    }
}

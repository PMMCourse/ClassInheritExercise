using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Guerrero : ICampesino
    {
        private string Nombre;

        private int Vida;

        private int mana;

        private int Aguante;

        private int Nivel;

        private int XP;

        private int Dinero;

        public Guerrero(string nombre, int vida, int mana, int aguante, int nivel, int XP, int dinero)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.mana = mana;
            this.Aguante = aguante;
            this.Nivel = nivel;
            this.XP = XP;
            this.Dinero = dinero;
        }
        public Guerrero()
        {
            this.Nombre = "";
            this.Vida = 100;
            this.mana = 100;
            this.Aguante = 100;
            this.Nivel = 1;
            this.XP = 0;
            this.Dinero = 0;
        }
        //Metodos Basicos
        string ICampesino.Nombre { get; }
        int ICampesino.Vida { get; }
        int ICampesino.Aguante { get; }
        int ICampesino.Nivel { get; }
        int ICampesino.XP { get; }
        int ICampesino.Dinero { get; }

        //Metodos de comercio
        public void ComprarItem() { }
        public void Tradear() { }
        public void VenderItem() { }

        //Metodos propios del Guerrero
        public void usarHabilidad() { }
        public void AtaqueFisico() { }

        //Metodos de Equipo
        public void crearPartie(){}
        public void unirsePartie(){}
    }
}

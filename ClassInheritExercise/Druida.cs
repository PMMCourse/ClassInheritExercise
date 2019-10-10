using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise {
    class Druida : Campesino {
        private byte magia;

        public Druida(string nombre, string pass, byte nivel, byte salud, byte mana, byte experiencia, byte ataque, byte defensa, byte magia) {
            Nombre = nombre;
            Pass = pass;
            Nivel = Nivel;
            Salud = salud;
            Mana = mana;
            Experiencia = experiencia;
            Ataque = ataque;
            Defensa = defensa;
            Magia = magia;
        }

        public byte Magia { get => magia; set => magia = value; }

        public void LanzarHechizo() { }

        public void Curar() { }
    }
}

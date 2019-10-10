using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise {
    class Campesino {
        private string nombre, pass;

        //Ninguna de las propiedades van a superar los 100.
        private byte nivel, salud, mana, experiencia, ataque, defensa;

        public Campesino() { }

        public Campesino(string nombre, string pass, byte nivel, byte salud, byte mana, byte experiencia, byte ataque, byte defensa) {
            this.Nombre = nombre;
            this.Pass = pass;
            this.Nivel = nivel;
            this.Salud = salud;
            this.Mana = mana;
            this.Experiencia = experiencia;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }

        public byte Nivel { get => nivel; set => nivel = value; }
        public byte Salud { get => salud; set => salud = value; }
        public byte Mana { get => mana; set => mana = value; }
        public byte Experiencia { get => experiencia; set => experiencia = value; }
        public byte Ataque { get => ataque; set => ataque = value; }
        public byte Defensa { get => defensa; set => defensa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pass { get => pass; set => pass = value; }

        public void Atacar() { }

        public void Defender() { }

        public void SubirNivel() { }

        public void UnirParty(Party party) { }

        public void DejarParty(Party party) { }

    }
}

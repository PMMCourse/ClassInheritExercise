using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise {
    class Guerrero : Campesino {
        private string arma;
        //El daño de un arma se suma al ataque del personaje.
        //Todos los guerreros tienen un arma.
        private byte dano;
        
        public Guerrero(string nombre, string pass, byte nivel, byte salud, byte mana, byte experiencia, byte ataque, byte defensa, string arma, byte dano) {
            Nombre = nombre;
            Pass = pass;
            Nivel = nivel;
            Salud = salud;
            Mana = mana;
            Experiencia = experiencia;
            Ataque = ataque;
            Defensa = defensa;
            Arma = arma;
            Dano = dano;

        }
        public string Arma { get => arma; set => arma = value; }
        public byte Dano { get => dano; set => dano = value; }
    }
}

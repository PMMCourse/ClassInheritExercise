using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Campesino
    {
        //Atributos
        string nombre { get; protected set; }
        int nivel { get; protected set; }
        int HP { get; protected set; }
        int MP { get; protected set; }
        double EXP { get; protected set; }

    //Constructor

    public Campesino (int HP, int MP, double EXP, string n,int nivel) 
        {
            this.HP = HP;
            this.MP = MP;
            this.EXP = EXP;
            this.nombre = n;
            this.nivel = nivel;
        }

        //Metodos


        public void Atacar();
        public String Hablar(string text);
        public int Correr(int distancia, int velocidad);
        public void buscarGrupo();
        public void subirNivel(int EXP)
        {
            if (exp >= 100)
            {
                nivel++;
                exp = exp - 100;
            }
        }


    }
}

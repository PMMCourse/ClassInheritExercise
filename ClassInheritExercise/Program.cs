using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    using System;

    namespace Practica1PMM
    {
        class Program
        {
            public class Guerrero
            {
                //ATRIBUTOS Y GETTERS & SETTERS (CAMPESINO)
                public int hp { get; protected set; }
                public int mp { get; protected set; }
                public int nivel { get; protected set; }
                public string nombre { get; protected set; }
                public int exp { get; protected set; }

                //CONSTRUCTORES (GUERRERO)
                public Guerrero(string nombre, int nivel, int hp, int mp, int exp)
                {
                    this.nombre = nombre;
                    this.nivel = nivel;
                    this.hp = hp;
                    this.mp = mp;
                    this.exp = exp;
                }
                /// 
                /// ////////////////////////////////////////////////////////////////////////////////////////////
                ///
                //METODO PARA SUBIR DE NIVEL
                public void subirNivel(int exp)
                {
                    if (exp >= 100)
                    {
                        nivel++;
                        exp = exp - 100;
                    }
                }

                //METODO PARA BUSCAR PARTIDA EN EL JUEGO
                public void buscarPartida(string nombre, int nivel)
                {

                }

                //METODO PARA INVITAR A UN AMIGO Y CREAR UN GRUPO
                public void invitarAmigo(string nombre)
                {

                }
            }

            //INTERFAZ PARA ESPADACHIN
            interface Combatir
            {

                //Metodos

                void Espadazo();
                void Cubrirse();
            }
            //ATRIBUTOS Y GETTERS & SETTERS (ESPADACHIN)
            public class Espadachin : Guerrero, Combatir
            {
                public int ataque { get; protected set; }
                public int agilidad { get; protected set; }

                //CONSTRUCTORES (ESPADACHIN)
                public Espadachin(string nombre, int nivel, int hp, int mp, int exp, int ataque, int agilidad) : base(nombre, nivel, hp, mp, exp)
                {
                    this.ataque = ataque;
                    this.agilidad = agilidad;
                }

                public void Espadazo()
                {
                    throw new NotImplementedException();
                }

                public void Cubrirse()
                {
                    throw new NotImplementedException();
                }
            }
            ///
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //ATRIBUTOS Y GETTERS & SETTERS (MAGO)
            public class Mago : Guerrero
            {
                public int magia { get; protected set; }
                public int conjuro { get; protected set; }

                //CONSTRUCTORES (MAGO)
                public Mago(string nombre, int nivel, int hp, int mp, int exp, int magia, int conjuro) : base(nombre, nivel, hp, mp, exp)
                {
                    this.magia = magia;
                    this.conjuro = conjuro;
                }

            }

            ///
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //ATRIBUTOS Y GETTERS & SETTERS (NIGROMANTE)
            public class Nigromante : Guerrero
            {
                public int cura { get; protected set; }
                public int exorcismo { get; protected set; }

                //CONSTRUCTORES (NIGROMANTE)
                public Nigromante(string nombre, int nivel, int hp, int mp, int exp, int cura, int exorcismo) : base(nombre, nivel, hp, mp, exp)
                {
                    this.cura = cura;
                    this.exorcismo = exorcismo;
                }
            }


        }
    }
}

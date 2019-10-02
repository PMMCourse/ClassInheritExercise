using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        /* Para no liarme haciendolo
         * 
         * skaa-
         *      kollos-
         *      campesino-
         *      noble-
         *          kandra
         *          aloamtico
         *              brumoso
         *                  nacido de la bruma
         *  
         *  
         */


        public class skaa
        {
            int hp = 0, clavos = 0, dineros = 0, n_magia = 0;
            String nombre, descendencia, magia;

            public int hp { get; protected set; }
            public int clavos { get; protected set; }
            public int dineros { get; protected set; }
            public int n_magia { get; protected set; }
            public String nombre { get; protected set; }
            public String descendencia { get; protected set; }
            public String magia { get; protected set; }


            //constructor ska
            public skaa(int hp, int dineros,int clavos, String nombre) {
                this.hp = hp;
                this.dineros = dineros;
                this.clavos = clavos;
                this.nombre = nombre;
            }
            public void ganardineros { 
            
            }

        }


        public class kollos : skaa {

            public void changeskakol(int clavos,int hp){
                clavos=clavos + 4;
                hp = hp * 6;
            }
            public void BuscarAldea() { 
            
            }

        }


        public class campesino : skaa {

            public void changeskacam(int dineros) {
                dineros = dineros + 10000;

            }
        }


        public class noble : skaa {

            public void changeskanob(String descendencia) {
                descendencia = noble;
                dineros = dineros + 10000000;

            }
        }


        public class kandra : noble {

            public void changenobkan(int clavos, int hp)
            {
                clavos = clavos + 2;
                hp = hp * 1000000000;
            }
        }

        public class alomantico : noble { 
            
        }


        public class brumoso : alomantico {

            public void changealobru(int n_magia, String magia) {
                n_magia = 1;
                magia = brumoso;
            }
        }

        public class nacido : alomantico
        {

            public void changealobru(int n_magia, String magia)
            {
                n_magia = 16;
                magia = Nacido_de_la_bruma;
            }
        }


    }
}


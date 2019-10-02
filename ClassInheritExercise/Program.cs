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
    }

    public class Campesino
    {
        //Atributos base de campesino con getters y setters
        public int hp { get; protected set; }
        public int mp { get; protected set; }
        public int nivel { get; protected set; }
        public string nombre { get; protected set; }
        public int exp { get; protected set; }

        //Constructor para campesino
        public Campesino(string nombre, int nivel, int hp, int mp, int exp)
        {
            this.nombre = nombre;
            this.nivel = nivel;
            this.hp = hp;
            this.mp = mp;
            this.exp = exp;
        }

        //Metodo para unirse a mazmorra
        public void buscarMazmorra(string nombre, int nivel)
        {

        }

        //Metodo para buscar un grupo
        public void buscarGrupo()
        {

        }

        //metodo para subir de nivel
        public void subirNivel(int exp)
        {
            if (exp >= 100)
            {
                nivel++;
                exp = exp - 100;
            }
        }
    }

    interface Ilibromagia
    {
        void generarMana();
        void lanzarConjuro();
    }

    //Especializacion de campesino a guerrero
    public class Guerrero : Campesino
    {
        //atributos propios de guerrero
        public int defensa { get; protected set; }
        public int furia { get; protected set; }

        //Constructor de guerrero
        public Guerrero(string nombre, int nivel, int hp, int furia, int defensa, int exp) : base(nombre, nivel, hp, mp, exp)
        {
            this.defensa = defensa;
            base.mp = furia; //Cambio de mp(Maná) a furia que es el recuerso que gastan los guerreros
        }


    }

    //Especializaciion de campesino a mago
    public class Mago : Campesino, Ilibromagia
    {
        public int magia { get; protected set; }

        //uso de la interfaz
        private void LanzarConjuro() => throw new NotImplementedException();
        public void generarMana() => throw new NotImplementedException();
     

        public void lanzarConjuro()
        {
            throw new NotImplementedException();
        }

        public Mago(string nombre, int nivel, int hp, int mp, int magia, int exp) : base(nombre, nivel, hp, mp, exp)
        {
            this.magia = magia;
            base.nombre = nombre;

        }

    }

    //Especialidad de campesino a healer
    public class Healer : Campesino , Ilibromagia
    {
        public int cura { get; protected set; }


        public Healer(string nombre, int nivel, int hp, int mp, int cura, int exp) : base(nombre, nivel, hp, mp, exp)
        {
            this.cura = cura;
            base.nombre = nombre;

        }

        //uso de la interfaz

        void Ilibromagia.generarMana()
        {
            throw new NotImplementedException();
        }

        void Ilibromagia.lanzarConjuro()
        {
            throw new NotImplementedException();
        }
    }

    //Especialiidad de campesiino a cazador
    public class Cazador : Campesino
    {
        public int ataque { get; protected set; }
        public int enfoque { get; protected set; }

        public Cazador(string nombre, int nivel, int hp, int enfoque, int ataque, int exp) : base(nombre, nivel, hp, mp, exp)
        {
            this.ataque = ataque;
            base.mp = enfoque; //Cambio de mp(Maná) a enfoque que es el recurso que gastan los cazadores
        }

        //Los Cazadores tienen acceso a mascotas
        public class Mascota
        {

            public string nombreM { get; protected set; }
            public string tipo_animal { get; protected set; }

            public Mascota(string nombreM, string tipo_animal)
            {
                this.nombreM = nombreM;
                this.tipo_animal = tipo_animal;
            }
        }
    }
}

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
            Guerrero pepe = new Guerrero("Pepe", 300)
            {
                Pa = 200,
                Pd = 250
            };
            Mago juan = new Mago("Juan", 200)
            {
                Pa = 250,
                Pd = 200
            };
            Asesino pedro = new Asesino("Paco", 150)
            {
                Pa = 300,
                Pd = 150
            };
            pedro.añadir_mascota("pedrito");
            pepe.añadir_mascota("pepito");
            pepe.Ataque_final();
            juan.Curacion();
            pedro.Sigilo();
            juan.Hechizo_final();
            pedro.Ataque_final();
            pepe.Proteger();
            pepe.Subir_nivel();
            pepe.Subir_Estadistica();
            juan.Subir_nivel();
            juan.Subir_Estadistica();
            pedro.Crear_Party();
            pepe.Unirse_Party();
            juan.Crear_Gremio();        
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas =                                 //Declaración de la variable nueva
                new Grupo("Matematicas", "MAT5678");
            Grupo historia =                                 
                new Grupo("Historia", "HST1234");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("Juan", "123456");
            Alumno maria = new Alumno("Maria", "567890");
            Alumno pedro = new Alumno("Pedro", "246801");
            Alumno ana = new Alumno("Ana", "135790");
            Alumno pablo = new Alumno("Pablo", "345678");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(ana);
            historia.Alumnos.Add(pedro);

            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(maria);
            matematicas.Alumnos.Add(pedro);
            matematicas.Alumnos.Add(ana);
            matematicas.Alumnos.Add(pablo);

            foreach(Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " +
                    grupo.Codigo);
                Console.WriteLine("Materia: " +
                    grupo.Materia);
                Console.WriteLine("Lista de alumnos: ");
                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" +
                       alumno.Nombre);
                }
            }

            Console.Read();
        }
    }
}

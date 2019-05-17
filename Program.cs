using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            string usuario = "sisadmin";
            string contraseña = "admin3.0";
            string pregunta;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite su usuario");
                login = Console.ReadLine();

                Console.WriteLine("Digite su contraseña");
                password = Console.ReadLine();

                if ((login == usuario) && (password == contraseña))
                {
                    Console.WriteLine("Bienvenido");
                    break;

                }
                else
                {
                    Console.WriteLine("Datos incorrectos");

                }



            }

            Console.WriteLine("¿Quieres cambiar tu contraseña? s/n");
            pregunta = Console.ReadLine();
            if (pregunta == "s")
            {
                Console.WriteLine("Digita nueva contrasena");
                contraseña = Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Digite su usuario");
                    login = Console.ReadLine();

                    Console.WriteLine("Digite su contrasena");
                    password = Console.ReadLine();

                    if ((login == usuario) && (password == contraseña))
                    {
                        Console.WriteLine("Bienvenido");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Datos incorrectos");
                    }

                }


            }
            else
            {

            }
            Console.ReadLine();

        }
    }
}

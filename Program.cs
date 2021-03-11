using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, cedula, monto;
            string nombre;
            int[] dinero = new int[1] { 20000 };
            do
            {

                menu();
             

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("----------- Modulo de Deposito ---------");
                        Console.WriteLine("----------------------------------------");

                        Console.Write("Ingrese su nombre su numero de cedula(sin guion): ");
                         cedula =  int.Parse(Console.ReadLine());
                        Console.Write("Ingrese su nombre su nombre: ");
                         nombre = Console.ReadLine();

                        Console.Write("Digite la cantidad a Depositar: ");
                        monto = int.Parse(Console.ReadLine());


                        dinero[0] += monto;

                        Console.WriteLine("El Deposito se realizo correctamente");
                        Console.WriteLine($"Gracias {nombre} por realizar el deposito de {monto}");
                        Console.WriteLine();
                        Console.WriteLine("Enter para continuar....");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("----------- Modulo de Retiro -----------");
                        Console.WriteLine("----------------------------------------");

                        Console.Write("Ingrese su nombre su numero de cedula(sin guion): ");
                        cedula = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese su nombre su nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Digite la cantidad a Retirar: ");
                        monto = int.Parse(Console.ReadLine());


                        dinero[0] -= monto;
                        if (dinero [0] > 0)
                        {
                            Console.WriteLine("El retiro se realizo correctamente");
                            Console.WriteLine($"Gracias {nombre} por realizar el retiro {monto}");
                            Console.WriteLine();
                            Console.WriteLine("Enter para continuar....");
                        }
                        else
                        {
                            dinero[0] += monto;
                            Console.WriteLine("Error al retirar el monto, el monto solicitado excede la cantidad disponible");
                            Console.WriteLine();
                            Console.WriteLine("Enter para continuar....");
                        }
                        

                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("----- Gracias por salir del banco ------");
                        Console.WriteLine("----------------------------------------");


                        Console.WriteLine($"La cantidad del dinero final es de {dinero[0]}");

                        Console.WriteLine("----- ENTER para continar... -----");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("! Error la opcion elegida no es valida!");
                        break;


                }
            }
            while (opcion != 3);

            void menu()
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("---------- Bienvenido al banco ---------");
                Console.WriteLine("- Digite la opcion que quiere realizar -");
                Console.WriteLine("- 1- Depositar                        - ");
                Console.WriteLine("- 2- Retirar                          - ");
                Console.WriteLine("- 3- Salir                            - ");
                Console.WriteLine("----------------------------------------");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

            }


        }

     
    }
}

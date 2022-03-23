using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesosPOO.Entidades;
using PesosPOO.Datos;

namespace PesosPOO.Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese los pesos en kilogramos");

            RepositoriodePesos repositorios = new RepositoriodePesos();
            
            for (int i = 0; i < 3; i++)
            {
              
                var p = new Peso(Ingresokilogramos());

                if (p.ValidarPesos())
                {
                    repositorios.Agregar(p);
                }
                else
                {
                    Console.WriteLine("Error: peso no valido");
                }

            }
            
            var lista = repositorios.GetLista();
            

            Console.WriteLine("Pesos ingresados y su valor en libras:");

            MostrarPesos(lista);

            Console.ReadLine();

        }

        private static double Ingresokilogramos()
        {
            double valor;
            bool numeroValido;
            do
            {
                var ingreso = (Console.ReadLine());
                numeroValido = double.TryParse(ingreso, out valor);
            } while (!numeroValido);

            return valor;
        }

        private static void MostrarPesos(List<Peso> Pesos)
        {
            foreach (var pesoIngresado in Pesos)
            {
                Console.WriteLine($"{pesoIngresado.Kilogramos} {pesoIngresado.GetLIbra()}");
            }  
            
        }


      
    }
}

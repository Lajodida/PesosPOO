using PesosPOO.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesosPOO.Datos
{
    public class RepositoriodePesos
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Pesos.txt.";

        private List<Peso> listadePesos;

        public RepositoriodePesos()
        {
            listadePesos = new List<Peso>();
        }
        
        public void Agregar(Peso peso)
        {
            listadePesos.Add(peso);
            GuardarDatos(peso);
        }
        public List<Peso> GetLista()
        {
            return listadePesos;
        }

        public void GuardarDatos(Peso peso)
        {
            StreamWriter escribir = new StreamWriter (_archivo, true);
            var linea = ContruirLinea(peso);
            escribir.WriteLine(linea);
            escribir.Close();
        }

        private object ContruirLinea(Peso peso)
        {
           return $"{peso.Kilogramos}";
        }
    }
}

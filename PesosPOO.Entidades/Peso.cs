using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesosPOO.Entidades
{
    public class Peso
    {
        public double Kilogramos { get; set; }



        public Peso(double kilogramos)
        {
            Kilogramos = kilogramos;
        }

        public double GetLIbra()
        {
            return Kilogramos * 2.502;
        }

        public  bool ValidarPesos()
        {
            if (this.Kilogramos<=0)
            {
                return false;
            }
            return true;
        }


    }
}

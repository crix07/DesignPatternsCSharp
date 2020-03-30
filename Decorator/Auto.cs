using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Auto : IComponent
    {
        public double ACost;
        private string Modelo;
        private string Carateristicas;

        public Auto(string Modelo, string Carac, double Cost)
        {
            this.Modelo = Modelo;
            ACost = Cost;
            Carateristicas = Carac;
        }

        public void Puertas(bool State)
        {
            if (State)
                Console.WriteLine("Puertas Abiertas");
            else
                Console.WriteLine("Puertas Cerradas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", Modelo, Carateristicas);
        }


        //METHODS OF ICOMPONENT
        public double Cost()
        {
            return ACost;
        }

        public string Works()
        {
            return "Encendí el motor!!!";
        }

    }
}

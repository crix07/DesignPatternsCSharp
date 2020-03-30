using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Nitrogeno : IComponent
    {

        private IComponent decoramosA;

        public Nitrogeno(IComponent component)
        {
            decoramosA = component;
        }


        public double Cost()
        {
            return decoramosA.Cost() + 40000;
        }

        public string Works()
        {
            return decoramosA.Works() + "y Nitrogeno tambien funciona!!1";
        }

        public override string ToString()
        {
            return "Sistema de nitrogeno" + decoramosA.ToString();
        }

        public void UseBy()
        {
            Console.WriteLine($"Yo soy quien esta decorando a tu clase perro :v {this.GetType()}");
        }

    }
}

using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {


            Nitrogeno component = new Nitrogeno(new Auto("Honda CRV", "Muy Cara", 14000));

            component.UseBy();
            Console.WriteLine(component.Cost());

        }
    }
}

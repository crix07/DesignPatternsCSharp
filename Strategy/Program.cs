using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            IStrategy connection = new Context(new MongoDB());

            Console.WriteLine(connection.doOperation());
            

            
        }


    }
}

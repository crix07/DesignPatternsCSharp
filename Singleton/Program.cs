using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------- SINGLETON -----------------

            Connection instance = Connection.GetInstance();

            bool IsCorrectInstance = instance is Connection;

            instance.Confirm();

            Console.WriteLine(IsCorrectInstance);






        }
    }
}

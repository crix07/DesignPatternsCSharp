using System;

namespace Clone
{
    class Program
    {
        static void Main(string[] args)
        {

            var account = new Account(1000, "this works");
            Account otherintance = (Account)account.Clone();
            Console.WriteLine(new { otherintance.mount, otherintance.type });
        }
    }
}

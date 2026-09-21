using System.Security.Principal;
using System;
using System.Threading;

namespace consola1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("el nombre de login es: " + WindowsIdentity.GetCurrent().Name);
            Console.WriteLine("el toekn dea cceso de login es: " + WindowsIdentity.GetCurrent().AccessToken.ToString);

            int[] mrdas  = { 1, 2, 3 };
            
            foreach (int mrda in mrdas)
            {
                Console.WriteLine("{0}. escribe algo: ", mrda);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                
            }

            int? number = aSillyMethod();
            Console.WriteLine("{0} <-- es un numero", number);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Solo eso...");

            
            Console.ReadKey();

        }
        private static int aSillyMethod()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("No se que hace esto");
            Console.Write("dejame dormir un rato");

            Thread.Sleep(500);
            Thread.CurrentThread.Abort();
            return 42;
        }
    }
}

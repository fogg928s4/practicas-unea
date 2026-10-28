using System.Threading;
using System.Threading.Tasks;

namespace DesayunoAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static async void HacerDesayunoAsync()
        {
            TazaCafe miTaza = await PrepararCafeAsync();
        }
        private static async Task<TazaCafe> PrepararCafeAsync()
        {
            Console.WriteLine("Preparando Taza de café");
            await Task.Delay(1000); // como Thread.Sleep(1000)
            Console.WriteLine("Coffe done");
            return new TazaCafe();
        }

    }
}
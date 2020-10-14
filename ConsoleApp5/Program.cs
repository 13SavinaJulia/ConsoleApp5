using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = x * 2;
                Console.WriteLine($"Результат = {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок Finally");
            }
            Console.WriteLine("Конец программы");
            Console.ReadLine();
        }
    }
}

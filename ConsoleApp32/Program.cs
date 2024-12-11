using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую букву:");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.ReadKey();

            switch (letter)
            {
                case 'ф':
                    Console.WriteLine("Физика");
                    break;
                case 'м':
                    Console.WriteLine("Математика");
                    break;
                case 'и':
                    Console.WriteLine("История");
                    break;
                case 'г':
                    Console.WriteLine("География");
                    break;
                case 'б':
                    Console.WriteLine("Биология");
                    break;
                default:
                    Console.WriteLine("Неизвестная буква");
                    break;
            }
        }
    }
}

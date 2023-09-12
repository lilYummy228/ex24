using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char space = ' ';
            string text = "Успех не окончателен, поражение не фатально. Лишь смелость продолжать имеет значение.";
            string[] words = text.Split(space);

            foreach (string word in words)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}

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
            string text = "The quick brown,fox jumps over the lazy dog.";
            string[] words = text.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine($"{word} ");
            }
        }
    }
}

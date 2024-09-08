using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Palindromo
    {
        public void writePhrase()
        {
            string? phrase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phrase))
            {
                Console.WriteLine("La entrada está vacía.");
                return;
            }

            if (phrase.Length == 1)
            {
                Console.WriteLine($"\nSí, '{phrase}' es un palíndromo (un solo carácter).");
                return;
            }

            char[] chars = phrase.ToCharArray();
            readPhrase(phrase, chars);
        }

        private void readPhrase(string phrase, char[] chars)
        {
            bool forNowPalindromo = true;

            for (int i = 0; i < phrase.Length / 2; i++)
            {
                if (chars[i] != chars[(phrase.Length - 1) - i])
                {
                    forNowPalindromo = false;
                    break;
                }
            }

            if (forNowPalindromo)
            {
                Console.WriteLine($"\nSí, '{phrase}' es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"\nNo, '{phrase}' no es un palíndromo.");
            }
        }
    }
}

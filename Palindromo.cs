using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_03
{
    public class Palindromo
    {
        public void writePhrase()
        {
            string? phrase = Console.ReadLine();

            char[] chars = phrase.ToCharArray();

            readPhrase(phrase, chars);
        }

        private void readPhrase(string phrase, char[] chars)
        {
            bool forNowPalindromo = true;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase.Length - i < 0)
                {
                    break;
                }

                if (chars[i] != chars[(phrase.Length - 1) - i])
                {
                    forNowPalindromo = false;
                }
            }


            if (forNowPalindromo)
            {
                Console.WriteLine($"\n{phrase} es palindromo\n");
            }
            else
            {
                Console.WriteLine($"\n{phrase} no es palindromo\n");
            }
        }
    }
}

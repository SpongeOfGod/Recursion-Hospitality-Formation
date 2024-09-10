using System;
using System.Security.Cryptography.X509Certificates;

namespace TP3
{
    public class ArrayManipulationExtractor
    {
        public void arrayreader()
        {
            Console.WriteLine("\nIngrese una oración: ");
            string phrase = Console.ReadLine();
            Console.WriteLine(" ");

            string[] words = phrase.Split(' ');
            int totalLength = 0;

            Console.WriteLine($"Longitud con espacios: \n{phrase.Length}");
            foreach (var word in words)
            {
                totalLength += word.Length;
            }
            Console.WriteLine($"Longitud sin espacios: \n{totalLength}");

            Console.WriteLine("\nEscriba un carácter para contar en la oración:");
            string? input = Console.ReadLine();
            char letter = 'a';

            if (input != string.Empty)
            {
                letter = input[0];

                int countLetter = 0;
                int countVowels = 0;

                foreach (var c in phrase)
                {
                    if (letter == c)
                    {
                        countLetter++;
                    }

                    if (IsVowel(c))
                    {
                        countVowels++;
                    }
                }

                if (countLetter == 0)
                {
                    Console.WriteLine($"\nLa oración no contiene el carácter '{letter}'.");
                }
                else if (countLetter == 1)
                {
                    Console.WriteLine($"\nEl carácter '{letter}' se encontró una vez.");
                }
                else
                {
                    Console.WriteLine($"\nEl carácter '{letter}' se encontró {countLetter} veces.");
                }

                if (countVowels == 0)
                {
                    Console.WriteLine($"La oración no contiene vocales.");
                }
                else
                {
                    Console.WriteLine($"El número de vocales en la oración es {countVowels}.");
                }
            }

            Console.WriteLine("\nLargo de cada palabra: ");
            foreach (var word in words)
            {
                Console.WriteLine($"Número de caracteres en '{word}': {word.Length}");
            }

            string reversedPhrase = string.Empty;
            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                reversedPhrase += phrase[i];
            }
            Console.WriteLine($"\nLa oración completa al revés: \n{reversedPhrase}");

            string reversedWords = string.Empty;
            foreach (var word in words)
            {
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedWords += word[j];
                }
                reversedWords += " ";
            }
            Console.WriteLine($"La oración con las palabras al revés: \n{reversedWords}");

            string phraseWithoutVowels = string.Empty;
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (!IsVowel(c))
                    {
                        phraseWithoutVowels += c;
                    }
                }
                phraseWithoutVowels += " ";
            }
            Console.WriteLine($"\nLa oración sin vocales: \n{phraseWithoutVowels}");

            Console.WriteLine($"\nLa oración en mayúsculas: \n{phrase.ToUpper()}");

            int shift;
            string ceasarCipher = string.Empty;
            Random random = new Random();
            do { shift = random.Next(-3, 3);
            } while (shift == 0);

            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    char ceasarChar = c;
                    if (char.IsLetter(c))
                    {
                        char a = char.IsUpper(c) ? 'A' : 'a';
                        ceasarChar = (char)((((c - a) + shift + 26) % 26) + a);
                    }
                    ceasarCipher += ceasarChar;
                }
                ceasarCipher += " ";
            }
            Console.WriteLine($"\nLa oración usando el Cifrado de César (Llave utilizada: {shift}): \n{ceasarCipher}");

            // Cifrado de espejo: A-Z -> Z-A, a-z -> z-a.
            // Cada letra se reemplaza por otra en su posición opuesta en el alfabeto.

            string mirrorCipher = string.Empty;
            foreach (var c in phrase)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        mirrorCipher += (char)('Z' - (c - 'A'));
                    }
                    else
                    {
                        mirrorCipher += (char)('z' - (c - 'a'));
                    }
                }
                else
                {
                    mirrorCipher += c;
                }
            }
            Console.WriteLine($"\nLa oración usando el Cifrado de Espejo: \n{mirrorCipher}");
        }

        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
    }
}

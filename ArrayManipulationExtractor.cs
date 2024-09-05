using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_03
{
    public class ArrayManipulationExtractor
    {
        public void arrayreader() 
        {
            Console.WriteLine("Write a phrase, please.\n");
            string phrase = Console.ReadLine();

            string[] stringys = phrase.Split(' ');

            int lengthArrayString = 0;

            bool equalsVowel(char c)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    return true;
                }
                return false;
            }

            for (int i = 0; i < stringys.Length; i++)
            {
                Console.WriteLine(stringys[i] + $" length: {stringys[i].Length}");
                lengthArrayString += stringys[i].Length;
            }

            Console.WriteLine($"\nLength with spaces: {phrase.Length}");

            Console.WriteLine($"\nLength without spaces: {lengthArrayString}");

            Console.WriteLine("\nWrite a letter to count in the phrase");

            char letterInput = Console.ReadLine()[0];

            int timesRepeated = 0;

            int numberOfVocals = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (letterInput == phrase[i])
                {
                    timesRepeated++;
                }

                if (equalsVowel(phrase[i]))
                {
                    numberOfVocals++;
                }
            }

            Console.WriteLine($"\nThe letter ''{letterInput}'' was found {timesRepeated} times");
            Console.WriteLine($"\nThe number of vocals in the phrase where {numberOfVocals}");

            string wordsBackwards = string.Empty;
            for (int i = 0; i < stringys.Length; i++)
            {

                for (int j = stringys[i].Length - 1; j > -1; j--)
                {
                    wordsBackwards += stringys[i][j];
                }

                wordsBackwards += " ";
            }
            Console.WriteLine($"\nThe phrase with the words backwards: {wordsBackwards}");


            string phraseBackwards = string.Empty;
            for (int i = phrase.Length - 1; i > -1; i--)
            {
                phraseBackwards += phrase[i];
            }
            phraseBackwards += " ";

            Console.WriteLine($"\nThe whole phrase backwards: {phraseBackwards}");
        }
    }
}

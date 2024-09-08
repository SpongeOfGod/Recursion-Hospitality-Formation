using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
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

            string? stringInput = Console.ReadLine();
            char letterInput = 'a';

            if(stringInput != null) 
            {
                letterInput = stringInput[0];

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

            }
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



            string phraseWithoutVocals = string.Empty;

            for (int i = 0; i < stringys.Length; i++)
            {
                for (int j = 0; j < stringys[i].Length; j++)
                {
                    char currentChar = stringys[i][j];

                    if (equalsVowel(currentChar)) 
                    {
                        continue;
                    }

                    phraseWithoutVocals += currentChar;
                }
                phraseWithoutVocals += " ";
            }

            Console.WriteLine($"\nThe phrase without vocals: {phraseWithoutVocals}");

            int MoveSpaces;
            char ceasar = 'a';
            string cifferCeasar = string.Empty;
            Random rnd = new Random();
            MoveSpaces = rnd.Next(1,4);
            for (int i = 0;i < stringys.Length; i++)
            {
                for (int j = 0;j < stringys[i].Length; j++)
                {
                     ceasar = stringys[i][j];

                    ceasar = (char)(int)(ceasar + MoveSpaces);
                    cifferCeasar += ceasar;
                }
                
             
            }
            Console.WriteLine($"ciffer: {cifferCeasar}");


           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_03
{
    internal class AddAndMultiply
    {
        string numbersToAdd;
        string numbersToMultiply;

        public void Update()
        {
            if (!int.TryParse(Console.ReadLine(), out int result))
            {
                result = 5;
            }

            int addResult = result;
            int multiplyResult = result;

            addResult = sum(addResult);
            multiplyResult = multiply(multiplyResult);

            Console.WriteLine("\nSuma de todos los anterioes:  " + addResult + $" = {numbersToAdd}\n");
            Console.WriteLine("\nMultiplicación de todos los anteriores  " + multiplyResult + $" =  {numbersToMultiply}\n");
        }


        int sum(int num)
        {
            numbersToAdd += $"{num}";

            if (num == 0)
            {
                return num;
            }

            numbersToAdd += " + ";

            return num + sum(num - 1);
        }

       int multiply(int number)
        {
            numbersToMultiply += $"{number}";

            if (number == 1)
            {
                return number;
            }

            numbersToMultiply += " x ";

            return number * multiply(number - 1);
        }
    }
}

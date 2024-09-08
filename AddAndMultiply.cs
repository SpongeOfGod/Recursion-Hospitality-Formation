using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class AddAndMultiply
    {
        string numbersToAdd = "";
        string numbersToMultiply = "";

        public void Update()
        {
            if (!int.TryParse(Console.ReadLine(), out int result) || result < 0)
            {
                Console.WriteLine("Entrada inválida.");
                result = 0; 
            }

            int addResult = sum(result);
            numbersToAdd = numbersToAdd.TrimEnd(' ', '+');
            int multiplyResult = multiply(result);
            numbersToMultiply = numbersToMultiply.TrimEnd(' ', 'x');

            Console.WriteLine($"\nMultiplicación de todos los anteriores (Factorial de {result}): \n{multiplyResult} = {numbersToMultiply}");
            Console.WriteLine($"\nSuma de todos los anteriores a {result}: \n{addResult} = {numbersToAdd}");
        }

        int sum(int num)
        {
            if (num == 0) return 0;

            numbersToAdd += $"{num} + ";
            return num + sum(num - 1);
        }

        int multiply(int number)
        {
            if (number == 1 || number == 0) return 1;

            numbersToMultiply += $"{number} x ";
            return number * multiply(number - 1);
        }
    }
}

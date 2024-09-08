namespace TP3
{
    public class Fibonacci
    {
        string number1text;
        string number2text;

        int firstNumber;
        int secondNumber;
        int repeatCooldown = 0;

        bool firstNumbersInserted;
        bool finishFibo;



        public void Update()
        {

            while (true)
            {
                if (!firstNumbersInserted)
                {
                    WriteNumbers();
                }

                if (firstNumbersInserted && !finishFibo)
                {
                    sumarNumeros(firstNumber, secondNumber);
                }

                if (finishFibo)
                {
                    fiboFinished();
                    break;
                }
            }
        }

        private void WriteNumbers()
        {
            number1text = Console.ReadLine();

            Console.WriteLine("\nIngrese el segundo número de la secuencia de Fibonacci: ");
            number2text = Console.ReadLine();

            Console.WriteLine("\n¿Cuántos términos desea generar en la secuencia de Fibonacci? (si ingresa un valor no válido, será 0): ");
            string repeat = Console.ReadLine();
            Console.WriteLine($"");

            if (int.TryParse(repeat, out int result))
            {
                repeatCooldown = result;
            }
            else
            {
                repeatCooldown = 0;
            }

            if (int.TryParse(number1text, out int resultNum1) && int.TryParse(number2text, out int resultNum2))
            {
                firstNumber = resultNum1;
                secondNumber = resultNum2;
                firstNumbersInserted = true;
                return;
            }

            return;
        }

        private void sumarNumeros(int number1, int number2)
        {
            int firstNumber = number1;
            int secondNumber = number2;

            for (int i = 0; i < repeatCooldown; i++)
            {
                int resultNumber = firstNumber + secondNumber;

                Console.WriteLine($"{resultNumber} = {firstNumber} + {secondNumber}");
                firstNumber = secondNumber;
                secondNumber = resultNumber;
            }

            finishFibo = true;
        }

        private void fiboFinished()
        {
            Console.WriteLine("\nSECUENCIA FINALIZADA.");
            finishFibo = false;
            firstNumbersInserted = false;
        }
    }
}

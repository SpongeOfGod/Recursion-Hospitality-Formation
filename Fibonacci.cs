namespace Trabajo_Práctico_03
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
            Console.WriteLine("\nWrite your first Number: \n");
            number1text = Console.ReadLine();

            Console.WriteLine("\nWrite your second Number: \n");
            number2text = Console.ReadLine();


            Console.WriteLine("\nWrite the number of times you want to repeat the sequence (If you put an invalid value, it will be 0)\n");
            string repeat = Console.ReadLine();

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

                Console.WriteLine($"\n{resultNumber} = {firstNumber} + {secondNumber}\n");
                firstNumber = secondNumber;
                secondNumber = resultNumber;
            }

            finishFibo = true;
        }

        private void fiboFinished()
        {
            Console.WriteLine("Your sequence is finished!!!!!!\n");
            finishFibo = false;
            firstNumbersInserted = false;
        }
    }
}

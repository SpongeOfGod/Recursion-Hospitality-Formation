
namespace TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n-----------------------------------------------------");
                Console.WriteLine("\nIngrese 1, 2 o 3 para acceder a las diferentes funciones:");
                Console.WriteLine("\n1- Fila de Hospital");
                Console.WriteLine("2- Recursividad");
                Console.WriteLine("3- Manipulación de Arrays\n");
                Console.WriteLine("4- Finalizar programa\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        HospitalQueue();
                        break;
                    case "2":
                        Recursivity();
                        break;
                    case "3":
                        ArrayManipulation();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }
            }
        }

        private static void Recursivity()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("\n                   RECURSIVIDAD");
            Console.WriteLine("\n-----------------------------------------------------");

            Fibonacci fibonacci = new Fibonacci();
            AddAndMultiply addAndMultiply = new AddAndMultiply();
            Pyramid pyramid = new Pyramid();
            Palindromo palindromo = new Palindromo();

            Console.WriteLine("\nIngrese el primer número de la secuencia de Fibonacci: ");
            fibonacci.Update();
            Console.WriteLine("\n-----------------------------------------------------");

            Console.WriteLine("\nIngrese un número para calcular su factorial:");
            addAndMultiply.Update();
            Console.WriteLine("\n-----------------------------------------------------");

            Console.WriteLine("\n¿Cuál es la altura deseada de la pirámide?:");
            pyramid.Update();
            Console.WriteLine("\n-----------------------------------------------------");

            Console.WriteLine("\nIngrese un texto para verificar si se trata de un palíndromo: ");
            palindromo.writePhrase();
        }

        private static void ArrayManipulation()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("\n               MANIPULACIÓN DE ARRAYS");
            Console.WriteLine("\n-----------------------------------------------------");
            ArrayManipulationExtractor extractor = new ArrayManipulationExtractor();
            extractor.arrayreader();
        }

        private static void HospitalQueue()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("\n                   FILA DE HOSPITAL");
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine(":v");
        }
    }
}
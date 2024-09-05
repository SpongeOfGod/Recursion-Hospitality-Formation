
namespace Trabajo_Práctico_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursivity();
            ArrayManipulation();
        }

        private static void Recursivity() 
        {
            Fibonacci fibonacci = new Fibonacci();
            AddAndMultiply addAndMultiply = new AddAndMultiply();
            Pyramid pyramid = new Pyramid();
            Palindromo palindromo = new Palindromo();

            Console.WriteLine("\nFibonacci sequence\n");
            fibonacci.Update();

            Console.WriteLine("\nWrite a number: \n");
            addAndMultiply.Update();

            Console.WriteLine("\nWrite the height of your Pyramid\n");
            pyramid.Update();

            Console.WriteLine("\nPalindromo Checker \n\nWrite a phrase: ");
            palindromo.writePhrase();
        }

        private static void ArrayManipulation() 
        {
            ArrayManipulationExtractor extractor = new ArrayManipulationExtractor();
            extractor.arrayreader();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Pyramid
    {
        public void Update() 
        {
            if (int.TryParse(Console.ReadLine(), out int pyramidHeight))
            {
                for (int i = 0; i < pyramidHeight; i++)
                {

                    for (int s = 0; s <= pyramidHeight - i; s++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write($"☼");
                    }

                    for (int b = 0; b <= i - 1; b++)
                    {
                        Console.Write($"☼");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

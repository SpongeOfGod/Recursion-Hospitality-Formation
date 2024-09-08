using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Pyramid //𓄿𓈖𓅲𓃀𓇋𓋴, 𓏏𓅂𓈖 𓊪𓇋𓅂𓂧𓄿𓂧 𓂧𓅂 𓅓𓇋 𓄿𓃭𓅓𓄿. 𓂧𓅂𓆓𓄿 𓂧𓅂𓂋𓅂𓏏𓇋𓂋𓅓𓅂 𓅂𓈖 𓅂𓃭 𓎢𓄿𓃭𓅲𓂋𓅱𓋴𓅱 𓄿𓃀𓂋𓄿𓊃𓅱 𓂧𓅂 𓂋𓄿.
    {
        public void Update() 
        {
            if (int.TryParse(Console.ReadLine(), out int pyramidHeight))
            {
                Console.WriteLine($"");
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

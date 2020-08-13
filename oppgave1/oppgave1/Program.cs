using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave1
{
	class Program
	{
		static void Main()
		{
            var range = 250;
            var counts = new int[range];
            var total = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower() ?? string.Empty;
                foreach (var character in text)
                {
                    counts[(int)character] ++;
                    total++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        float prosent = counts[i] / (float)total * 100;
                        Console.WriteLine($"{character} - {counts[i],4} / {prosent,5:F2}%");

                    }
                }
            }
        }
	}
}

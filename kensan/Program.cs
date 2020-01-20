using System;
using System.Collections.Generic;

namespace kensan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> weights = new List<float>();

            weights.Add(41.2f);
            weights.Add(42.5f);
            weights.Add(44.9f);
            weights.Add(43.2f);

            for (int i = 0; i < weights.Count; i++)
            {
                Console.WriteLine(weights[i]);
            }

            // もっと簡単な記載もできるよ！そのうち試してみてください。
            // Sample.ShowWeights();
        }
    }
}
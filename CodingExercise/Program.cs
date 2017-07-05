using CodingExercise.Domain;
using CodingExercise.Enum;
using System;

namespace CodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var raceBetting = new RaceBetting();
            do
            {
                input = Console.ReadLine();
                raceBetting.Process(input);

            } while (!raceBetting.HasResult());
            var wResult = raceBetting.ShowResult(ProductEnum.W);
            if(wResult.Count == 1)
            {
                Console.WriteLine(wResult[0]);
            }
            var pResults = raceBetting.ShowResult(ProductEnum.P);
            if (pResults.Count > 1)
            {
                Console.WriteLine(pResults[0]);
                Console.WriteLine(pResults[1]);
                Console.WriteLine(pResults[2]);
            }
            var eResult = raceBetting.ShowResult(ProductEnum.E);
            if (eResult.Count == 1)
            {
                Console.WriteLine(eResult[0]);
            }

            Console.ReadLine();
        }
    }
}
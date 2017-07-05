using CodingExercise.Abstract;
using CodingExercise.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.Domain
{
    public static class CalculatorFactory
    {
        public static IWinningCalculator GetCaculator(ProductEnum product, int[] results, int place=1)
        {
            switch(product) {
                case ProductEnum.W:
                    return new WCalculator(results);
                case ProductEnum.E: 
                    return new ECalculator(results);
                case ProductEnum.P:
                    return new PCaculator(results, place);
            }
            return null;
        }
    }
}

using CodingExercise.Enum;
using CodingExercise.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.Domain
{
    public class RaceBetting
    {
        private List<Bet> _wbet;
        private List<Bet> _pbet;
        private List<Bet> _ebet;
        private int[] results;

        public RaceBetting()
        {
            _wbet = new List<Bet>();
            _pbet = new List<Bet>();
            _ebet = new List<Bet>();
        }

        public List<string> ShowResult(ProductEnum product)
        {
            var output = new List<string>();
            if (!HasResult())
                return output;

            if (product == ProductEnum.W && _wbet.Count > 0)
            {
                var calculator = CalculatorFactory.GetCaculator(product, results);
                output.Add($"Win:{results[0]}:${calculator.Calculate(_wbet)}");
            }
            else if(product == ProductEnum.E && _ebet.Count > 0)
            {
                var calculator = CalculatorFactory.GetCaculator(product, results);
                output.Add($"Exacta:{results[0]},{results[1]}:${calculator.Calculate(_ebet)}");
            }
            else if(product == ProductEnum.P && _pbet.Count> 0)
            {
                var cal1 = CalculatorFactory.GetCaculator(product, results, 1);
                var cal2 = CalculatorFactory.GetCaculator(product, results, 2);
                var cal3 = CalculatorFactory.GetCaculator(product, results, 3);
                output.Add($"Place:{results[0]}:${cal1.Calculate(_pbet)}");
                output.Add($"Place:{results[1]}:${cal2.Calculate(_pbet)}");
                output.Add($"Place:{results[2]}:${cal3.Calculate(_pbet)}");
            }
            return output;
        }

        public bool HasResult()
        {
            return results?.Length > 0;
        }

        public void Process(string input)
        {
            string[] inputs = input.Split(':');
            if(inputs[0] == "Result")
            {
                results = new int[3];
                results[0] = int.Parse(inputs[1]);
                results[1] = int.Parse(inputs[2]);
                results[2] = int.Parse(inputs[3]);
            }
            else
            {
                var product = inputs[1];
                switch(product)
                {
                    case nameof(ProductEnum.W):
                        _wbet.Add(new WBet(int.Parse(inputs[2]), decimal.Parse(inputs[3])));
                        break;
                    case nameof(ProductEnum.P):
                        _pbet.Add(new PBet(int.Parse(inputs[2]), decimal.Parse(inputs[3])));
                        break;
                    case nameof(ProductEnum.E):
                        var selectionInput = inputs[2].Split(',');
                        int[] selections = { int.Parse(selectionInput[0]), int.Parse(selectionInput[1]) };
                        _ebet.Add(new EBet(selections, decimal.Parse(inputs[3])));
                        break;
                }
            }
        }
    }
}

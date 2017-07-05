using CodingExercise.Abstract;
using CodingExercise.Model;
using System;
using System.Collections.Generic;

namespace CodingExercise.Domain
{
    public class WCalculator : IWinningCalculator
    {
        private const decimal commission = 0.15M;
        private readonly int[] _results;
        private decimal totalPool;
        private decimal winningPool;
        private decimal winningBets;

        public WCalculator(int[] results)
        {
            _results = results;
        }

        //return dividend
        public decimal Calculate(List<Bet> bets)
        {
            foreach(var bet in bets)
            {
                totalPool += bet.Stake;
                if(bet.IsWinner(_results))
                {
                    winningBets += bet.Stake;
                }
            }
            winningPool = totalPool - (totalPool * commission);

            return Math.Round(winningPool/winningBets, 2, MidpointRounding.AwayFromZero);
        }
    }
}

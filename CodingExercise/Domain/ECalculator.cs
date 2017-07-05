using CodingExercise.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using CodingExercise.Model;

namespace CodingExercise.Domain
{
    public class ECalculator : IWinningCalculator
    {
        private const decimal commission = 0.18M;
        private readonly int[] _results;
        private decimal totalPool;
        private decimal winningPool;
        private decimal winningBets;

        public ECalculator(int[] results)
        {
            _results = results;
        }

        public decimal Calculate(List<Bet> bets)
        {
            foreach (var bet in bets)
            {
                totalPool += bet.Stake;
                if (bet.IsWinner(_results))
                {
                    winningBets += bet.Stake;
                }
            }
            winningPool = totalPool - (totalPool * commission);

            return Math.Round(winningPool / winningBets, 2, MidpointRounding.AwayFromZero);
        }
    }
}

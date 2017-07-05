using CodingExercise.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using CodingExercise.Model;

namespace CodingExercise.Domain
{
    public class PCaculator : IWinningCalculator
    {
        private const decimal commission = 0.12M;
        private readonly int[] _results;
        private readonly int _place;
        private decimal totalPool;
        private decimal winningPool;
        private decimal winningBets;

        public PCaculator(int[] results, int place)
        {
            _results = results;
            _place = place;
        }

        public decimal Calculate(List<Bet> bets)
        {
            foreach(var bet in bets)
            {
                var pbet = bet as PBet;
                totalPool += pbet.Stake;
                if (pbet.IsWinner(_results) && pbet.Selection == _results[_place-1])
                {
                    winningBets += bet.Stake;
                }
            }
            winningPool = (totalPool - (totalPool * commission)) / 3;

            return Math.Round(winningPool / winningBets, 2, MidpointRounding.AwayFromZero);
        }
    }
}

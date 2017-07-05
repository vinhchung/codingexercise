using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.Model
{
    public class WBet : Bet
    {
        private readonly int _selection;
        private readonly decimal _stake;

        public WBet(int selection, decimal stake)
        {
            _selection = selection;
            _stake = stake;
        }

        public int Selection
        {
            get
            {
                return _selection;
            }
        }

        public override decimal Stake
        {
            get
            {
                return _stake;
            }
        }

        public override bool IsWinner(int[] results)
        {
            return results[0] == _selection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.Model
{
    public class EBet : Bet
    {
        private readonly int[] _selections;
        private readonly decimal _stake;

        public EBet(int[] selections, decimal stake)
        {
            _selections = selections;
            _stake = stake;
        }

        public int[] Selections {
            get
            {
                return _selections;
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
            return results[0] == _selections[0] && results[1] == _selections[1];
        }
    }
}

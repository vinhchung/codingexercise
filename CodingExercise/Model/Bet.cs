using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.Model
{
    public abstract class Bet
    {
        abstract public decimal Stake { get; }
        abstract public bool IsWinner(int[] results);
    }
}

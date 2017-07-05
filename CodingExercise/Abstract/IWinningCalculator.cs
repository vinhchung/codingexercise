using CodingExercise.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.Abstract
{
    public interface IWinningCalculator
    {
        decimal Calculate(List<Bet> bets);
    }
}

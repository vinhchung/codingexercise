using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CodingExercise.Domain;

namespace CodingExercise.UnitTests
{
    [TestClass]
    public class WinProductTests
    {
        [TestMethod]
        public void WCaculator_Calculate12Bets_ShowCorrectDivident()
        {
            var betsInput = new List<string>
            {
                "Bet:W:1:3",
                "Bet:W:2:4",
                "Bet:W:3:5",
                "Bet:W:4:5",
                "Bet:W:1:16",
                "Bet:W:2:8",
                "Bet:W:3:22",
                "Bet:W:4:57",
                "Bet:W:1:42",
                "Bet:W:2:98",
                "Bet:W:3:63",
                "Bet:W:4:15",
                "Result:2:3:1"
            };
            var raceBetting = new RaceBetting();
            foreach(var input in betsInput)
            {
                raceBetting.Process(input);
            }
            var result = raceBetting.ShowResult(Enum.ProductEnum.W);
            Assert.AreEqual(result[0], "Win:2:$2.61");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CodingExercise.Domain;

namespace CodingExercise.UnitTests
{
    [TestClass]
    public class ExactaProductTests
    {
        [TestMethod]
        public void ECaculator_Calculate12Bets_ShowCorrectDivident()
        {
            var betsInput = new List<string>
            {
                "Bet:E:1,2:13",
                "Bet:E:2,3:98",
                "Bet:E:1,3:82",
                "Bet:E:3,2:27",
                "Bet:E:1,2:5",
                "Bet:E:2,3:61",
                "Bet:E:1,3:28",
                "Bet:E:3,2:25",
                "Bet:E:1,2:81",
                "Bet:E:2,3:47",
                "Bet:E:1,3:93",
                "Bet:E:3,2:51",
                "Result:2:3:1"
            };
            var raceBetting = new RaceBetting();
            foreach (var input in betsInput)
            {
                raceBetting.Process(input);
            }
            var result = raceBetting.ShowResult(Enum.ProductEnum.E);
            Assert.AreEqual(result[0], "Exacta:2,3:$2.43");
        }
    }
}

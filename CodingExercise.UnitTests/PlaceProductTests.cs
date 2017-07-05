using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CodingExercise.Domain;

namespace CodingExercise.UnitTests
{
    [TestClass]
    public class PlaceProductTests
    {
        [TestMethod]
        public void PCaculator_Calculate12Bets_ShowCorrectDivident()
        {
            var betsInput = new List<string>
            {
                "Bet:P:1:31",
                "Bet:P:2:89",
                "Bet:P:3:28",
                "Bet:P:4:72",
                "Bet:P:1:40",
                "Bet:P:2:16",
                "Bet:P:3:82",
                "Bet:P:4:52",
                "Bet:P:1:18",
                "Bet:P:2:74",
                "Bet:P:3:39",
                "Bet:P:4:105",
                "Result:2:3:1"
            };
            var raceBetting = new RaceBetting();
            foreach (var input in betsInput)
            {
                raceBetting.Process(input);
            }
            var result = raceBetting.ShowResult(Enum.ProductEnum.P);
            Assert.AreEqual(result[0], "Place:2:$1.06");
            Assert.AreEqual(result[1], "Place:3:$1.27");
            Assert.AreEqual(result[2], "Place:1:$2.13");
        }
    }
}

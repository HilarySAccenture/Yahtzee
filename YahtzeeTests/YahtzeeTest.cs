using System;
 using Xunit;
 using Shouldly;
 
 namespace YahtzeeApp
 {
     public class YahtzeeTest
     {
         [Fact]
         public void ChanceScoresSumOfAllDice()
         {
 
             Yahtzee.Chance(2, 3, 4, 5, 1).ShouldBe(15);
             Yahtzee.Chance(3, 3, 4, 5, 1).ShouldBe(16);
         }
 
         [Fact]
         public void YahtzeeScoresFifty()
         {
             Yahtzee.yahtzee(4, 4, 4, 4, 4).ShouldBe(50);
             Yahtzee.yahtzee(6, 6, 6, 6, 6).ShouldBe(50);
             Yahtzee.yahtzee(6, 6, 6, 6, 3).ShouldBe(0);
         }
 
         [Fact]
         public void OnesReturnsSumOfAllOnesRolled()
         {
             Yahtzee.Ones(1, 2, 3, 4, 5).ShouldBe(1);
             Yahtzee.Ones(1, 2, 1, 4, 5).ShouldBe(2);
             Yahtzee.Ones(6, 2, 2, 4, 5).ShouldBe(0);
         }
 
         [Fact]
         public void TwosReturnsSumOfAllTwos()
         {
             Yahtzee.Twos(1, 2, 3, 2, 6).ShouldBe(4);
             Yahtzee.Twos(2, 2, 2, 2, 2).ShouldBe(10);
             Yahtzee.Twos(1, 1, 3, 5, 6).ShouldBe(0);
 
         }
 
         [Fact]
         public void ThreesReturnsSumOfAllThrees()
         {
             Yahtzee.Threes(1, 2, 3, 2, 3).ShouldBe(6);
             Yahtzee.Threes(2, 3, 3, 3, 3).ShouldBe(12);
             Yahtzee.Threes(1, 2, 4, 2, 4).ShouldBe(0);
         }
 
         [Fact]
         public void FoursReturnsSumOfAllFours()
         {
             new Yahtzee(4, 4, 4, 5, 5).Fours().ShouldBe(12);
             new Yahtzee(4, 4, 5, 5, 5).Fours().ShouldBe(8);
             new Yahtzee(3, 3, 5, 5, 5).Fours().ShouldBe(0);
 
         }
 
         [Fact]
         public void FivesReturnsSumOfAllFives()
         {
             new Yahtzee(4, 4, 4, 5, 5).Fives().ShouldBe(10);
             new Yahtzee(4, 4, 5, 5, 5).Fives().ShouldBe(15);
             new Yahtzee(4, 4, 6, 6, 6).Fives().ShouldBe(0);
         }
 
         [Fact]
         public void SixesReturnsSumOfAllSixes()
         {
 
             new Yahtzee(4, 4, 4, 5, 5).sixes().ShouldBe(0);
             new Yahtzee(4, 4, 6, 5, 5).sixes().ShouldBe(6);
             new Yahtzee(6, 5, 6, 6, 5).sixes().ShouldBe(18);
         }
 
         [Fact]
         public void OnePairReturnsSumOfTheHighestPairFound()
         {
             Yahtzee.ScorePair(3, 4, 3, 5, 6).ShouldBe(6);
             Yahtzee.ScorePair(5, 3, 3, 3, 5).ShouldBe(10);
             Yahtzee.ScorePair(5, 3, 6, 6, 5).ShouldBe(12);
             Yahtzee.ScorePair(5, 3, 3, 3, 3).ShouldBe(0);
         }
 
         [Fact]
         public void TwoPairReturnsSumOfBothPairs()
         {
             Yahtzee.TwoPair(3, 3, 5, 4, 5).ShouldBe(16);
             Yahtzee.TwoPair(3, 3, 5, 5, 5).ShouldBe(0);
         }
 
         [Fact]
         public void ThreeOfAKindReturnsSumOfTriplet()
         {
             Yahtzee.ThreeOfAKind(3, 3, 3, 4, 5).ShouldBe(9);
             Yahtzee.ThreeOfAKind(5, 3, 5, 4, 5).ShouldBe(15);
             Yahtzee.ThreeOfAKind(3, 3, 3, 3, 5).ShouldBe(0);
         }
 
         [Fact]
         public void FourOfAKindReturnsSumOfQuad()
         {
             Yahtzee.FourOfAKind(3, 3, 3, 3, 5).ShouldBe(12);
             Yahtzee.FourOfAKind(5, 5, 5, 4, 5).ShouldBe(20);
             Yahtzee.FourOfAKind(3, 3, 3, 3, 3).ShouldBe(0);
         }
 
         [Fact]
         public void SmallStraightScoresFifteen()
         {
             Yahtzee.SmallStraight(1, 2, 3, 4, 5).ShouldBe(15);
             Yahtzee.SmallStraight(2, 3, 4, 5, 1).ShouldBe(15);
             Yahtzee.SmallStraight(1, 2, 2, 4, 5).ShouldBe(0);
         }
 
         [Fact]
         public void LargeStraightScoresTwenty()
         {
             Yahtzee.LargeStraight(6, 2, 3, 4, 5).ShouldBe(20);
             Yahtzee.LargeStraight(2, 3, 4, 5, 6).ShouldBe(20);
             Yahtzee.LargeStraight(1, 2, 2, 4, 5).ShouldBe(0);
         }
 
         [Fact]
         public void FullHouseScoresSumOfAllDice()
         {
             Yahtzee.FullHouse(6, 2, 2, 2, 6).ShouldBe(18);
             Yahtzee.FullHouse(2, 3, 4, 5, 6).ShouldBe(0);
         }
     }
 
 }
using System;
using GildedTros.App.Items;
using GildedTros.Test.Unit.Helper;
using Xunit;

namespace GildedTros.Test.Unit
{
    public class ItemGettingBetterOverTimeTest
    {
        [Fact]
        public void Ctor_GivenNoName_ShouldReturnNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ItemGettingBetterOverTime(null));
        }
        [Fact]
        public void Ctor_GivenSomeName_ShouldHaveThatName()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName);
            
            Assert.Equal(TestItems.SomeName,itemGettingBetterOverTime.Name);
        }
        [Fact]
        public void Age_WithSellInGreaterthanZero_ShouldDecreaseSellinValue()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityGreaterThanZero,
                SellIn = 10
            };
                
            itemGettingBetterOverTime.Age();
                
            Assert.Equal(9,itemGettingBetterOverTime.SellIn);
        }
        [Fact]
        public void Age_WithSellInGreaterthanZero_ShouldIncreaseQualityByOne()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
            
            itemGettingBetterOverTime.Age();
            
            Assert.Equal(11,itemGettingBetterOverTime.Quality);
        }
        [Fact]
        public void Age_WithSellInLowerthanZero_ShouldIncreaseQualityByTwo()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = TestItems.SomeSellInLessThanZero
            };
            
            itemGettingBetterOverTime.Age();
            
            Assert.Equal(12,itemGettingBetterOverTime.Quality);
        }

        [Fact]
        public void AgeMultipleTimes_WithSellInLowerthanZero_ShouldOnlyMultiplyQualityOnce()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = 1
            };
            var expextedResult = itemGettingBetterOverTime.QualitySpeed * 2;
            
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();
            
            Assert.Equal(expextedResult,itemGettingBetterOverTime.QualitySpeed);
        }
        [Fact]
        public void AgeMultipleTimes_WithQualityFifty_ShouldMaxBeFifty()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = 50,
                SellIn = 1
            };
            itemGettingBetterOverTime.Age();

            Assert.Equal(50,itemGettingBetterOverTime.Quality);
        }
        
        
    }
}


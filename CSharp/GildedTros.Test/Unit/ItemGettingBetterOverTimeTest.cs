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
        public void Age_GivenSellInGreaterThanZero_ShouldDecreaseSellInValue()
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
        public void Age_GivenSellInGreaterThanZero_ShouldIncreaseQualityByOne()
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
        public void Age_GivenSellInLowerThanZero_ShouldIncreaseQualityByTwo()
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
        public void AgeMultipleTimes_GivenSellInLowerThanZero_ShouldOnlyMultiplyQualityOnce()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = 1
            };
            var expectedResult = itemGettingBetterOverTime.QualitySpeed * 2;
            
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();
            
            Assert.Equal(expectedResult,itemGettingBetterOverTime.QualitySpeed);
        }
        [Fact]
        public void AgeMultipleTimes_GivenQualityFifty_ShouldMaxBeFifty()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = 50,
                SellIn = 1
            };
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();
            itemGettingBetterOverTime.Age();

            Assert.True(50 >= itemGettingBetterOverTime.Quality);
        }
        [Fact]
        public void Age_GivenSomeNegativeQuality_ShouldPutQualityToZero()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityLessThanZero,
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
                
            itemGettingBetterOverTime.Age();
                
            Assert.Equal(0,itemGettingBetterOverTime.Quality);
        }
        
        
    }
}


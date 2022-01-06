using System;
using GildedTros.App.Items;
using GildedTros.Test.Unit.Helper;
using Xunit;

namespace GildedTros.Test.Unit
{
    public class ItemSmellyTest
    {
        [Fact]
        public void Ctor_GivenNoName_ShouldReturnNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ItemSmelly(null));
        }
        [Fact]
        public void Ctor_GivenSomeName_ShouldHaveThatName()
        {
            var itemSmelly = new ItemSmelly(TestItems.SomeName);
            
            Assert.Equal(TestItems.SomeName,itemSmelly.Name);
        }
        [Fact]
        public void Age_GivenSellInGreaterThanZero_ShouldDecreaseSellInValue()
        {
            var itemSmelly = new ItemSmelly(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityGreaterThanZero,
                SellIn = 10
            };

            itemSmelly.Age();
                
            Assert.Equal(9,itemSmelly.SellIn);
        }
        [Fact]
        public void Age_GivenSellInGreaterThanZero_ShouldDecreaseQualityValueWithTwo()
        {
            var itemSmelly = new ItemSmelly(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
                
            itemSmelly.Age();
                
            Assert.Equal(8,itemSmelly.Quality);
        }
        [Fact]
        public void Age_GivenSomeNegativeQuality_ShouldPutQualityToZero()
        {
            var itemSmelly = new ItemSmelly(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityLessThanZero,
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
                
            itemSmelly.Age();
                
            Assert.Equal(0,itemSmelly.Quality);
        }
        [Fact]
        public void Age_GivenSellInLowerThanZero_ShouldDecreaseQualityByFour()
        {
            var itemSmelly = new ItemSmelly(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = TestItems.SomeSellInLessThanZero
            };
            
            itemSmelly.Age();
            
            Assert.Equal(6,itemSmelly.Quality);
        }

        [Fact]
        public void AgeMultipleTimes_GivenSellInLowerThanZero_ShouldOnlyMultiplyQualityOnce()
        {
            var itemSmelly = new ItemSmelly(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = 1
            };
            var expextedResult = itemSmelly.QualitySpeed * 2;
            
            itemSmelly.Age();
            itemSmelly.Age();
            itemSmelly.Age();
            itemSmelly.Age();
            
            Assert.Equal(expextedResult,itemSmelly.QualitySpeed);
        }
        [Fact]
        public void AgeMultipleTimes_GivenQualityFifty_ShouldMaxBeFifty()
        {
            var itemSmelly = new ItemSmelly(TestItems.SomeName)
            {
                Quality = 60,
                SellIn = 1
            };
            itemSmelly.Age();
            itemSmelly.Age();
            itemSmelly.Age();

            Assert.True(50 >= itemSmelly.Quality);
        }
        
    }
}


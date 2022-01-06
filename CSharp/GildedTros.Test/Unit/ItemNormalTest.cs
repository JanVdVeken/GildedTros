using System;
using GildedTros.App.Items;
using GildedTros.Test.Unit.Helper;
using Xunit;

namespace GildedTros.Test.Unit
{
    public class ItemNormalTest
    {
        [Fact]
        public void Ctor_GivenNoName_ShouldReturnNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ItemNormal(null));
        }
        [Fact]
        public void Ctor_GivenSomeName_ShouldHaveThatName()
        {
            var itemNormal = new ItemNormal(TestItems.SomeName);
            
            Assert.Equal(TestItems.SomeName,itemNormal.Name);
        }
        [Fact]
        public void Age_GivenSellInGreaterThanZero_ShouldDecreaseSellInValue()
        {
            var itemNormal = new ItemNormal(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityGreaterThanZero,
                SellIn = 10
            };
                
            itemNormal.Age();
                
            Assert.Equal(9,itemNormal.SellIn);
        }
        [Fact]
        public void Age_GivenSellInGreaterThanZero_ShouldDecreaseQualityValueWithOne()
        {
            var itemNormal = new ItemNormal(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
                
            itemNormal.Age();
                
            Assert.Equal(9,itemNormal.Quality);
        }
        [Fact]
        public void Age_GivenSomeNegativeQuality_ShouldPutQualityToZero()
        {
            var itemNormal = new ItemNormal(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityLessThanZero,
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
                
            itemNormal.Age();
                
            Assert.Equal(0,itemNormal.Quality);
        }
        [Fact]
        public void Age_GivenSellInLowerThanZero_ShouldDecreaseQualityByTwo()
        {
            var itemNormal = new ItemNormal(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = TestItems.SomeSellInLessThanZero
            };
            
            itemNormal.Age();
            
            Assert.Equal(8,itemNormal.Quality);
        }

        [Fact]
        public void AgeMultipleTimes_GivenSellInLowerThanZero_ShouldOnlyMultiplyQualityOnce()
        {
            var itemNormal = new ItemNormal(TestItems.SomeName)
            {
                Quality = 10,
                SellIn = 1
            };
            var expextedResult = itemNormal.QualitySpeed * 2;
            
            itemNormal.Age();
            itemNormal.Age();
            itemNormal.Age();
            itemNormal.Age();
            
            Assert.Equal(expextedResult,itemNormal.QualitySpeed);
        }
        [Fact]
        public void AgeMultipleTimes_GivenQualityFifty_ShouldMaxBeFifty()
        {
            var itemNormal = new ItemNormal(TestItems.SomeName)
            {
                Quality = 60,
                SellIn = 1
            };
            itemNormal.Age();
            itemNormal.Age();
            itemNormal.Age();

            Assert.True(50 >= itemNormal.Quality);
        }
        
    }
}


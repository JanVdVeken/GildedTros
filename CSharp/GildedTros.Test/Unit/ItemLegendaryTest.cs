using System;
using GildedTros.App.Items;
using GildedTros.Test.Unit.Helper;
using Xunit;

namespace GildedTros.Test.Unit
{
    public class ItemLegendaryTest
    {
        [Fact]
        public void Ctor_GivenNoName_ShouldReturnNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ItemLegendary(null));
        }
        [Fact]
        public void Ctor_GivenSomeName_ShouldHaveThatName()
        {
            var itemLegendary = new ItemLegendary(TestItems.SomeName);
            
            Assert.Equal(TestItems.SomeName,itemLegendary.Name);
        }

        [Fact]
        public void Age_GivenSomeQuality_ShouldNotChangeQuality()
        {
            var itemLegendary = new ItemLegendary(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityGreaterThanZero
            };
            
            itemLegendary.Age();
            
            Assert.Equal(TestItems.SomeQualityGreaterThanZero,itemLegendary.Quality);
        }
        [Fact]
        public void Age_GivenSomeSellIn_ShouldNotChangeSellIn()
        {
            var itemLegendary = new ItemLegendary(TestItems.SomeName)
            {
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
            
            itemLegendary.Age();
            
            Assert.Equal(TestItems.SomeSellInGreaterThanZero,itemLegendary.SellIn);
        }
        [Fact]
        public void AgeMultipleTimes_WithQualityFifty_ShouldMaxBeFifty()
        {
            var itemLegendary = new ItemLegendary(TestItems.SomeName)
            {
                Quality = 50,
                SellIn = 1
            };
            
            itemLegendary.Age();
            itemLegendary.Age();
            itemLegendary.Age();

            Assert.Equal(50,itemLegendary.Quality);
        }
    }
}


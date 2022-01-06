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
        public void Age_GivenSomeQuality_QualityShouldBeSetToEighty()
        {
            var itemLegendary = new ItemLegendary(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityGreaterThanZero,
                SellIn = 1
            };
            
            itemLegendary.Age();

            Assert.Equal(80,itemLegendary.Quality);
        }
    }
}


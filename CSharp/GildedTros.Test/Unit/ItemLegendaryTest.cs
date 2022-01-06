using System;
using GildedTros.App.Items;
using GildedTros.Test.Unit.Helper;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.EventHandlers;
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
        public void Age_GivenSomeSellin_ShouldNotChangeSellin()
        {
            var itemLegendary = new ItemLegendary(TestItems.SomeName)
            {
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
            
            itemLegendary.Age();
            
            Assert.Equal(TestItems.SomeSellInGreaterThanZero,itemLegendary.SellIn);
        }
    }
}


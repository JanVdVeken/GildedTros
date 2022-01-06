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
    }
}


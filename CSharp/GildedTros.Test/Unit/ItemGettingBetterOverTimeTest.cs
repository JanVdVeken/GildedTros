using System;
using GildedTros.App.Items;
using GildedTros.Test.Unit.Helper;
using Xunit;

namespace GildedTros.Test.Unit
{
    public class ItemGettingBetterOverTimeTest
    {
        [Fact]
        public void ItemGettingBetterOverTimeCtor_GivenNoName_ShouldReturnNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ItemGettingBetterOverTime(null));
        }
        [Fact]
        public void ItemGettingBetterOverTimeCtor_GivenSomeName_ShouldHaveThatName()
        {
            var itemGettingBetterOverTime = new ItemGettingBetterOverTime(TestItems.SomeName);
            
            Assert.Equal(TestItems.SomeName,itemGettingBetterOverTime.Name);
        }
    }
}


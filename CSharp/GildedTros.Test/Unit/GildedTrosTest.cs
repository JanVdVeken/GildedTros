using System;
using System.Collections.Generic;
using GildedTros.App;
using GildedTros.App.Items;
using Xunit;

namespace GildedTros.Test.Unit
{
    public class GildedTrosTest
    {
        [Fact]
        public void GildedTrosCtor_GivenNull_ShouldThrowNewException()
        {
            Assert.Throws<ArgumentNullException>(() => new App.GildedTros(null));
        }
        [Fact]
        public void GildedTrosCtor_GivenListWithOneItem_ShouldContainOneItem()
        {
            IList<IAgingItem> items = new List<IAgingItem> { new ItemNormal("foo") {SellIn = 0, Quality = 0 } };
            App.GildedTros app = new App.GildedTros(items);

            Assert.Equal(1, app.Items.Count);
        }
    }
}
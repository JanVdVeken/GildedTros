using System;
using System.Collections.Generic;
using GildedTros.App;
using Xunit;

namespace GildedTros.Test
{
    public class GildedTrosTest
    {
        [Fact]
        public void GildedTrosCtor_GivenNull_ShouldThrowNewException()
        {
            Assert.Throws<NullReferenceException>(() => new App.GildedTros(null));
        }
        [Fact]
        public void GildedTrosCtor_GivenListWithOneItem_ShouldContainOneItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            App.GildedTros app = new App.GildedTros(items);
            

            Assert.Equal(1, app.Items.Count);
        }
    }
}
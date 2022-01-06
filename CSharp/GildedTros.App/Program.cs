using System;
using System.Collections.Generic;
using ApprovalUtilities.Utilities;
using GildedTros.App.Items;

namespace GildedTros.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<IAgingItem> items = new List<IAgingItem>{
                new ItemNormal("Ring of Cleansening Code") {SellIn = 10, Quality = 20},
                new ItemGettingBetterOverTime("Good Wine") { SellIn = 2, Quality = 0},
                new ItemNormal("Elixir of the SOLID") {SellIn = 5, Quality = 7},
                new ItemLegendary("B-DAWG Keychain") {SellIn = 0, Quality = 80},
                new ItemLegendary("B-DAWG Keychain") { SellIn = -1, Quality = 80},
                new ItemConferencePass("Backstage passes for Re:factor") { SellIn = 15, Quality = 20},
                new ItemConferencePass("Backstage passes for Re:factor") { SellIn = 10, Quality = 49},
                new ItemConferencePass("Backstage passes for HAXX") {SellIn = 5, Quality = 49},
                // these smelly items do not work properly yet
                new ItemSmelly("Duplicate Code") {SellIn = 3, Quality = 6},
                new ItemSmelly("Long Methods") { SellIn = 3, Quality = 6},
                new ItemSmelly("Ugly Variable Names") {SellIn = 3, Quality = 6}
            };

            var app = new GildedTros(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine($"-------- day {i} --------");
                Console.WriteLine("name, sellIn, quality");
                items.ForEach(x => x.Print());
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}

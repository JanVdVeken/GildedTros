using System;
using System.Collections.Generic;
using ApprovalUtilities.Utilities;
using GildedTros.App.Items;

namespace GildedTros.App
{
    public class GildedTros
    {
        public IList<IAgingItem> Items { get; }

        public GildedTros(IList<IAgingItem> items)
        {
            Items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public void UpdateQuality()
        {
            Items.ForEach(x => x.Age());
        }

        public void Print()
        {
            Items.ForEach(x => x.Print());
        }

        public void ShowInventory(int amountOfDays)
        {
            for (var i = 0; i < amountOfDays; i++)
            {
                Console.WriteLine($"-------- day {i} --------");
                Console.WriteLine("name, sellIn, quality");
                Print();
                Console.WriteLine("");
                UpdateQuality();
            }
        }
    }
}

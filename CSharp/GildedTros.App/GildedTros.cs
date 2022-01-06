using System;
using System.Collections.Generic;
using GildedTros.App.Items;

namespace GildedTros.App
{
    public class GildedTros
    {
        public IList<Item> Items { get; }

        public GildedTros(IList<Item> items)
        {
            Items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i] is ItemGettingBetterOverTime)
                {
                    var currentItem = Items[i] as ItemGettingBetterOverTime;
                    currentItem.Age();
                }
                else if (Items[i] is ItemLegendary)
                {
                    var currentItem = Items[i] as ItemLegendary;
                    currentItem.Age();
                }
                else if (Items[i] is ItemConferencePass)
                {
                    var currentItem = Items[i] as ItemConferencePass;
                    currentItem.Age();
                }
                else
                {
                    if (Items[i].Name != "Backstage passes for Re:factor"
                    && Items[i].Name != "Backstage passes for HAXX")
                    {
                        if (Items[i].Quality > 0)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                    // else
                    // {
                    //     if (Items[i].Quality < 50)
                    //     {
                    //         Items[i].Quality = Items[i].Quality + 1;
                    //
                    //         if (Items[i].Name == "Backstage passes for Re:factor"
                    //         || Items[i].Name == "Backstage passes for HAXX")
                    //         {
                    //             if (Items[i].SellIn < 11)
                    //             {
                    //                 if (Items[i].Quality < 50)
                    //                 {
                    //                     Items[i].Quality = Items[i].Quality + 1;
                    //                 }
                    //             }
                    //
                    //             if (Items[i].SellIn < 6)
                    //             {
                    //                 if (Items[i].Quality < 50)
                    //                 {
                    //                     Items[i].Quality = Items[i].Quality + 1;
                    //                 }
                    //             }
                    //         }
                    //     }
                    // }
                    Items[i].SellIn = Items[i].SellIn - 1;
                    if (Items[i].SellIn < 0)
                    {
                        if (Items[i].Name != "Backstage passes for Re:factor"
                            && Items[i].Name != "Backstage passes for HAXX")
                            {
                                if (Items[i].Quality > 0)
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                            else
                            {
                                Items[i].Quality = Items[i].Quality - Items[i].Quality;
                            }
                        }
                }
            }
        }
    }
}

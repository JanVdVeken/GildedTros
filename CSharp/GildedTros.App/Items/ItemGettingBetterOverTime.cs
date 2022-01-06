﻿using System;
using Xunit;
using Xunit.Sdk;

namespace GildedTros.App.Items
{
    public class ItemGettingBetterOverTime : Item, IAgingItem
    {
        public int QualitySpeed { get; private set; }
        public int SellInSpeed { get; private set; }
        private bool IsPassedSellIn = false;

        public ItemGettingBetterOverTime(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
            QualitySpeed = +1;
            SellInSpeed = -1;
        }
        public void Age()
        {
            if (!IsPassedSellIn && SellIn <= 0)
            {
                IsPassedSellIn = true;
                QualitySpeed *=2 ;
            }

            Quality += QualitySpeed;
            Quality = Math.Min(Quality,50);
            Quality = Math.Max(Quality,0);
            SellIn -= 1;
        }

        public void Print()
        {
            Console.WriteLine(Name + ", " + SellIn + ", " + Quality);
        }
    }
}
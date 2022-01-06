﻿using System;

namespace GildedTros.App.Items
{
    public class ItemConferencePass : Item, IAgingItem
    {
        public int QualitySpeed { get; private set; }
        public int SellInSpeed { get; private set; }
        private bool _isIncreaseBelowTen = false;
        private bool _isIncreaseBelowFive = false;

        public ItemConferencePass(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
            QualitySpeed = +1;
            SellInSpeed = -1;
        }
        public void Age()
        {

            if (!_isIncreaseBelowTen && SellIn <= 10)
            {
                _isIncreaseBelowTen = true;
                QualitySpeed += 1;
            }
            if (!_isIncreaseBelowFive && SellIn <= 5)
            {
                _isIncreaseBelowFive = true;
                QualitySpeed += 1;
            }

            Quality += QualitySpeed;
            Quality = Math.Min(Quality,50);
            Quality = Math.Max(Quality,0);
            if (SellIn <= 0) Quality = 0;
            
            SellIn--;
        }

        public void Print()
        {
            Console.WriteLine(Name + ", " + SellIn + ", " + Quality);
        }
    }
}
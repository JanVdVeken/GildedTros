using System;

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
            Quality = Math.Min(Quality + QualitySpeed,50);
            if (SellIn <= 0) Quality = 0;
            
            SellIn--;
        }
    }
}
using System;

namespace GildedTros.App.Items
{
    public class ItemGettingBetterOverTime : AxxesItem
    {
        private bool _isPassedSellIn;

        public ItemGettingBetterOverTime(string name) : base(name)
        {
            QualitySpeed = +1;
            SellInSpeed = -1;
        }

        public override void Age()
        {
            if (!_isPassedSellIn && SellIn <= 0)
            {
                _isPassedSellIn = true;
                QualitySpeed *= 2;
            }

            Quality += QualitySpeed;
            Quality = Math.Min(Quality, 50);
            Quality = Math.Max(Quality, 0);
            SellIn --;
        }
    }
}
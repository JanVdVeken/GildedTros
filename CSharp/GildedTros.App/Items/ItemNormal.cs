using System;

namespace GildedTros.App.Items
{
    public class ItemNormal : AxxesItem
    {
        private bool _isPassedSellIn;
    
        public ItemNormal(string name) : base(name)
        {
            QualitySpeed = +1;
            SellInSpeed = -1;
        }
        
        public override void Age()
        {
            
            if (!_isPassedSellIn && SellIn <= 0)
            {
                _isPassedSellIn = true;
                QualitySpeed *=2 ;
            }
            Quality -= QualitySpeed;
            Quality = Math.Max(0, Quality);
            Quality = Math.Min(50, Quality);
            SellIn--;
        }
    }
}
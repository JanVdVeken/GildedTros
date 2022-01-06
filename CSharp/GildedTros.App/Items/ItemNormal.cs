using System;

namespace GildedTros.App.Items
{
    public class ItemNormal : Item, IAgingItem
    {
        public int QualitySpeed { get; private protected set; }
        public int SellInSpeed { get; }
    
        private bool _isPassedSellIn;
    
        public ItemNormal(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
            QualitySpeed = +1;
            SellInSpeed = -1;
        }
        
        public void Age()
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

        public void Print()
        {
            Console.WriteLine(Name + ", " + SellIn + ", " + Quality);
        }
    }
}
using System;

namespace GildedTros.App.Items
{
    public class ItemLegendary : Item, IAgingItem
    {
        public int QualitySpeed { get; }
        public int SellInSpeed { get; }

        public ItemLegendary(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
            QualitySpeed = +0;
            SellInSpeed = -0;
        }
        public void Age()
        {
            throw new System.NotImplementedException();
        }
    }
}
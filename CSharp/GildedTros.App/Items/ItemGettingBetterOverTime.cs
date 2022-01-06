using System;

namespace GildedTros.App.Items
{
    public class ItemGettingBetterOverTime : Item, IAgingItem
    {
        public int AgingSpeed { get; }
        public int SellInSpeed { get; }

        public ItemGettingBetterOverTime(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
            AgingSpeed = +1;
            SellInSpeed = -1;
        }
        public void Age()
        {
            throw new System.NotImplementedException();
        }
    }
}
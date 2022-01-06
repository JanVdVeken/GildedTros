using System;

namespace GildedTros.App.Items
{
    public abstract class AxxesItem : Item,IAgingItem
    {
        public int QualitySpeed { get; private protected set; }
        public int SellInSpeed { get; private protected set; }
        public abstract void Age();
        public void Print()
        {
            Console.WriteLine(Name + ", " + SellIn + ", " + Quality);
        }
    }
}
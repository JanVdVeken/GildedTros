using System;

namespace GildedTros.App.Items
{
    public abstract class AxxesItem : Item,IAgingItem
    {
        public int QualitySpeed { get; private protected set; }
        public int SellInSpeed { get; private protected set; }
        public abstract void Age();

        public AxxesItem(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"{Name}, {SellIn}, {Quality}");
        }
    }
}
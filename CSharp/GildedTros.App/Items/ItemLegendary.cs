using System;

namespace GildedTros.App.Items
{
    public class ItemLegendary : AxxesItem
    {
        public ItemLegendary(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
            QualitySpeed = +0;
            SellInSpeed = -0;
        }
        public override void Age()
        {
            Quality = 80;
            SellIn = SellIn;
        }

        public void Print()
        {
            Console.WriteLine(Name + ", " + SellIn + ", " + Quality);
        }
    }
}
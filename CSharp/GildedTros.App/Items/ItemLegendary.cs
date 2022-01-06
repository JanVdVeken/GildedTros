using System;

namespace GildedTros.App.Items
{
    public class ItemLegendary : AxxesItem
    {
        public ItemLegendary(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            Name = name;
        }
        public override void Age()
        {
            Quality = 80;
        }
    }
}
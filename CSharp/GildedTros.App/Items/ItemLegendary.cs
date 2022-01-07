using System;

namespace GildedTros.App.Items
{
    public class ItemLegendary : AxxesItem
    {
        public ItemLegendary(string name) : base(name)
        {
        }
        public override void Age()
        {
            Quality = 80;
        }
    }
}
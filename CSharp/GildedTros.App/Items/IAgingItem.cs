namespace GildedTros.App.Items
{
    public interface IAgingItem
    {
        public int AgingSpeed { get; }
        public int SellInSpeed { get; }
        public void Age();
    }
}
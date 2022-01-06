namespace GildedTros.App.Items
{
    public interface IAgingItem
    {
        public int QualitySpeed { get; }
        public int SellInSpeed { get; }
        public void Age();
    }
}
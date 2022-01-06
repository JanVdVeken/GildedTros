namespace GildedTros.App.Items
{
    public class ItemSmelly : ItemNormal
    {
        public ItemSmelly(string name) : base(name)
        {
            QualitySpeed *= 2;
        }
    }
}
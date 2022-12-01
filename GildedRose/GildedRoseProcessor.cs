namespace GildedRose.Main
{
    public class GildedRoseProcessor
    {
        private const string ITEM_NAME_AGED_BRIE = "Aged Brie";
        private const string ITEM_NAME_BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string ITEM_NAME_SULFURAS = "Sulfuras, Hand of Ragnaros";
        public Item[] Items { get; }

        public GildedRoseProcessor(Item[] items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case ITEM_NAME_SULFURAS:
                        continue;
                    case ITEM_NAME_AGED_BRIE:
                        item.UpdateAgedBrie();
                        continue;
                    case ITEM_NAME_BACKSTAGE_PASSES:
                        item.UpdateBackstagePasses();
                        continue;
                    default:
                        item.UpdateNormalItem();
                        continue;
                }
            }
        }
    }
}
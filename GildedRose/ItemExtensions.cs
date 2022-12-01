namespace GildedRose.Main;

public static class ItemExtensions
{
    public static void UpdateNormalItem(this Item item)
    {
        item.DecreaseQualityBy();

        item.Age();

        if (item.SellIn < 0 && item.Quality > 0)
        {
            item.DecreaseQualityBy();
        }
    }
    public static void UpdateBackstagePasses(this Item passes)
    {
        switch (passes.SellIn)
        {
            case <= 0:
                passes.Quality = 0;
                break;
            case < 6:
                passes.IncreaseQualityBy(3);
                break;
            case < 11:
                passes.IncreaseQualityBy(2);
                break;
            default:
                passes.IncreaseQualityBy();
                break;
        }

        passes.Age();
    }
    
    public static void UpdateAgedBrie(this Item agedBrie)
    {
        if (agedBrie.SellIn > 0)
        {
            agedBrie.IncreaseQualityBy();
        }

        if (agedBrie.SellIn <= 0)
        {
            agedBrie.IncreaseQualityBy(2);
        }

        agedBrie.Age();

    }

    private static void Age(this Item item)
    {
        item.SellIn -= 1;
    }

    private static void IncreaseQualityBy(this Item item, int multiplier = 1)
    {
        if (item.Quality < 50)
        {
            item.Quality += multiplier;
        }
    }

    private static void DecreaseQualityBy(this Item item, int multiplier = 1)
    {
        if (item.Quality > 0)
        {
            item.Quality -= multiplier;
        }
    }
}
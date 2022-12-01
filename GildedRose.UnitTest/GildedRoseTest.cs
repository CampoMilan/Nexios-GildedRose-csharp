using GildedRose.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseItems.UnitTest
{
    [TestClass]
    public class GildedRoseTest
    {
        //GildedRose
        [TestMethod]
        public void when_SellIn_greater_than_0_and_Quality_greater_than_0_decrease_Quality_by_1()
        {
            Item[] Items = new Item[] { new Item("foo", 3, 10) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 2);
            Assert.AreEqual(app.Items[0].Quality, 9);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 1);
            Assert.AreEqual(app.Items[0].Quality, 8);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 7);
        }

        [TestMethod]
        public void when_SellIn_greater_than_0_and_Quality_0_decrease_Quality_by_0()
        {
            Item[] Items = new Item[] { new Item("foo", 3, 0) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 2);
            Assert.AreEqual(app.Items[0].Quality, 0);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 1);
            Assert.AreEqual(app.Items[0].Quality, 0);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 0);
        }

        [TestMethod]
        public void when_SellIn_0_or_less_and_Quality_greater_than_0_decrease_Quality_by_2()
        {
            Item[] Items = new Item[] { new Item("foo", 0, 7) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -1);
            Assert.AreEqual(app.Items[0].Quality, 5);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -2);
            Assert.AreEqual(app.Items[0].Quality, 3);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -3);
            Assert.AreEqual(app.Items[0].Quality, 1);
        }

        [TestMethod]
        public void when_SellIn_0_or_less_and_Quality_0_decrease_Quality_by_0()
        {
            Item[] Items = new Item[] { new Item("foo", 0, 0) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -1);
            Assert.AreEqual(app.Items[0].Quality, 0);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -2);
            Assert.AreEqual(app.Items[0].Quality, 0);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -3);
            Assert.AreEqual(app.Items[0].Quality, 0);
        }

        // AgedBrie
        [TestMethod]
        public void when_SellIn_greater_than_0_and_Quality_less_than_50_increase_Quality_by_1()
        {
            Item[] Items = new Item[] { new Item("Aged Brie", 3, 0) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 2);
            Assert.AreEqual(app.Items[0].Quality, 1);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 1);
            Assert.AreEqual(app.Items[0].Quality, 2);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 3);
        }

        [TestMethod]
        public void when_SellIn_greater_than_0_and_Quality_50_increase_Quality_by_0()
        {
            Item[] Items = new Item[] { new Item("Aged Brie", 3, 50) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 2);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 1);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 50);
        }

        [TestMethod]
        public void when_SellIn_0_or_less_and_Quality_less_than_50_increase_Quality_by_2()
        {
            Item[] Items = new Item[] { new Item("Aged Brie", 0, 0) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -1);
            Assert.AreEqual(app.Items[0].Quality, 2);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -2);
            Assert.AreEqual(app.Items[0].Quality, 4);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -3);
            Assert.AreEqual(app.Items[0].Quality, 6);
        }


        [TestMethod]
        public void when_SellIn_0_or_less_and_Quality_50_increase_Quality_by_0()
        {
            Item[] Items = new Item[] { new Item("Aged Brie", 0, 50) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -1);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -2);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -3);
            Assert.AreEqual(app.Items[0].Quality, 50);
        }

        // Backstagepasses
        [TestMethod]
        public void when_SellIn_greater_than_10_and_Quality_less_than_50_increase_Quality_by_1()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 13, 0) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 12);
            Assert.AreEqual(app.Items[0].Quality, 1);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 11);
            Assert.AreEqual(app.Items[0].Quality, 2);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 10);
            Assert.AreEqual(app.Items[0].Quality, 3);
        }

        [TestMethod]
        public void when_SellIn_greater_than_10_and_Quality_50_increase_Quality_by_0()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 13, 50) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 12);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 11);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 10);
            Assert.AreEqual(app.Items[0].Quality, 50);
        }

        [TestMethod]
        public void when_SellIn_10_or_less_and_Quality_less_than_50_increase_Quality_by_2()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 8, 0) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 7);
            Assert.AreEqual(app.Items[0].Quality, 2);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 6);
            Assert.AreEqual(app.Items[0].Quality, 4);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 5);
            Assert.AreEqual(app.Items[0].Quality, 6);
        }

        [TestMethod]
        public void when_SellIn_10_or_less_and_Quality_50_increase_Quality_by_0()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 8, 50) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 7);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 6);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 5);
            Assert.AreEqual(app.Items[0].Quality, 50);
        }

        [TestMethod]
        public void when_SellIn_5_or_less_and_Quality_less_than_50_increase_Quality_by_3()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 3, 0) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 2);
            Assert.AreEqual(app.Items[0].Quality, 3);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 1);
            Assert.AreEqual(app.Items[0].Quality, 6);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 9);
        }

        [TestMethod]
        public void when_SellIn_5_or_less_and_Quality_50_increase_Quality_by_0()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 3, 50) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 2);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 1);
            Assert.AreEqual(app.Items[0].Quality, 50);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 50);
        }

        [TestMethod]
        public void when_SellIn_0_and_Quality_less_than_50_increase_Quality_to_0()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 0, 10) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -1);
            Assert.AreEqual(app.Items[0].Quality, 0);
        }

        [TestMethod]
        public void when_SellIn_0_and_Quality_50_increase_Quality_to_0()
        {
            Item[] Items = new Item[] { new Item("Backstage passes to a TAFKAL80ETC concert", 0, 50) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -1);
            Assert.AreEqual(app.Items[0].Quality, 0);
        }

        // Sulfuras
        [TestMethod]
        public void the_hand_is_eternal_and_unchanging()
        {
            Item[] Items = new Item[] { new Item("Sulfuras, Hand of Ragnaros", 0, 80) };
            GildedRoseProcessor app = new GildedRoseProcessor(Items);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 80);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 80);

            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 0);
            Assert.AreEqual(app.Items[0].Quality, 80);
        }

    }
}

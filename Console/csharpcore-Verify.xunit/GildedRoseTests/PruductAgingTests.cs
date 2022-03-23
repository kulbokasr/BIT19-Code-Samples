using FluentAssertions;
using GildedRose.Aging;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class PruductAgingTests
    {
        [Fact]
        public void AgedBrieTest()
        {
            Item AgedBrieItem = new Item()
            {
                Name = "Aged Brie",
                SellIn = 2,
                Quality = 0
            };
            Item AgedBrieControlItem = new Item()
            {
                Name = "Aged Brie",
                SellIn = -48,
                Quality = 50
            };
            var _productFactory = new CalculationService();
            for (var i = 0; i < 50; i++)
            {
                _productFactory.ChooseProduct(AgedBrieItem);
            }
            AgedBrieItem.Quality.Should().Be(AgedBrieControlItem.Quality);
            AgedBrieItem.SellIn.Should().Be(AgedBrieControlItem.SellIn);
        }

    }
}

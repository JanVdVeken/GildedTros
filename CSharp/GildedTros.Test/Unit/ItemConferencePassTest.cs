using System;
using GildedTros.App.Items;
using GildedTros.Test.Unit.Helper;
using Xunit;

namespace GildedTros.Test.Unit
{
    public class ItemConferencePassTest
    {
        [Fact]
        public void Ctor_GivenNoName_ShouldReturnNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ItemConferencePass(null));
        }
        [Fact]
        public void Ctor_GivenSomeName_ShouldHaveThatName()
        {
            var itemConferencePass = new ItemConferencePass(TestItems.SomeName);
            
            Assert.Equal(TestItems.SomeName,itemConferencePass.Name);
        }

        [Fact]
        public void Age_GivenNegativeSellIn_ShouldSetQualityToZero()
        {
            var itemConferencePass = new ItemConferencePass(TestItems.SomeName)
            {
                SellIn = TestItems.SomeSellInLessThanZero,
                Quality = TestItems.SomeQualityGreaterThanZero
            };
            
            itemConferencePass.Age();
            
            Assert.Equal(0,itemConferencePass.Quality);
        }
        
        [Fact]
        public void Age_GivenSomeSellInAboveTen_ShouldIncreaseQualityWithOne()
        {
            var itemConferencePass = new ItemConferencePass(TestItems.SomeName)
            {
                SellIn = TestItems.SomeSellInGreaterThanTen,
                Quality = 10
            };
            
            itemConferencePass.Age();
            
            Assert.Equal(11,itemConferencePass.Quality);
        }
        [Fact]
        public void Age_GivenSomeSellInTenOrBelowAboveFive_ShouldIncreaseQualityWithTwo()
        {
            var itemConferencePass = new ItemConferencePass(TestItems.SomeName)
            {
                SellIn = TestItems.SomeSellInGreaterBelowTenGreaterThanFive,
                Quality = 10
            };
            
            itemConferencePass.Age();
            
            Assert.Equal(12,itemConferencePass.Quality);
        }
        [Fact]
        public void Age_GivenSomeSellInFiveOrBelow_ShouldIncreaseQualityWithThree()
        {
            var itemConferencePass = new ItemConferencePass(TestItems.SomeName)
            {
                SellIn = 5,
                Quality = 10
            };
            
            itemConferencePass.Age();
            
            Assert.Equal(13,itemConferencePass.Quality);
        }
        [Fact]
        public void Age_GivenSomeNegativeQuality_ShouldPutQualityToZero()
        {
            var itemGettingBetterOverTime = new ItemConferencePass(TestItems.SomeName)
            {
                Quality = TestItems.SomeQualityLessThanZero,
                SellIn = TestItems.SomeSellInGreaterThanZero
            };
                
            itemGettingBetterOverTime.Age();
                
            Assert.Equal(0,itemGettingBetterOverTime.Quality);
        }
        
    }
}


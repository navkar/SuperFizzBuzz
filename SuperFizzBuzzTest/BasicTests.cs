using System;
using Xunit;
using SuperFizzBuzz;
using System.Collections.Generic;

namespace SuperFizzBuzzTest
{
    public class BasicTests
    {
        private SuperFizzBuzz.Math instance = null;

        public BasicTests()
        {
            instance = new SuperFizzBuzz.Math();
        }

        [Fact]
        public void FizzTest()
        {
            List<string> items = instance.Sequence(3, 5);

            int count = items.Count;
            Assert.True(count == 3);

            string expected = "Fizz";
            Assert.True(items[0] == expected);

            expected = "Buzz";
            Assert.True(items[2] == expected);
        }

        [Fact]
        public void FizzBuzzTest()
        {
            List<string> items = instance.Sequence(14, 15);

            int count = items.Count;
            Assert.True(count == 2);

            var expected = "FizzBuzz";
            Assert.True(items[1] == expected);
        }

        [Fact]
        public void FrogDuckChickenTest()
        {
            var moreTokens = new Dictionary<int, string>
            {
                { 4, "Frog" },
                { 13, "Duck" },
                { 9, "Chicken" },
            };

            var advanced = new SuperFizzBuzz.Math(moreTokens);
            List<string> items = advanced.Sequence((new List<int> { 52, 36, 468 }));

            int count = items.Count;
            Assert.True(count == 3);

            var expected = "FrogDuck";
            Assert.True(items[0] == expected);

            expected = "FrogChicken";
            Assert.True(items[1] == expected);

            expected = "FrogDuckChicken";
            Assert.True(items[2] == expected);
        }

        [Fact]
        public void FizzBuzzBazzTest()
        {
            var moreTokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 7, "Buzz" },
                { 38, "Bazz" },
            };

            var advanced = new SuperFizzBuzz.Math(moreTokens);
            List<string> items = advanced.Sequence((new List<int> { 3, 7, 38 }));

            int count = items.Count;
            Assert.True(count == 3);

            var expected = "Fizz";
            Assert.True(items[0] == expected);

            expected = "Buzz";
            Assert.True(items[1] == expected);

            expected = "Bazz";
            Assert.True(items[2] == expected);
        }
    }
}

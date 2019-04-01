using divisible;
using NUnit.Framework;
using System.Collections.Generic;

namespace test
{
    [TestFixture]
    public class MathHelperSpecs
    {
        [TestFixture]
        public class DivisibleOfThree
        {
            int divisible;

            [SetUp]
            public void Given()
            {
                divisible = 3;
            }

            [Test]
            public void WhenMinOf5AndMaxOf40()
            {
                List<int> expected = new List<int> { 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39 };
                List<int> result = MathHelper.FindDivisible(divisible, 5, 40);
                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void WhenMinOfNegative30AndMaxOfNegative5()
            {
                List<int> expected = new List<int> { -30, -27, -24, -21, -18, -15, -12, -9, -6, };
                List<int> result = MathHelper.FindDivisible(divisible, -30, -5);
                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void WhenMinOfNegative20AndMaxOf20()
            {
                List<int> expected = new List<int> { -18, -15, -12, -9, -6, -3, 0, 3, 6, 9, 12, 15, 18 };
                List<int> result = MathHelper.FindDivisible(divisible, -20, 20);
                Assert.That(result, Is.EqualTo(expected));
            }
        }
    }
}

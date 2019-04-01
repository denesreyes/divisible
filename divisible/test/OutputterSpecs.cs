using divisible;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class OutputterSpecs
    {
        [Test]
        public void WhenNumber5ToEnglish()
        {
            string expected = "five";
            string result = Outputter.NumberToEnglish(5);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenNumber11ToEnglish()
        {
            string expected = "eleven";
            string result = Outputter.NumberToEnglish(11);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenNumber57ToEnglish()
        {
            string expected = "fifty-seven";
            string result = Outputter.NumberToEnglish(57);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenNumber119ToEnglish()
        {
            string expected = "one hundred nineteen";
            string result = Outputter.NumberToEnglish(119);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenNumber4343ToEnglish()
        {
            string expected = "four thousand three hundred forty-three";
            string result = Outputter.NumberToEnglish(4343);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenNumber902679ToEnglish()
        {
            string expected = "nine hundred two thousand six hundred seventy-nine";
            string result = Outputter.NumberToEnglish(902679);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenNumber356026788ToEnglish()
        {
            string expected = "three hundred fifty-six million twenty-six thousand seven hundred eighty-eight";
            string result = Outputter.NumberToEnglish(356026788);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

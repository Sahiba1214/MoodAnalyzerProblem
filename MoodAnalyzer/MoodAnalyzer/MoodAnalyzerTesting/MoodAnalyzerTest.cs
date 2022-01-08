using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            this.moodAnalyser = new MoodAnalyser();
        }

        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string expected = "Sad";
            string actual = moodAnalyser.AnalyzeMood("I am in Sad mood");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string expected = "Happy";
            string actual = moodAnalyser.AnalyzeMood("I am in Any mood");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string expected = "Happy";
            string actual = moodAnalyser.AnalyzeMood(null);
            Assert.AreEqual(expected, actual);
        }
    }
}
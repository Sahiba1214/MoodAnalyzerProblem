using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "Sad";
            string actual = moodAnalyser.AnalyzeMood("I am in Sad mood");
            Assert.AreEqual(expected, actual);
        }
        public void Test2()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "Happy";
            string actual = moodAnalyser.AnalyzeMood("I am in Any mood");
            Assert.AreEqual(expected, actual);
        }
    }
}

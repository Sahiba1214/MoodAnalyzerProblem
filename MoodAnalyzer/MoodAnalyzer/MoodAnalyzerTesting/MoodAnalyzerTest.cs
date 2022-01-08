using MoodAnalyzer;
using NUnit.Framework;
using System;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            this.moodAnalyser = new MoodAnalyser("Empty Mood");
        }

        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string expected = "Sad";
            string actual = moodAnalyser.AnalyzeMood("I am in Sad mood");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenInvalidMood_WhenAnalyze_ShouldReturnMoodAnalyzeException()
        {
            string expected = "Happy";
            string actual = moodAnalyser.AnalyzeMood("Empty Mood");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnExceptionMessage()
        {
            try
            {
                string expected = "Mood Should Not be Null";
                string actual = moodAnalyser.AnalyzeMood(null);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Mood Should Not be Null", e.Message);
            }
        }
    }
}

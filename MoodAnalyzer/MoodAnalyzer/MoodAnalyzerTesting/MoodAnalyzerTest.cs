using MoodAnalyzer;
using NUnit.Framework;
using System;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        private readonly object MoodAnalyseFactory;

        [SetUp]
        public void Setup()
        {
            this.moodAnalyser = new MoodAnalyser("Empty Mood");
        }

        [Test] // Given "I am in Sad Mood"  Message Should Return Sad
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string expected = "Sad";
            string actual = moodAnalyser.AnalyzeMood("I am in Sad mood");
            Assert.AreEqual(expected, actual);
        }

        [Test] // Given Empty Mood should throw MoodAnalysisException.
        public void GivenInvalidMood_WhenAnalyze_ShouldReturnMoodAnalyzeException()
        {
            string expected = "Happy";
            string actual = moodAnalyser.AnalyzeMood("Empty Mood");
            Assert.AreEqual(expected, actual);
        }
        [Test] // Given Null Mood should throw MoodAnalysisException.
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
        [Test] // Given Mood Analyse Class Name Should throw MoodAnalysisException.
        public void GivenMoodAnalyseClassName_WhenAnalyze_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerTesting.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        [Test] // Given ClassName Improper Should Return MoodAnalysis Exception
        public void GivenClassNameImproper_WhenAnalyze_ShouldReturnMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProject.moodAnalysis", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Construtor is not Found", e.Message);
            }
        }
    }
} 
using System;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string AnalyzeMood(string Massage)
        {
            try
            {
                if (Massage.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch
            {
                return "Happy";
            }

        }
    }
}
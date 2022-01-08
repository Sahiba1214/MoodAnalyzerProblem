using System;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        string ne;
        public string AnalyzeMood(string Massage)
        {
            if (Massage.Contains("Sad"))
                return ne = "Sad";
            else
                return "Happy";
        }
    }
}


// See https://aka.ms/new-console-template for more information
using System;
namespace MoodAnalyzerAppWithCore
{
    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            catch

            {
                return "HAPPY";
            }
        }
    }
}

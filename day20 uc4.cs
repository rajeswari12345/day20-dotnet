// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

namespace MoodAnalyzerApp
{
    public class MoodAnalyzFactory
    {
        ///summary
        /// CreatMoodAnalyze method to create object of MoodAnalyzer class
        /// </summary>
        public static object CreateMoodAnalyze(string className, string consturctorName)
        {
            string pattern = @"." + consturctorName + "$";
            Match   result = Regex.Match(className, pattern);
            if (result.success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutionAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD ,"Constructor Not Found") ; 
            }
        }
    }
}

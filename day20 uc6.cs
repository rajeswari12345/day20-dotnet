// See https://aka.ms/new-console-template for more information
using System;
using system.Reflections;
{
public static string InvokeAnalyseMethod(string message , string Method Name)
{
    try
    {
        Type type = type.GetType("MoodAnalyzerApp , MoodAnalyse");
        object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp, MoodAnalyse ,
          " MoodAnalyse", message ");
          MethodInfo analyseMoodInfo = Type.GetMethod(MethodName);
        object mood = analyseMoodInfo.Invoke(moodAnalyseObject, Null);
        return mood.ToString();
    }
    catch (NullReferenceException)
    {
        throw new MoodAnalysisException(MoodAnalysisException.Exception.No_SUCH_METHOD, "method is not found");
    }
}

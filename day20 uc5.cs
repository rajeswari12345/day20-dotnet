// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

/// <summary>
/// CreateMoodAnalyse method to create object of MoodAnalyze Class
/// </summary>s
/// <param name="ClassName"></param>
/// <param name="message"></param>
/// <return></return>
public static object CreateMoodAnalyseUsingParameterizedConstructor(string classname,string constructor, string message, object? ConstructorName)
{
    Type type = typeof(MoodAnalysisException);
    if (type.Name.Equals(classname) || type.FullName.Equals(classname))
    {
        if (type.Name.Equals(ConstructorName))
        {
            var ctor = Type.GetConstructor(new[] { typeOf(string) });
            Object Instance = ctor.Invoke(new object[] { message });
            return Instance;
        }
        else
        {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
        }
    }
    else
    {
        throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
    }
}
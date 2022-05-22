// See https://aka.ms/new-console-template for more information
using System;
public static  void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
{
    Object expeected = new MoodAnalyse();
    object obj = MoodAnalyseFactory.CreateMoodAnalyse(" MoodAnalyzerApp.MoodAnalyse", "MoodAnalyze");
    expected.Equals(obj);
}


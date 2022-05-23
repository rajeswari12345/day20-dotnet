using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyzerMSTestWithCore
{
    public class unitTest1
    {
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodanalyse = new MoodAnalyzer(message);

            //Act
            string mood = moodAnalze.AnalyseMood();

            //Assert 
            Assert.AreEqual(expected, mood);
        }
    }

}
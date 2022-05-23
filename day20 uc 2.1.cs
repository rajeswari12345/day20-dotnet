// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
{
namespace MoodAnalyzerMSTestWithCore
{
;
///[DataRow["i am in HAPPY Mood"]]
[DataRow(null)) 
namespace MoodAnalyzerMSTestWithCore
{
    public class unitTest1
    {
        public void GivenSadMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in happy Mood";
            MoodAnalyser moodanalyse = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyse.AnalyseMood();
            //Assert 
            Assert.AreEqual(expected, mood);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
{
namespace MoodAnalyzerMSTestWithCore
{
    
using MSTestMoodAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("HAPPY");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);
        }

        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("SAD");
            string result = obj.analyseMood();
            Assert.AreEqual("SAD", result);
        }
    }

}

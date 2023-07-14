using MoodAnalyserProblem;

namespace MoodAnalyser_Tests
{
    public class AnalyserMood
    {
        
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyser moodAnalyse = new MoodAnalyser("I am in Sad Mood");
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Sad");

        }

        [Test]
        public void GivenMood_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyse = new MoodAnalyser("I am in any Mood");
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyse = new MoodAnalyser(null);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
    }


}
using MoodAnalyzerProblem;

namespace MoodTest
{
    public class Tests
    {
        //TC 1.1
        [Test]
        public void SadMood()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void HappyMood()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
        //[DataRow("I am in Happy Mood")]
        //[DataRow(null)]
        public void TestMethodAnalayzerForHappyMood()
        {
            ///AAA methodology
            ///arrange
            string message = "Im in Happy mood";

            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string Actual = analyser.AnalyseMood();

            //Assert
            Assert.AreEqual(Actual, "HAPPY");
        }
    }
}
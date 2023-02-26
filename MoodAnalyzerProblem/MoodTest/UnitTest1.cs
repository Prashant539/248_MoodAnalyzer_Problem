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
        //TC 1.2    
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
        //TC 2.1
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
        //TC 3.1
        [Test]
        public void TestMethodForCustomizedNullException()

        {
            string expected = "Mood should not be null";
            try
            {

                MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);
                moodAnalyser.AnalyseMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }


        }
        //TC 3.2
        [Test]
        public void TestMethodForCustomizedEmptyException()
        {
            string expected = "Mood should not be empty";
            try
            {

                MoodAnalyzer moodAnalyser = new MoodAnalyzer(string.Empty);
                moodAnalyser.AnalyseMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //TC 4.1
        [Test]
        public void Reflection_Return_Default_Constructor()
        {
            MoodAnalyzer expected = new MoodAnalyzer();
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject("MoodAnalyserProblem2.MoodAnalyser", "MoodAnalyser");

            }
            catch (CustomException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //TC 4.2
        [Test]
        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "Class not found";
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject("MoodAnalyserProblem2.MoodAnaly", "MoodAnaly");

            }
            catch (CustomException actual)

            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        //TC 4.3
        [Test]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "Constructor not found";
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject("MoodAnalyserProblem2.MoodAnalyser", "MoodAnaly");

            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
       
    }
}
    

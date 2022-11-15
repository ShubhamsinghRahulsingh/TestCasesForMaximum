using FindMaximumNumber;

namespace FindMaxNumTest
{
    public class FindMaxNumberTest
    {
        FindMaxNum maximum = new FindMaxNum();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()//Max num at first position
        {
            int result = maximum.FindMaxInteger(23, 17, 14); //AAA(Act,Arrange,Assert)
            Assert.AreEqual(23,result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()//max number at second position
        {
            int result = maximum.FindMaxInteger(17, 23, 14); //AAA(Act,Arrange,Assert)
            Assert.AreEqual(23, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()//max num at third position
        {
            int result = maximum.FindMaxInteger(14, 17, 23); //AAA(Act,Arrange,Assert)
            Assert.AreEqual(23, result);
        }
        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()//Max num at first position
        {
            float result = maximum.FindMaxFloat(23.0f, 17.0f, 14.0f); //AAA(Act,Arrange,Assert)
            Assert.AreEqual(23.0, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()//max number at second position
        {
            float result = maximum.FindMaxFloat(17.0f, 23.0f, 14.0f); //AAA(Act,Arrange,Assert)
            Assert.AreEqual(23.0, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()//max num at third position
        {
            float result = maximum.FindMaxFloat(14.0f, 17.0f, 23.0f); //AAA(Act,Arrange,Assert)
            Assert.AreEqual(23.0, result);
        }
        [Test]
        public void GivenMaxFirstNumstring_WhenAnalysed_ShouldReturnFirstMax()//Max string at first position
        {
            string result = maximum.FindMaxString("Peach","Banana","Apple"); //AAA(Act,Arrange,Assert)
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()//max string at second position
        {
            string result = maximum.FindMaxString("Banana", "Peach", "Apple"); //AAA(Act,Arrange,Assert)
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()//max string at third position
        {
            string result = maximum.FindMaxString("Banana", "Apple", "Peach"); //AAA(Act,Arrange,Assert)
            Assert.AreEqual("Peach", result);
        }
    }
}
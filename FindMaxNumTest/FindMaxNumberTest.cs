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
    }
}
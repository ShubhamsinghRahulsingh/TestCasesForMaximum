using FindMaximumNumber;

namespace FindMaxNumTest
{
    public class FindMaxNumberTest
    {
        FindMaxGeneric generic = new FindMaxGeneric();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()//max number at first position
        {
            int result = generic.FindMaximumGeneric(23, 17, 14);//using generic method 
            Assert.AreEqual(23,result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()//max number at second position
        {
            int result = generic.FindMaximumGeneric(17, 23, 14); //using generic method
            Assert.AreEqual(23, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()//max num at third position
        {
            int result = generic.FindMaximumGeneric(14, 17, 23); //using generic method
            Assert.AreEqual(23, result);
        }
        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()//Max num at first position
        {
            float result = generic.FindMaximumGeneric(23.0f, 17.0f, 14.0f);//using generic method 
            Assert.AreEqual(23.0, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()//max number at second position
        {
            float result = generic.FindMaximumGeneric(17.0f, 23.0f, 14.0f);//using generic method
            Assert.AreEqual(23.0, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()//max num at third position
        {
            float result = generic.FindMaximumGeneric(14.0f, 17.0f, 23.0f); //using generic method
            Assert.AreEqual(23.0, result);
        }
        [Test]
        public void GivenMaxFirstNumstring_WhenAnalysed_ShouldReturnFirstMax()//Max string at first position
        {
            string result = generic.FindMaximumGeneric("Peach","Banana","Apple"); //using generic method
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()//max string at second position
        {
            string result = generic.FindMaximumGeneric("Banana", "Peach", "Apple");//using generic method
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()//max string at third position
        {
            string result = generic.FindMaximumGeneric("Banana", "Apple", "Peach"); //using generic method
            Assert.AreEqual("Peach", result);
        }
    }
}
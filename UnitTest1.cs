using NUnit.Framework;

namespace SencusAnalyzerFinal
{
    public class Tests
    {

        
      

        [Test]
        public void givenStateCodeSencusData_ifHasCorrectNumberOfRecord_ShouldReturnTrue()
        {
            SencusAnalyzer sencusAnalyzer = new SencusAnalyzer();
            int count= sencusAnalyzer.LoadStateCodeData();
            Assert.AreEqual(37, count);
        }


       
    }
}
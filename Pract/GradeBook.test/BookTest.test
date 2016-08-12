using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice2;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateHighestValue()
        {
            GradeBook book = new GradeBook();

            book.StoreGrade(90f);
            book.StoreGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.highest_grade);
            
        }
    }
}

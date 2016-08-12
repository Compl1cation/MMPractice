using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBooks;

namespace GradeBookTest
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.StoreGrade(12.45);
            book.StoreGrade(34.12);
            book.StoreGrade(1);
            book.StoreGrade(-5);
            
            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(1, stats.LowestGrade);
            Assert.AreEqual(15.86, stats.AverageGrade);
            Assert.AreEqual(34.12, stats.HighestGrade);
        }
    }
}

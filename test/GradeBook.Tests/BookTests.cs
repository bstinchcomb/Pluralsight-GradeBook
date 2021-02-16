using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var book = new Book("Test");
            book.AddGrade(14.7);
            book.AddGrade(25.8);
            book.AddGrade(36.9);

            // Act
            var result = book.GetStatistics();
            var sum = 77.4;
            var average = 25.8;
            var high = 36.9;
            var low = 14.7;

            // Assert
            Assert.Equal(sum, result.Sum);
            Assert.Equal(average, result.Average, 1);
            Assert.Equal(high, result.High, 1);
            Assert.Equal(low, result.Low, 1);
        }
    }
}

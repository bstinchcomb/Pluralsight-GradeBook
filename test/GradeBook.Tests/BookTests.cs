using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // Arrange
            var book = new Book("Test");
            book.AddGrade(82.7);
            book.AddGrade(95.8);
            book.AddGrade(99.9);

            // Act
            var result = book.GetStatistics();
            var sum = 278.4;
            var average = 92.8;
            var high = 99.9;
            var low = 82.7;

            // Assert
            Assert.Equal(sum, result.Sum);
            Assert.Equal(average, result.Average, 1);
            Assert.Equal(high, result.High, 1);
            Assert.Equal(low, result.Low, 1);
            Assert.Equal('A', result.Letter);
        }
    }
}

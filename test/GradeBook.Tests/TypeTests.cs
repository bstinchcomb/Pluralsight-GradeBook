using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        private void StringsBehaveLikeValueType()
        {
            string name = "Brad";
            var upper = MakeUppercase(name);

            Assert.Equal("Brad", name);
            Assert.Equal("BRAD", upper);
        }

        private string MakeUppercase(string input)
        {
            return input.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            Assert.Equal(3, x);

            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanAlsoOutputRef()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            
            // Act
            GetBookOutputName(out book1, "New Name");

            // Assert
            Assert.Equal("New Name", book1.Name);
        }
        private void GetBookOutputName(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            
            // Act
            GetBookSetName(ref book1, "New Name");

            // Assert
            Assert.Equal("New Name", book1.Name);
        }
        private void GetBookSetName(ref Book book, string name)
        {
            // Either version works for "ref"
            //book = new Book(name);
            book.Name = name;
        }
        
        [Fact]
        public void CSharpIsPassByValue()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            
            // Act
            GetBookSetName(book1, "New Name");

            // Assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            
            // Act
            SetName(book1, "New Name");

            // Assert
            Assert.Equal("New Name", book1.Name);
        }
        private void SetName(Book book1, string newName)
        {
            book1.Name = newName;
        }

        [Fact]
        public void GetBookReturnsDifferentBooks()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // Act

            // Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameBook()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            var book3 = book1;

            // Act

            // Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.Equal("Book 1", book3.Name);
            Assert.Same(book1, book3);
            Assert.True(Object.ReferenceEquals(book1, book3));
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

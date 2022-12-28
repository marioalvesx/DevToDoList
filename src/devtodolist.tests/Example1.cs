using DevToDoList.API.Entities;
using Xunit.Abstractions;

namespace devtodolist.tests
{
    public class Example1 
    {        
        [Fact]
        public void ValidDevTodo()
        {
            // Arrange
            var devTodo = new DevTodo("Unit Tests for develpment", "Test Driven development", true);
            var expected = true;
            
            // Act
            var result = devTodo.AddReaction(true);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void InvalidDevTodo()
        {
            // Arrange
            var devTodo = new DevTodo("Unit Tests for development", "Test Driven development", true);
            var expected = false;
            
            // Act
            var result = devTodo.AddReaction(true);

            // Assert
            Assert.NotNull(devTodo);
            Assert.Equal(expected, result);

        }

        [Fact]
        public void TitleLengthValid()
        {
            // Arrange
            var devTodo = new DevTodo("Unit Tests for development", "Test Driven development", true);
            var expected = false;
            
            // Act
            var result = devTodo.TitleLengthValid();

            // Assert            
            Assert.Equal(expected, result);

        }

    }
}
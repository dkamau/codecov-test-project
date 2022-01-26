using System;
using Xunit;

namespace CodeCovSampleTestProject.UnitTests
{
    public class TestClass_UnitTests
    {
        [Fact]
        public void CanVote_RetunrsTrue_IfOver18()
        {
            // Arrange
            MyTestClass myTestClass = new MyTestClass();

            // Act 
            var result = myTestClass.CanVote(DateTime.Now.AddYears(-18));

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanVote_RetunrsFalse_IfUnder18()
        {
            // Arrange
            MyTestClass myTestClass = new MyTestClass();

            // Act 
            var result = myTestClass.CanVote(DateTime.Now.AddYears(-17));

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ExceptionTest()
        {
            // Arrange
            MyTestClass myTestClass = new MyTestClass();

            // Act 
            Action action = () => myTestClass.CanVote(null);
            NullReferenceException exception = Assert.Throws<NullReferenceException>(action);

            // Assert
            Assert.Equal("DOB", exception.Message);
        }
    }
}


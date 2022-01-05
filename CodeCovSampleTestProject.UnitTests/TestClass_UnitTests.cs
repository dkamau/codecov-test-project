using System;
using Xunit;

namespace CodeCovSampleTestProject.UnitTests
{
    public class TestClass_UnitTests
    {
        [Fact]
        public void CanVote_RetunrsTrue_IfUnder18()
        {
            // Arrange
            MyTestClass myTestClass = new MyTestClass();

            // Act 
            var result = myTestClass.CanVote(DateTime.Now.AddYears(-18));

            // Assert
            Assert.True(result);
        }
    }
}

using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _01Adapter.Tests
{
    [TestClass]
    public class AdapterExampleTest
    {
        [TestMethod]
        public void ShouldAdapterExampleThrowExceptionIfArgumentNull()
        {
            // AAA
            // Arrange
            AdapterExample sut;

            // Act
            Action todo = () => sut = new AdapterExample(null, null);

            // Assert
            todo.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void ShouldAdapterExampleThrowExceptionIfFirstArgumentNull()
        {
            // AAA
            // Arrange
            AdapterExample sut;

            // Act
            Action todo = () => sut = new AdapterExample(null, new MessageTestService());

            // Assert
            todo.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void ShouldAdapterExampleThrowExceptionIfSecondArgumentNull()
        {
            // AAA
            // Arrange
            AdapterExample sut;

            // Act
            Action todo = () => sut = new AdapterExample(new AddressTestRepository(), null);

            // Assert
            todo.ShouldThrow<ArgumentNullException>();
        }
    }
}

using System;
using System.Data;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01Adapter.Tests
{
    [TestClass]
    public class AddressDbDataAdapterRepositoryTest
    {
        [TestMethod]
        public void AddressDataAdapterRepositoryShouldThrowifArgumentNull()
        {
            // AAA
            // Arrange
            AddressDbDataAdapterRepository sut;

            // Act
            Action todo = () => sut = new AddressDbDataAdapterRepository(null);

            // Assert
            todo.ShouldThrow<ArgumentNullException>();

        }
    }
}

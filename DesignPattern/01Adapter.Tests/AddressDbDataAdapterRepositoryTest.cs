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

        [TestMethod]
        public void AddressDataAdapterRepositoryShouldReturnData()
        {
            // Arrange
            IDbDataAdapter adapter = new MockDbDataAdapter();
            AddressDbDataAdapterRepository sut = new AddressDbDataAdapterRepository(adapter);

            // Act
            var list = sut.GetAddresses();

            // Assert
            list.Should().HaveCount(1, "mivel egy elemet kuldunk a repoba")
                .And
                .Should().Equals(new Address { Email = "example@gmail.com" });
        }
    }
}

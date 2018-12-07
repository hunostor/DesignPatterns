using System;
using System.Data;
using _01Adapter.Resource;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01Adapter.Tests
{
    [TestClass]
    public class MockDbDataAdapterTests
    {
        [TestMethod]
        public void MockAddressDataAdapterRepositoryShouldThrowifArgumentNull()
        {
            // AAA
            // Arrange
            MockDbDataAdapter sut = new MockDbDataAdapter();

            // Act
            Action todo = () => sut.Fill(null);

            // Assert
            todo.ShouldThrow<ArgumentNullException>();

        }

        [TestMethod]
        public void MockDbDataAdapterShouldReturnOneTable()
        {
            // AAA
            // Arrange
            MockDbDataAdapter sut = new MockDbDataAdapter();
            var dataSet = new DataSet();
            // Act
            sut.Fill(dataSet);

            // Assert
            dataSet.Tables.Should().HaveCount(1);
        }

        [TestMethod]
        public void MockDbDataAdapterShouldReturnData()
        {
            // AAA
            // Arrange
            MockDbDataAdapter sut = new MockDbDataAdapter();
            var dataSet = new DataSet();
            // Act
            sut.Fill(dataSet);

            // Assert
            dataSet.Tables.Should().HaveCount(1);

            var table = dataSet.Tables[0];
            table.Rows.Should().HaveCount(1);
            table.Columns[GlobalStrings.TableColumnEmailAddress].Should().NotBeNull();
            table.Rows[0][GlobalStrings.TableColumnEmailAddress].Should().Be(GlobalStrings.TesztEmailAddress);
        }
    }
}

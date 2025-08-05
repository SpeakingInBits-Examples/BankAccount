using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests;

[TestClass]
public class ValidatorTests
{
    [TestMethod]
    public void IsWithinRange_MinInclusiveBound_ReturnsTrue()
    {
        // Arrange - arranging all the data we need for the test
        Validator validator = new();
        double minBoundary = 10;
        double maxBoundary = 100;
        double valueToCheck = 10;

        // Act - call method we are testing
        bool result = validator.IsWithinRange(valueToCheck, minBoundary, maxBoundary);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsWithinRange_MaxInclusiveBound_ReturnsTrue()
    {
        // Arrange
        Validator validator = new();
        double maxBoundary = 10;
        double valueToCheck = 10;
        double minBoundary = 1;

        // Act
        bool result = validator.IsWithinRange(valueToCheck, minBoundary, maxBoundary);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsWithinRange_ValueWithinRange_ReturnTrue()
    {
        // Arrange
        Validator validator = new();
        double valueToCheck = 10;
        double minBoundary = 1;
        double maxBoundary = 100;

        // Act
        bool result = validator.IsWithinRange(valueToCheck, minBoundary, maxBoundary);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsWithinRange_ValueLessThanMinBoundary_ReturnFalse()
    {
        Validator validator = new();
        double valueToCheck = 5;
        double minBoundary = 6;
        double maxBoundary = 100;

        bool result = validator.IsWithinRange(valueToCheck, minBoundary, maxBoundary);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsWithinRange_ValueGreaterThanMaxBoundary_ReturnsFalse()
    {
        Validator validator = new();
        double valueToCheck = 1000.01;
        double minBoundary = 0;
        double maxBoundary = 1000;

        bool result = validator.IsWithinRange(valueToCheck, minBoundary, maxBoundary);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsWithinRange_MinBoundaryGreaterThanMaxBoundary_ThrowsArgumentException()
    {
        // Arrange
        Validator validator = new();
        double minBoundary = 100;
        double maxBoundary = 0;
        double valueToTest = 50;

        // Assert => Act
        Assert.Throws<ArgumentException>(() => validator.IsWithinRange(valueToTest, minBoundary, maxBoundary));
    }
}
using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> list = new() { 42 };
        int expected = 42;

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 42, 50, 60 };
        int expected = 60;

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -42, -50, -60 };
        int expected = -42;

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 42, -50, 80 };
        int expected = 80;

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 42, 50, 89, 89 };
        int expected = 89;

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

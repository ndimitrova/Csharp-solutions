using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] array = new int[] {6, 10, 4};

        // Act
        int result = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] array = new int[] { 5, 7, 3 };

        // Act
        int result = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(result, Is.EqualTo(-15));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] array = new int[] { 6, 10, 4, 5, 7, 3};

        // Act
        int result = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}

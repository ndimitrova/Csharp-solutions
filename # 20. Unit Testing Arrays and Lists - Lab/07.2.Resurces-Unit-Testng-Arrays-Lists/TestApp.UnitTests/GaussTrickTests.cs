using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> list = new(){42};

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedResult = new() { 5, 5 };
        CollectionAssert.AreEqual(expectedResult, result);

    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new() { 1, 2, 1, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedResult = new() { 5, 5, 1 };
        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new() { 1, 2, 5, 5, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedResult = new() { 5, 5, 10 };
        CollectionAssert.AreEqual(expectedResult, result);

    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new() { 1, 2, 1, 1, 1, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedResult = new() { 5, 5, 2, 1 };
        CollectionAssert.AreEqual(expectedResult, result);
    }
}

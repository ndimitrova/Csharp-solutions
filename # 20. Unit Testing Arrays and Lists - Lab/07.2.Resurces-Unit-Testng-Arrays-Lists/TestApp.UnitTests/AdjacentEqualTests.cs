using NUnit.Framework;

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();
        string expected = string.Empty;

        // Act
        string actual = AdjacentEqual.Sum(emptyList);

        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int> { 2, 2, 3, 4, 5 };
        string expected = "4 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> list = new List<int> { 2, 2 };
        string expected = "4";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int> { 2, 2, 4, 5, };
        string expected = "4 4 5";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int> { 2, 4, 5, 5};
        string expected = "2 4 10";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int> { 2, 5, 5, 12 };
        string expected = "2 10 12";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
